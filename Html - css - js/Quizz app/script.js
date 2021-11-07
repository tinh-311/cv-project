const quizData = [
    {
        question: 'How old is Tai?',
        a:'10',
        b:'18',
        c:'20',
        d:'100',
        correct:'c'
    }, {
        question: 'What is the most used programming language in 2020?',
        a:'Java',
        b:'C++',
        c:'Python',
        d:'Javascript',
        correct:'d'
    }, {
        question: 'What does HTML stand for?',
        a:'Hypertext Markup Language',
        b:'Hypertext Marker Language',
        c:'Hypertex Language',
        d:'Hypertex To Make Language',
        correct:'a'
    }, {
        question: 'Who is the president of US in 2020?',
        a:'Barrack Obama',
        b:'Donald Trump',
        c:'Biden',
        d:'George',
        correct:'c'
    }, {
        question: 'What year was Javascript launched?',
        a:'1995',
        b:'1996',
        c:'1997',
        d:'none of the above',
        correct:'a'
    }
];


const quiz = document.getElementById('quiz');
const answerELs = document.querySelectorAll('.answer');
const questionEl = document.getElementById('question');
const a_text = document.getElementById('a_text');
const b_text = document.getElementById('b_text');
const c_text = document.getElementById('c_text');
const d_text = document.getElementById('d_text');

const submitBtn = document.getElementById("submit");

let currentQuiz= 0;
let score = 0;

loadQuiz();

function loadQuiz(){
    deselectAnswers();

    const currentQuizData = quizData
    [currentQuiz];
    questionEl.innerText = currentQuizData.question;
    a_text.innerText = currentQuizData.a;
    b_text.innerText = currentQuizData.b;
    c_text.innerText = currentQuizData.c;
    d_text.innerText = currentQuizData.d;

}


function getSelected(){

    let answer = undefined;

    answerELs.forEach((answerEl) => {
       if(answerEl.checked){
           answer = answerEl.id;
       } 
    });
    
    return answer;
}


function deselectAnswers() {
    answerELs.forEach((answerEl) => {
        answerEl.checked = false;
    });
}

null,undefined,0,false,"",
submitBtn.addEventListener("click", () =>{
    //Check to see the answer
    const answer = getSelected();
    
    if(answer){

        if(answer === quizData[currentQuiz].correct){
            score++;
        }
        currentQuiz++;
        
        if(currentQuiz < quizData.length){
            loadQuiz();
        }
        else{
            //TODO: show results
           quiz.innerHTML = `
           <h2>You answered correctly at 
           ${score}/${quizData.length} question.</h2>
            <button onclick = 
            "location.reload()">Reload</button>
           `;
        }
    }


});