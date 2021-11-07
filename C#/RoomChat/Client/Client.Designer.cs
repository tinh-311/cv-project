
namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_File = new System.Windows.Forms.Button();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_ClientList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Browser = new System.Windows.Forms.TextBox();
            this.btn_Browser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CheckedClick = new System.Windows.Forms.Button();
            this.lb_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox_logFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(23, 363);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(522, 37);
            this.textBoxMessage.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_send.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(580, 363);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 37);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // richTextBox_Message
            // 
            this.richTextBox_Message.BackColor = System.Drawing.Color.White;
            this.richTextBox_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Message.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox_Message.Location = new System.Drawing.Point(189, 107);
            this.richTextBox_Message.Name = "richTextBox_Message";
            this.richTextBox_Message.ReadOnly = true;
            this.richTextBox_Message.Size = new System.Drawing.Size(368, 228);
            this.richTextBox_Message.TabIndex = 15;
            this.richTextBox_Message.Text = "";
            this.richTextBox_Message.TextChanged += new System.EventHandler(this.richTextBox_Message_TextChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Name.Location = new System.Drawing.Point(325, 19);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(166, 22);
            this.textBox_Name.TabIndex = 18;
            this.textBox_Name.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(274, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_connect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(580, 22);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(173, 35);
            this.btn_connect.TabIndex = 19;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_File
            // 
            this.btn_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btn_File.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_File.ForeColor = System.Drawing.Color.White;
            this.btn_File.Location = new System.Drawing.Point(678, 363);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(75, 37);
            this.btn_File.TabIndex = 20;
            this.btn_File.Text = "File";
            this.btn_File.UseVisualStyleBackColor = false;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(97, 17);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(153, 22);
            this.textBox_IP.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "IP Sever";
            // 
            // listView_ClientList
            // 
            this.listView_ClientList.CheckBoxes = true;
            this.listView_ClientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_ClientList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_ClientList.HideSelection = false;
            this.listView_ClientList.Location = new System.Drawing.Point(23, 107);
            this.listView_ClientList.Name = "listView_ClientList";
            this.listView_ClientList.Size = new System.Drawing.Size(146, 225);
            this.listView_ClientList.TabIndex = 26;
            this.listView_ClientList.UseCompatibleStateImageBehavior = false;
            this.listView_ClientList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client";
            this.columnHeader1.Width = 87;
            // 
            // textBox_Browser
            // 
            this.textBox_Browser.Location = new System.Drawing.Point(257, 70);
            this.textBox_Browser.Name = "textBox_Browser";
            this.textBox_Browser.Size = new System.Drawing.Size(200, 22);
            this.textBox_Browser.TabIndex = 29;
            // 
            // btn_Browser
            // 
            this.btn_Browser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Browser.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browser.ForeColor = System.Drawing.Color.White;
            this.btn_Browser.Location = new System.Drawing.Point(482, 64);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(75, 37);
            this.btn_Browser.TabIndex = 30;
            this.btn_Browser.Text = "Browse";
            this.btn_Browser.UseVisualStyleBackColor = false;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(186, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Directory";
            // 
            // btn_CheckedClick
            // 
            this.btn_CheckedClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_CheckedClick.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckedClick.ForeColor = System.Drawing.Color.White;
            this.btn_CheckedClick.Location = new System.Drawing.Point(23, 64);
            this.btn_CheckedClick.Name = "btn_CheckedClick";
            this.btn_CheckedClick.Size = new System.Drawing.Size(75, 37);
            this.btn_CheckedClick.TabIndex = 37;
            this.btn_CheckedClick.Text = "Ucheck";
            this.btn_CheckedClick.UseVisualStyleBackColor = false;
            this.btn_CheckedClick.Click += new System.EventHandler(this.btn_CheckedClick_Click);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(586, 83);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(0, 17);
            this.lb_time.TabIndex = 41;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox_logFile
            // 
            this.listBox_logFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBox_logFile.FormattingEnabled = true;
            this.listBox_logFile.ItemHeight = 16;
            this.listBox_logFile.Location = new System.Drawing.Point(580, 107);
            this.listBox_logFile.Name = "listBox_logFile";
            this.listBox_logFile.Size = new System.Drawing.Size(173, 228);
            this.listBox_logFile.TabIndex = 42;
            this.listBox_logFile.DoubleClick += new System.EventHandler(this.listBox_logFile_DoubleClick);
            // 
            // Client
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 420);
            this.Controls.Add(this.listBox_logFile);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.btn_CheckedClick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Browser);
            this.Controls.Add(this.textBox_Browser);
            this.Controls.Add(this.listView_ClientList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_Message);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox richTextBox_Message;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_ClientList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBox_Browser;
        private System.Windows.Forms.Button btn_Browser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CheckedClick;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox_logFile;
    }
}

