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

namespace Sever
{
    public partial class Sever : Form
    {
        Socket sever;
        IPEndPoint IP;
        List<Socket> clientList;
        List<String> clientNameList = new List<string>();
        bool isConnect = false;
        bool ischeckedAll = true;

        public Sever()
        {
            InitializeComponent();

            timer1.Start();

            string Dir = System.IO.Directory.GetCurrentDirectory();
            textBox_Browser.Text = Dir + "\\";
            CheckForIllegalCrossThreadCalls = false;

            richTextBox_Message.SelectAll();
            richTextBox_Message.SelectionIndent += 5;
            richTextBox_Message.SelectionRightIndent += 5;
        }

        #region button_Click
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (!isConnect)
            {
                if (textBox_Name.Text != "")
                {
                    Connect();
                    if (isConnect)
                    {
                        MessageBox.Show("Tạo phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_Name.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên để tạo phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Phòng đã được tạo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            textBoxMessage.Focus();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (isConnect)
            {
                int lenListView = listView_ClientList.Items.Count;
                string s = "";
                int count = 0;
                for (int i = 0; i < lenListView; i++)
                {
                    if (listView_ClientList.Items[i].Checked == true)
                    {
                        count++;
                    }
                }

                if (lenListView == count)
                {
                    s = textBox_Name.Text + " (All): " + textBoxMessage.Text;
                }
                else
                {
                    s = textBox_Name.Text + " (Private - " + count + "): " + textBoxMessage.Text;
                }

                for (int i = 0; i < lenListView; i++)
                {
                    if (listView_ClientList.Items[i].Checked == true)
                    {
                        Send(clientList[i], s);
                    }
                }

                if(textBoxMessage.Text != string.Empty)
                {
                    if(count != 0)
                    {
                        if (lenListView == count)
                        {
                            addRichTextBox("Bạn (All): " + textBoxMessage.Text);
                        }
                        else
                        {
                            addRichTextBox("Bạn (Private - " + count + "): " + textBoxMessage.Text);
                        }
                    }
                }
                
                textBoxMessage.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng tạo phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxMessage.Focus();
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(sendFile);
            thread.Start();
        }

        private void sendFile() //Thread
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
                    string fileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\") + 1);

                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    long len = fi.Length;

                    int count = 0;
                    int lenListView = listView_ClientList.Items.Count;
                    for (int i = 0; i < lenListView; i++)
                    {
                        if (listView_ClientList.Items[i].Checked == true)
                        {
                            count++;
                        }
                    }
                    string s = "";
                    if (count == lenListView)
                    {
                        s = "&&&&&&SENDFILE_" + textBox_Name.Text + " (All)" + "@" + fileName + "$" + len.ToString();
                    }
                    else
                    {
                        s = "&&&&&&SENDFILE_" + textBox_Name.Text + " (Private - " + count + ")" + "@" + fileName + "$" + len.ToString();
                    }

                    for (int i = 0; i < lenListView; i++)
                    {
                        if (listView_ClientList.Items[i].Checked == true)
                        {
                            try
                            {
                                clientList[i].Send(Serialize(s));
                                SendFile(clientList[i], openFileDialog1.FileName);
                            }
                            catch { }
                        }
                    }


                    if (count != 0)
                    {
                        if (count == lenListView)
                        {
                            addRichTextBox("Bạn (All): đã gửi một file - " + fileName);
                        }
                        else
                        {
                            addRichTextBox("Bạn (Private - " + count + "): đã gửi một file - " + fileName);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng tạo phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxMessage.Focus();
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

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

        private void btn_Checked_Click(object sender, EventArgs e)
        {
            int k = listView_ClientList.Items.Count;

            if (!ischeckedAll)
            {
                ischeckedAll = true;
                for (int i = 0; i < k; i++)
                {
                    listView_ClientList.Items[i].Checked = true;
                }
                btn_Checked.Text = "Uncheck";
            }
            else
            {
                ischeckedAll = false;
                for (int i = 0; i < k; i++)
                {
                    listView_ClientList.Items[i].Checked = false;
                    btn_Checked.Text = "Check";
                }
            }

            textBoxMessage.Focus();
        }
        #endregion

        #region methods
        /// Kết nối đến sever
        void Connect()
        {
            textBox_IP.Text = GetLocalIPv4();

            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 2311);
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            sever.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        sever.Listen(100);
                        Socket client = sever.Accept();

                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch { }
            });

            Listen.IsBackground = true;
            Listen.Start();
            isConnect = true;
        }

        /// Đóng kết nối hiện thời
        void Close()
        {
            if (isConnect)
            {
                sever.Close();
            }
        }

        /// Gửi tin đến tất cả client
        void Send(Socket client, string s)
        {
            if (client != null && textBoxMessage.Text != string.Empty)
            {
                client.Send(Serialize(s));
            }
        }

        /// Gửi file đến tắt cả client
        void SendFile(Socket client, string fileName)
        {
            byte[] bytes = File.ReadAllBytes(fileName);
            client.Send(bytes);
        }

        /// Nhận tin
        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            string nameSend = null;
            string fileOut = null;
            string clientSend = null;
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

                        if (message.Contains("&&&&&&SENDFILE_")) // Nhận file
                        {
                            Thread thread = new Thread(() => ReceiveFile(ref message, ref len, ref fileOut, ref nameSend, ref clientSend, ref client));
                            thread.Start();
                        }
                        else if (message == "@#$%+-EXIT()") // Nhận thông báo client đã thoát room
                        {
                            ReceiveExit(ref client);
                        }
                        else if (message.Contains("@#$%+-getNameClient")) // Nhận tên client vừa kết nối vào room
                        {
                            ReceiveClient(ref message, ref client);
                        }
                        else // tin nhắn
                        {
                            ReceiveMessage(ref message);
                        }
                    }
                    catch { }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        private void addRichTextBox(string s)
        {
            try
            {
                richTextBox_Message.AppendText(Environment.NewLine + s);
            }
            catch
            {
                richTextBox_Message.Clear();
                richTextBox_Message.AppendText(Environment.NewLine + s);
            }
        }

        // Nhận file
        private void ReceiveFile(ref string message, ref long len, ref string fileOut, ref string nameSend, ref string clientSend, ref Socket client)
        {
            message = message.Substring(15);
            string[] s = message.Split('%');
            string[] s1 = s[1].Split('#');
            string[] s2 = s1[1].Split('$');

            len = long.Parse(s2[1]);

            fileOut = s2[0];
            nameSend = s1[0];
            clientSend = s[0];

            byte[] data1 = new byte[len];
            client.Receive(data1);

            string[] s3 = clientSend.Split('@');

            bool flag = false;
            for (int i = 0; i < listView_ClientList.Items.Count; i++)
            {
                foreach (string item in s3)
                {
                    if (item == listView_ClientList.Items[i].Text)
                    {
                        clientList[i].Send(Serialize("&&&&&&SENDFILE_" + nameSend + "@" + fileOut + "$" + len.ToString()));
                        clientList[i].Send(data1);
                    }
                    else if (item == textBox_Name.Text)
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                File.WriteAllBytes(textBox_Browser.Text + fileOut, data1);
                listbox_LogFile.Items.Add(nameSend + ": " + fileOut + " @" + textBox_Browser.Text + fileOut);

                addRichTextBox(nameSend + ": đã gửi một file - " + fileOut);

                int visibleItems = listbox_LogFile.ClientSize.Height / listbox_LogFile.ItemHeight;
                listbox_LogFile.TopIndex = Math.Max(listbox_LogFile.Items.Count - visibleItems + 1, 0);
                listbox_LogFile.SetSelected(listbox_LogFile.Items.Count - 1, true);
            }
        }

        // Nhận thông báo thoát room từ client
        private void ReceiveExit(ref Socket client)
        {
            string name = "";
            for (int i = 0; i < clientList.Count; i++)
            {
                if (clientList[i] == client)
                {
                    listView_ClientList.Items[i].Remove();
                    clientList.RemoveAt(i);

                    foreach (Socket item in clientList)
                    {
                        if (item != null)
                        {
                            item.Send(Serialize("@#$%+-DeleteName" + clientNameList[i]));
                        }
                    }

                    name = clientNameList[i];
                    clientNameList.RemoveAt(i);
                }
            }

            addRichTextBox(name + " đã thoát !!!");
        }

        // Nhận danh tên client vừa kết nối vào room
        private void ReceiveClient(ref string message, ref Socket client)
        {
            message = message.Substring(19);
            bool checkName = checkNameClient(message);

            if (checkName)
            {
                int tmp = 0;
                while (checkName)
                {
                    tmp++;
                    checkName = checkNameClient(message + tmp.ToString());
                }

                message += tmp.ToString();

                client.Send(Serialize("$$$$$$$$$SENDNAME" + message));
            }

            listView_ClientList.Items.Add(message);
            listView_ClientList.Items[listView_ClientList.Items.Count - 1].Checked = true;

            client.Send(Serialize("@#$%+-getNameSever" + textBox_Name.Text));
            clientNameList.Add(message);

            string stringClientName = "";
            foreach (String item in clientNameList)
            {
                stringClientName += "@" + item;
            }

            Thread.Sleep(50);
            foreach (Socket item in clientList)
            {
                if (item != null)
                {
                    item.Send(Serialize("@#$%+-ClientNameList@" + stringClientName));
                }
            }

            listView_ClientList.Items[listView_ClientList.Items.Count - 1].EnsureVisible();
        }

        // Nhận tin nhắn
        private void ReceiveMessage(ref string message)
        {
            string[] s = message.Split('%');
            string[] s1 = s[0].Split('@');
            bool flag = false;


            for (int i = 0; i < listView_ClientList.Items.Count; i++)
            {
                foreach (string item in s1)
                {
                    if (item == listView_ClientList.Items[i].Text)
                    {
                        clientList[i].Send(Serialize(s[1]));
                    }
                    else if (item == textBox_Name.Text)
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                addRichTextBox(s[1]);
            }
        }

        bool checkNameClient(string message)
        {
            for (int i = 0; i < listView_ClientList.Items.Count; i++)
            {
                if (message == listView_ClientList.Items[i].Text)
                {
                    return true;
                }
            }

            if (message == textBox_Name.Text)
            {
                return true;
            }

            return false;
        }

        /// Thêm tin vào khung chat
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

        /// Lấy ra IP V4 của card mạng đang dùng
        public string GetLocalIPv4()
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                            return output;
                        }
                    }
                }
            }
            return output;
        }
        #endregion

        // Sự kiện đóng form
        private void Sever_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(clientList != null)
            {
                foreach (Socket item in clientList)
                {
                    if (item != null)
                    {
                        item.Send(Serialize("@#$%+-EXIT()"));
                    }
                }
            }
            
            Close();
        }
        // Sự kiện Double Click vào item list box
        private void listbox_LogFile_DoubleClick(object sender, EventArgs e)
        {
            if (listbox_LogFile.SelectedItem != null)
            {
                string k = listbox_LogFile.SelectedItem.ToString();

                string[] k1 = k.Split('@');
                string filePath = k1[1];

                try
                {
                    Process.Start(filePath);
                }
                catch
                {
                    MessageBox.Show("File không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listbox_LogFile.Items.Remove(listbox_LogFile.SelectedItem);
                }
            }
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
            richTextBox_Message.ScrollToCaret();
        }
    }
}
