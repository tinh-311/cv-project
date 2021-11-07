const $ = document.querySelector.bind(document)
const $$ = document.querySelectorAll.bind(document)

const player = $('.player')
const heading = $('header h2')
const cdThumb = $('.cd-thumb')
const audio = $('#audio')
const playBtn = $('.btn-toggle-play')
const progress = $('#progress')
const nextBtn = $('.btn-next')
const prevBtn = $('.btn-prev')
const randomBtn = $('.btn-random')
const repeatBtn = $('.btn-repeat')
const playList = $('.playlist')
const arrRandom = []

const app = {
    currentIndex: 0,

    songs: [
        {
            name: 'Let her go' ,
            singer: 'Passenger',
            path: './assets/sound/Let Her Go - Passenger.mp3',
            image: './assets/img/1jpg.jpg'
        },
        {
            name: 'Share That Love' ,
            singer: 'Lukas Graham',
            path: './assets/sound/Share That Love.mp3',
            image: './assets/img/1jpg.jpg'
        },
        {
            name: 'Mood' ,
            singer: 'Lann Dior',
            path: './assets/sound/y2meta.com - 24kGoldn - Mood (Lyrics) ft. Iann Dior (128 kbps).mp3',
            image: './assets/img/1jpg.jpg'
        },
        {
            name: 'Dễ đến dễ đi' ,
            singer: 'Quang Hùng MasterD',
            path: './assets/sound/y2meta.com - Dễ Đến Dễ Đi (Orinn Remix) - Quang Hùng MasterD _ Nhạc Trẻ Remix EDM TikTok Gây Nghiện Hay Nhất 2020 (128 kbps).mp3',
            image: './assets/img/1jpg.jpg'
        },
        {
            name: 'Mỹ nhân' ,
            singer: 'Đinh Đại Vũ',
            path: './assets/sound/y2meta.com - Mỹ Nhân (Orinn Remix) – Đinh Đại Vũ _ Nhạc EDM 8D Tiktok Gây Nghiện Hay Nhất (128 kbps).mp3',
            image: './assets/img/1jpg.jpg'
        },
        {
            name: 'EDM' ,
            singer: 'Unkow',
            path: './assets/sound/y2meta.com - Nhạc EDM Hay ngắn ! (Cho ae làm video) (128 kbps).mp3',
            image: './assets/img/1jpg.jpg'
        },
        {
            name: 'Cảm nhận' ,
            singer: 'Seachain',
            path: './assets/sound/camnhan.mp3',
            image: './assets/img/1jpg.jpg'
        },
        {
            name: 'LK sau này chúng ta' ,
            singer: 'Orrin',
            path: './assets/sound/y2meta.com - 3107-2 - Sau Này Liệu Chúng Ta - Sợ Lắm 2 ft. Hẹn Yêu - Mix Freak D Mashup Lofi Sad Cực Chill - P2 (128 kbps).mp3',
            image: './assets/img/1jpg.jpg'
        }
    ],

    render: function(){
        const htmls = this.songs.map((song, index) => {
            return `
                <div class="song ${(index === this.currentIndex ? 'active':'')}" data-index = ${index}>
                    <div class="thumb" 
                        style="background-image: url('${song.image}')">
                    </div>
                    <div class="body">
                        <h3 class="title">${song.name}</h3>
                        <p class="author">${song.singer}</p>
                    </div>
                    <div class="option">
                        <i class="fas fa-ellipsis-h"></i>
                </div>
             </div>
            `
        })

        playList.innerHTML = htmls.join('')
    },

    defineProperties: function(){
        Object.defineProperty(this, 'currentSong',{
            get: function(){
                return this.songs[this.currentIndex]
            }
        })
    },

    handleEvents: function(){
        const cd = $('.cd')
        const cdWidth = cd.offsetWidth

        isRandom = false
        isRepeat = false
        isPlaying = false
        const _this = this
        isTimeUpdate = true

        // Xử lý xoay và dừng xoay cd
        const cdThumbAnimate = cdThumb.animate([{ transform: "rotate(360deg)" }], {
            duration: 10000, // 10 seconds
            iterations: Infinity
        })

        cdThumbAnimate.pause()

        // Xử lý phóng to thu nhỏ cd khi scroll chuột
        document.onscroll = function(){
            const scrollTop = window.scrollY || document.documentElement.scrollTop
            const newCdWidth = cdWidth - scrollTop
            cd.style.width = newCdWidth > 0 ? newCdWidth + 'px': 0
            cd.style.opacity = newCdWidth / scrollTop
        }

        //Xử lý khi bấm nút play
        playBtn.onclick = function(){
            if(_this.isPlaying){
                audio.pause()
            }
            else{
                audio.play()
            }
        }

        // Khi song được play
        audio.onplay = function(){
            _this.isPlaying = true
            player.classList.add('playing')
            cdThumbAnimate.play()
        }

        // Khi song tạm dừng
        audio.onpause = function(){
            _this.isPlaying = false
            player.classList.remove('playing')
            cdThumbAnimate.pause()
        }

        progress.onmousedown = function() {
            isTimeUpdate = false;
        }

        progress.ontouchstart = function() {
            isTimeUpdate = false;
        }

        // Khi bài hát được tua
        progress.onchange = function(e) {
            const seekTime = audio.duration / 100 * e.target.value;
            audio.currentTime = seekTime;

            isTimeUpdate = true;
        }

        // Khi tiến độ bài hát thay đổi
        audio.ontimeupdate = function(){
            if(audio.duration && isTimeUpdate){
                const progressPercent = Math.floor(audio.currentTime * 100 / audio.duration)
                progress.value = progressPercent
            }
        }

        // khi next song
        nextBtn.onclick = function() {
            if(_this.isRandom){
                _this.playRandomSong()
            }
            else{
                _this.nextSong()
            }
           
            audio.play()
            progress.value = 0
            isTimeUpdate = true
            _this.render()
            _this.scrollToActiveSong()
        }

        // khi prev song
        prevBtn.onclick = function() {
            if(_this.isRandom){
                _this.playRandomSong()
            }
            else{
                _this.prevSong()
            }
            
            audio.play()
            progress.value = 0
            isTimeUpdate = true
            _this.render()
            _this.scrollToActiveSong()
        }

        // khi bật / tắt random
        randomBtn.onclick = function(){
            _this.isRandom = ! _this.isRandom
            this.classList.toggle('active',_this.isRandom)
        }

        // Xử lý lặp lại bài hát
        repeatBtn.onclick = function(){
            _this.isRepeat = ! _this.isRepeat
            this.classList.toggle('active',_this.isRepeat)
        }

        // Xử lý khi hết bài
        audio.onended = function(){
            if(_this.isRepeat){
                 audio.play()
            }
            else{
                 nextBtn.click()
            }
         }

         //Lắng khi khi click vào play list
         playList.onclick = function(e){
             const songNode = e.target.closest('.song:not(active)')
             const songOption = e.target.closest('.option')
             if(songNode || songOption){
                 // click vào item play list
                if(songNode){
                    if(_this.currentIndex !== Number(songNode.dataset.index)){
                        _this.currentIndex = Number(songNode.dataset.index)
                        _this.loadCurrentSong()
                        _this.render()
                        audio.play()
                    }
                }

                // click vào option
                if(songOption){
                }
             }
         }
    },

    scrollToActiveSong: function(){
        setTimeout(()=>{
            $('.song.active').scrollIntoView({
                behavior: 'smooth',
                block: 'center'
            })
        }, 200)
    },

    loadCurrentSong: function(){
        heading.textContent = this.currentSong.name
        cdThumb.style.backgroundImage = `url('${this.currentSong.image}')`
        audio.src = this.currentSong.path
        
        if(arrRandom.length === this.songs.length){

            arrRandom.splice(0,arrRandom.length-1)
            arrRandom.pop()
        }

        arrRandom.push(this.currentIndex)
    },

    nextSong: function(){
        this.currentIndex++;
        if(this.currentIndex >= this.songs.length){
            this.currentIndex = 0
        }
        this.loadCurrentSong()
    },

    prevSong: function(){
        this.currentIndex--
        if(this.currentIndex < 0){
            this.currentIndex =  this.songs.length - 1
        }

        this.loadCurrentSong()
    },

    playRandomSong: function(){
        let r
        let check = true
        do{
            if(arrRandom.length === this.songs.length){

                arrRandom.splice(0,arrRandom.length-1)
                arrRandom.pop()
            }

            check = true
            r = Math.floor(Math.random() *  this.songs.length)

            if(arrRandom.includes(r)){
                check = false
            }

        }while(r === this.currentIndex || !check)
        this.currentIndex = r
        this.loadCurrentSong()
    },

    start: function(){
        // Định nghĩa các thuộc tính cho ob
        this.defineProperties()

        // Lắng nghe và xử lý even
        this.handleEvents()

        // Load current song khi chạy app
        this.loadCurrentSong()

        // Render lại playlist
        this.render()
    }
}

app.start()

