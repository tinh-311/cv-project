using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public class ChessBoardMenager
    {
        #region properties
        private Panel chessBoard;
        private Label label_PlayerName;
        private PictureBox pictureBox_Mark;
        public List<Player> players;
        private int currentPlayer;
        private List<List<Button>> matrix;
        private Stack<PlayInfo> playTimeLine;

        private PictureBox playerMark;

        public PictureBox PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value; }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }


        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public PictureBox PictureBox_Mark { get => pictureBox_Mark; set => pictureBox_Mark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        internal Stack<PlayInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }
        public Label Label_PlayerName { get => label_PlayerName; set => label_PlayerName = value; }

        #endregion

        #region Initialize
        public ChessBoardMenager(Panel chessBoard, Label label_PlayerName, PictureBox pictureBox_Mark)
        {
            this.chessBoard = chessBoard;
            this.Label_PlayerName = label_PlayerName;
            this.PictureBox_Mark = pictureBox_Mark;

            this.players = new List<Player>()
            {
                new Player("Người chơi 1", Image.FromFile("X.png")),
                new Player("Người chơi 2", Image.FromFile("O.png"))
            };
        }
        #endregion

        #region Methods
        public void drawChessBoard()
        {
            chessBoard.Enabled = true;
            chessBoard.Controls.Clear();

            PlayTimeLine = new Stack<PlayInfo>();

            currentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = cons.CHESS_WIDTH,
                        Height = cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;
                    chessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + cons.CHESS_HEIGHT);
                oldButton.Width = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
            {
                return;
            }

            Mark(btn);

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), currentPlayer));

            currentPlayer = currentPlayer == 1 ? 0 : 1;
            ChangePlayer();

            if (playerMarked != null)
            {
                playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));
            }

            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            cons.oldBtn.BackColor = default;
            btn.BackColor = Color.GreenYellow;
            cons.oldBtn = btn;

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();

            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
            }
        }

        private bool isEndGame(Button btn)
        {
            cons.btnWin = btn;
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimaryDiagonal(btn) || isEndSubDiagonal(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = int.Parse(btn.Tag.ToString());
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }

        //Check row
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            for (int i = point.X + 1; i < cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count >= 5;
        }

        //Check Col
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            for (int i = point.Y + 1; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count >= 5;
        }

        //Check đường chéo chính
        private bool isEndPrimaryDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0) { break; }

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.X + i >= cons.CHESS_BOARD_WIDTH || point.Y + i >= cons.CHESS_BOARD_HEIGHT) { break; }

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count >= 5;
        }

        //Check đường chéo phụ
        private bool isEndSubDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i < cons.CHESS_BOARD_WIDTH && point.Y - i >= 0)
                {
                    if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    {
                        count++;
                    }
                    else
                        break;
                }
            }

            for (int i = 1; i <= cons.CHESS_BOARD_WIDTH; i++)
            {
                if (point.Y + i < cons.CHESS_BOARD_HEIGHT && point.X - i >= 0)
                {
                    if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    {
                        count++;
                    }
                    else
                        break;
                }
            }

            return count >= 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = players[currentPlayer].Mark;
        }

        private void ChangePlayer()
        {
            PictureBox_Mark.Image = players[currentPlayer].Mark;
        }
        #endregion
    }

    public class ButtonClickEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint
        {
            get { return clickedPoint; }
            set { clickedPoint = value; }
        }

        public ButtonClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
    }
}
