using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardMenager chessBoard;
        SocketManager socket;
        #endregion

        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            chessBoard = new ChessBoardMenager(panel_chessBoard, label_PlayerName, pictureBox_Mark);
            chessBoard.EndedGame += ChessBoard_EndedGame;
            chessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            progressBar_CountDown.Step = cons.COUNTDOWN_STEP;
            progressBar_CountDown.Maximum = cons.COUNTDOWN_TIME;
            progressBar_CountDown.Value = 0;

            timerCountDown.Interval = cons.COUNTDOWN_INTERVAL;

            socket = new SocketManager();

            NewGame();
            panel_chessBoard.Enabled = false;
            pictureBox_Mark.Image = Image.FromFile("pencil.png");
            label_PlayerName.Text = "Welcom !";
        }

        #region Methods
        void EndGame()
        {
            timerCountDown.Stop();
            if (panel_chessBoard.Enabled == false)
            {
                MessageBox.Show($"Bạn thắng", "Caro Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Bạn thua", "Caro Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            panel_chessBoard.Enabled = false;
        }

        void NewGame()
        {
            progressBar_CountDown.Value = 0;
            timerCountDown.Stop();
            chessBoard.drawChessBoard();
        }

        void Quit()
        {
            Application.Exit();
        }

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            timerCountDown.Start();
            panel_chessBoard.Enabled = false;
            progressBar_CountDown.Value = 0;

            try
            {
                socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
                label_PlayerName.Text = "Lượt của đối thủ";
            }
            catch { }

            Listen();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            try
            {
                socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
            }
            catch { }
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            progressBar_CountDown.PerformStep();
            if (progressBar_CountDown.Value >= progressBar_CountDown.Maximum)
            {
                EndGame();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewGame();
                if (panel_chessBoard.Enabled == true)
                {
                    label_PlayerName.Text = "Lượt của bạn";
                }
                else if (panel_chessBoard.Enabled == false)
                {
                    label_PlayerName.Text = "Lượt của đối thủ";
                }
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                panel_chessBoard.Enabled = true;
            }
            catch { }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Caro Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    cons.isAccept = false;
                    if (!cons.isAccept && cons.isClickLan)
                    {
                        socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    }
                }
                catch { }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(textBox_IP.Text))
            {
                textBox_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
                textBox_IP.Enabled = false;
            }
        }


        private void btn_LAN_Click(object sender, EventArgs e)
        {
            socket.IP = textBox_IP.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                panel_chessBoard.Enabled = false;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                panel_chessBoard.Enabled = false;
                button_NewGame.Enabled = false;
                newGameToolStripMenuItem.Enabled = false;
                Listen();
            }

            btn_LAN.Enabled = false;
            cons.isClickLan = true;
        }

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch { }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        panel_chessBoard.Enabled = false;
                        if (panel_chessBoard.Enabled == true)
                        {
                            label_PlayerName.Text = "Lượt của bạn";
                        }
                        else if (panel_chessBoard.Enabled == false)
                        {
                            label_PlayerName.Text = "Lượt của đối thủ";
                        }
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        progressBar_CountDown.Value = 0;
                        panel_chessBoard.Enabled = true;
                        label_PlayerName.Text = "Lượt của bạn";
                        timerCountDown.Start();
                        chessBoard.OtherPlayerMark(data.Point);
                        newGameToolStripMenuItem.Enabled = true;
                        button_NewGame.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.QUIT:
                    timerCountDown.Stop();
                    MessageBox.Show("Người chơi đã thoát", "Caro Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }

            Listen();
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            try
            {
                NewGame();
                if (panel_chessBoard.Enabled == true)
                {
                    label_PlayerName.Text = "Lượt của bạn";
                }
                else if (panel_chessBoard.Enabled == false)
                {
                    label_PlayerName.Text = "Lượt của đối thủ";
                }
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                panel_chessBoard.Enabled = true;
            }
            catch { }
        }
        #endregion
    }
}
