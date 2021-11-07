using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        Socket client;
        IPEndPoint IP;
        bool isConnect = false;
        bool ischeckedAll = true;
        int lenRichTextBox = 0;
        public Client()
        {
            InitializeComponent();

            timer1.Start();

            CheckForIllegalCrossThreadCalls = false;
            string Dir = System.IO.Directory.GetCurrentDirectory();
            textBox_Browser.Text = Dir + "\\";

            richTextBox_Message.SelectAll();
            richTextBox_Message.SelectionIndent += 5;
            richTextBox_Message.SelectionRightIndent += 5;
        }

        #region Button_Click
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!isConnect)
            {
                bool checkConnect = Connect();
                if (checkConnect)
                {
                    MessageBox.Show("Kết nối thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_send.Enabled = true;
                }
                isConnect = true;
            }
            else
            {
                MessageBox.Show("Đã kết nối với sever !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxMessage.Focus();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (isConnect)
            {
                string s = "";
                int tmp = 0;
                for (int i = 0; i < listView_ClientList.Items.Count; i++)
                {
                    if (listView_ClientList.Items[i].Checked == true)
                    {
                        s += "@" + listView_ClientList.Items[i].Text;
                        tmp++;
                    }
                }

                if (tmp == listView_ClientList.Items.Count)
                {
                    s += "%" + textBox_Name.Text + " (All): ";
                }
                else
                {
                    s += "%" + textBox_Name.Text + " (Private - " + tmp + "): ";
                }

                Send(s);

                if (textBoxMessage.Text != string.Empty)
                {
                    if (tmp != 0)
                    {
                        if (tmp == listView_ClientList.Items.Count)
                        {
                            addRichTextBox("Bạn (All): " + textBoxMessage.Text);
                        }
                        else
                        {
                            addRichTextBox("(Bạn Private - " + tmp + "): " + textBoxMessage.Text);
                        }
                    }
                }

                textBoxMessage.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối đến phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxMessage.Focus();
        }


        private void btn_File_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(sendFile);
            thread.Start();
        }

        private void sendFile()
        {
            if (isConnect)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Browse Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string nameFile = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\") + 1);

                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    long len = fi.Length;

                    string s = "&&&&&&SENDFILE_";

                    int lenListView = listView_ClientList.Items.Count;
                    int tmp = 0;
                    for (int i = 0; i < lenListView; i++)
                    {
                        if (listView_ClientList.Items[i].Checked == true)
                        {
                            s += "@" + listView_ClientList.Items[i].Text;
                            tmp++;
                        }
                    }

                    if (tmp == lenListView)
                    {
                        s += "%" + textBox_Name.Text + " (All)" + "#" + nameFile + "$" + len.ToString();
                    }
                    else
                    {
                        s += "%" + textBox_Name.Text + " (Private - " + tmp + ")" + "#" + nameFile + "$" + len.ToString();
                    }

                    try
                    {
                        client.Send(Serialize(s));
;
                        Thread thread = new Thread(() => SendFile(client, openFileDialog1.FileName));
                        thread.Start(); ;
                    }
                    catch { }

                    if (tmp != 0)
                    {
                        if (tmp == lenListView)
                        {
                            addRichTextBox("Bạn (All): đã gửi một file - " + nameFile);
                        }
                        else
                        {
                            addRichTextBox("Bạn (Private - " + tmp + "): đã gửi một file - " + nameFile);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối đến phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxMessage.Focus();
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_Browser.Text = folderDlg.SelectedPath;

                if (textBox_Browser.Text == @"C:\")
                {
                    MessageBox.Show("Không thể lưu file ở đây !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string Dir = System.IO.Directory.GetCurrentDirectory();
                    textBox_Browser.Text = Dir + "\\";
                }
                else if (textBox_Browser.Text != @"D:\" && textBox_Browser.Text != @"E:\"
                    && textBox_Browser.Text != @"F:\" && textBox_Browser.Text != @"G:\" && textBox_Browser.Text != @"H:\")
                {
                    textBox_Browser.Text = textBox_Browser.Text + "\\";
                }

                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            textBoxMessage.Focus();
        }
        #endregion

        #region methods
        /// Kết nối đến sever
        bool Connect()
        {
            string stringIP = textBox_IP.Text;

            if (stringIP == "") { stringIP = "127.0.0.1"; }

            IP = new IPEndPoint(IPAddress.Parse(stringIP), 2311);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến sever !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

            client.Send(Serialize("@#$%+-getNameClient" + textBox_Name.Text));

            textBox_Name.Enabled = false;
            return true;
        }

        /// Đóng kết nối hiện thời
        void Close()
        {
            if (isConnect)
            {
                client.Close();
            }
        }

        /// Gửi tin
        void Send(string clientName)
        {
            if (textBoxMessage.Text != string.Empty)
            {
                client.Send(Serialize(clientName + textBoxMessage.Text));
            }
        }

        //Gửi file
        void SendFile(Socket client, string fileName)
        {
            byte[] bytes = File.ReadAllBytes(fileName);
            client.Send(bytes);
        }

        /// Nhận tin
        void Receive()
        {
            string nameSend = null;
            string fileOut = null;
            long len = 0;
            try
            {
                while (true)
                {

                    try
                    {
                        byte[] data = new byte[1024 * 5000]; // kich thuoc data nhan ve
                        client.Receive(data);

                        string message = (string)Deserialize(data);

                        if (message.Contains("$$$$$$$$$SENDNAME")) // Tên bị trùng server gửi lại tên
                        {
                            message = message.Substring(17);
                            textBox_Name.Text = message;
                        }
                        else if (message.Contains("&&&&&&SENDFILE_")) // Nhận file
                        {
                            Thread thread = new Thread(() => ReceiveFile(ref message, ref nameSend, ref fileOut, ref  len));
                            thread.Start();
                        }
                        else if (message.Contains("@#$%+-EXIT()")) // nhận thông báo kết thúc room chat
                        {
                            MessageBox.Show("Sever đã thoát. Room chat kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        else if (message.Contains("@#$%+-DeleteName")) // Nhận thông báo client đã thoát
                        {
                            Thread thread = new Thread(() => ReceiveClientExit(ref message));
                            thread.Start();
                        }
                        else if (message.Contains("@#$%+-ClientNameList")) // Nhận danh sách tên các client đã kết nối
                        {
                            ReceiveClientList(ref message);
                        }
                        else if (message.Contains("@#$%+-getNameSever")) // Nhận tên server
                        {
                            message = message.Substring(18);
                            listView_ClientList.Items.Add(message);
                            listView_ClientList.Items[listView_ClientList.Items.Count - 1].Checked = true;
                        }
                        else // tin nhắn
                        {
                            addRichTextBox(message);
                        }
                    }
                    catch { }
                }
            }
            catch
            {
                Close();
            }
        }

        private void addRichTextBox(string s)
        {
            try
            {
                richTextBox_Message.AppendText(Environment.NewLine + s);
                lenRichTextBox += s.Length + 1;
            }
            catch
            {
                richTextBox_Message.Clear();
                lenRichTextBox = 0;
                richTextBox_Message.AppendText(Environment.NewLine + s);
                lenRichTextBox += s.Length + 1;
            }
        }

        // Nhận file
        private void ReceiveFile(ref string message, ref string nameSend, ref string fileOut, ref long len)
        {
            message = message.Substring(15);
            string[] s1 = message.Split('@');
            string[] s2 = s1[1].Split('$');

            nameSend = s1[0];
            fileOut = s2[0];

            len = long.Parse(s2[1]);

            byte[] data1 = new byte[len];

            client.Receive(data1);

            File.WriteAllBytes(textBox_Browser.Text + fileOut, data1);
            listBox_logFile.Items.Add(nameSend + ": " + fileOut + " @" + textBox_Browser.Text + fileOut);

            addRichTextBox(nameSend + ": đã gửi một file - " + fileOut);

            int visibleItems = listBox_logFile.ClientSize.Height / listBox_logFile.ItemHeight;
            listBox_logFile.TopIndex = Math.Max(listBox_logFile.Items.Count - visibleItems + 1, 0);
            listBox_logFile.SetSelected(listBox_logFile.Items.Count - 1, true);
        }

        // Nhận thông báo có một client đã thoát
        private void ReceiveClientExit(ref string message)
        {
            message = message.Substring(16);

            for (int i = 0; i < listView_ClientList.Items.Count; i++)
            {
                if (listView_ClientList.Items[i].Text == message)
                {
                    listView_ClientList.Items[i].Remove();
                }
            }

            addRichTextBox(message + " đã thoát !!!");
        }

        // Nhận danh sách các client đã kết nối đến room chat
        private void ReceiveClientList(ref string message)
        {
            message = message.Substring(20);
            string[] arrListStr = message.Split('@');

            foreach (string item in arrListStr)
            {
                if (item != "")
                {
                    if (item != textBox_Name.Text)
                    {
                        int k = listView_ClientList.Items.Count;
                        bool checkList = true;
                        for (int i = 0; i < k; i++)
                        {
                            if (listView_ClientList.Items[i].Text == item) { checkList = false; }
                        }

                        if (checkList)
                        {
                            listView_ClientList.Items.Add(item);
                            listView_ClientList.Items[listView_ClientList.Items.Count - 1].Checked = true;
                        }
                    }
                }
            }
            listView_ClientList.Items[listView_ClientList.Items.Count - 1].EnsureVisible();
        }

        //Thêm tin nhắn vào khung chat
        void AddMessage(string mess)
        {
            addRichTextBox(mess);
            textBoxMessage.Clear();
        }

        /// Phân mảnh
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        /// Gom mảnh
        Object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            stream.Position = 0;
            return formatter.Deserialize(stream);
        }

        #endregion

        //Sự kiện đóng form
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                client.Send(Serialize("@#$%+-EXIT()"));
            }
            catch { }
            Close();
        }

        //Sự kiện double Click vào item list View
        private void listBox_logFile_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_logFile.SelectedItem != null)
            {
                string k = listBox_logFile.SelectedItem.ToString();

                string[] k1 = k.Split('@');
                string filePath = k1[1];

                try
                {
                    Process.Start(filePath);
                }
                catch
                {
                    MessageBox.Show("File không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBox_logFile.Items.Remove(listBox_logFile.SelectedItem);
                }
            }
        }

        private void btn_CheckedClick_Click(object sender, EventArgs e)
        {
            int k = listView_ClientList.Items.Count;

            if (!ischeckedAll)
            {
                ischeckedAll = true;
                for (int i = 0; i < k; i++)
                {
                    listView_ClientList.Items[i].Checked = true;
                }
                btn_CheckedClick.Text = "Uncheck";
            }
            else
            {
                ischeckedAll = false;
                for (int i = 0; i < k; i++)
                {
                    listView_ClientList.Items[i].Checked = false;
                    btn_CheckedClick.Text = "Check";
                }
            }
            textBoxMessage.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string day = dt.ToString();
            lb_time.Text = day;
        }

        // Sự kiện text change
        private void richTextBox_Message_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Message.SelectionStart = lenRichTextBox;
            richTextBox_Message.ScrollToCaret();
        }
    }
}
