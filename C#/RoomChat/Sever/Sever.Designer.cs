
namespace Sever
{
    partial class Sever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sever));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.listView_ClientList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Checked = new System.Windows.Forms.Button();
            this.btn_File = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Browser = new System.Windows.Forms.Button();
            this.textBox_Browser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listbox_LogFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Sever";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(101, 20);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(162, 22);
            this.textBox_IP.TabIndex = 10;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_send.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(587, 361);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 37);
            this.btn_send.TabIndex = 9;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(37, 361);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(532, 37);
            this.textBoxMessage.TabIndex = 8;
            // 
            // richTextBox_Message
            // 
            this.richTextBox_Message.BackColor = System.Drawing.Color.White;
            this.richTextBox_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Message.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox_Message.Location = new System.Drawing.Point(206, 108);
            this.richTextBox_Message.Name = "richTextBox_Message";
            this.richTextBox_Message.ReadOnly = true;
            this.richTextBox_Message.Size = new System.Drawing.Size(363, 228);
            this.richTextBox_Message.TabIndex = 14;
            this.richTextBox_Message.Text = "";
            this.richTextBox_Message.TextChanged += new System.EventHandler(this.richTextBox_Message_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(280, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Name.Location = new System.Drawing.Point(331, 20);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(170, 22);
            this.textBox_Name.TabIndex = 16;
            this.textBox_Name.Text = "Sever";
            // 
            // listView_ClientList
            // 
            this.listView_ClientList.CheckBoxes = true;
            this.listView_ClientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_ClientList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_ClientList.HideSelection = false;
            this.listView_ClientList.Location = new System.Drawing.Point(37, 108);
            this.listView_ClientList.Name = "listView_ClientList";
            this.listView_ClientList.Size = new System.Drawing.Size(146, 228);
            this.listView_ClientList.TabIndex = 17;
            this.listView_ClientList.UseCompatibleStateImageBehavior = false;
            this.listView_ClientList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client";
            this.columnHeader1.Width = 87;
            // 
            // btn_Checked
            // 
            this.btn_Checked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Checked.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
            this.btn_Checked.ForeColor = System.Drawing.Color.White;
            this.btn_Checked.Location = new System.Drawing.Point(37, 65);
            this.btn_Checked.Name = "btn_Checked";
            this.btn_Checked.Size = new System.Drawing.Size(75, 35);
            this.btn_Checked.TabIndex = 19;
            this.btn_Checked.Text = "Uncheck";
            this.btn_Checked.UseVisualStyleBackColor = false;
            this.btn_Checked.Click += new System.EventHandler(this.btn_Checked_Click);
            // 
            // btn_File
            // 
            this.btn_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btn_File.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_File.ForeColor = System.Drawing.Color.White;
            this.btn_File.Location = new System.Drawing.Point(675, 361);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(75, 37);
            this.btn_File.TabIndex = 20;
            this.btn_File.Text = "File";
            this.btn_File.UseVisualStyleBackColor = false;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_Create.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Location = new System.Drawing.Point(587, 23);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(163, 35);
            this.btn_Create.TabIndex = 21;
            this.btn_Create.Text = "Create Room";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Browser
            // 
            this.btn_Browser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Browser.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browser.ForeColor = System.Drawing.Color.White;
            this.btn_Browser.Location = new System.Drawing.Point(494, 66);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(75, 37);
            this.btn_Browser.TabIndex = 32;
            this.btn_Browser.Text = "Browse";
            this.btn_Browser.UseVisualStyleBackColor = false;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // textBox_Browser
            // 
            this.textBox_Browser.Location = new System.Drawing.Point(283, 73);
            this.textBox_Browser.Name = "textBox_Browser";
            this.textBox_Browser.Size = new System.Drawing.Size(196, 22);
            this.textBox_Browser.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(203, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Directory";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(588, 83);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(0, 17);
            this.lb_time.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listbox_LogFile
            // 
            this.listbox_LogFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbox_LogFile.FormattingEnabled = true;
            this.listbox_LogFile.ItemHeight = 16;
            this.listbox_LogFile.Location = new System.Drawing.Point(587, 108);
            this.listbox_LogFile.Name = "listbox_LogFile";
            this.listbox_LogFile.Size = new System.Drawing.Size(163, 228);
            this.listbox_LogFile.TabIndex = 41;
            this.listbox_LogFile.DoubleClick += new System.EventHandler(this.listbox_LogFile_DoubleClick);
            // 
            // Sever
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 416);
            this.Controls.Add(this.listbox_LogFile);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Browser);
            this.Controls.Add(this.textBox_Browser);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.btn_Checked);
            this.Controls.Add(this.listView_ClientList);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_Message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sever";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sever";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sever_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBox_Message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ListView listView_ClientList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_Checked;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Browser;
        private System.Windows.Forms.TextBox textBox_Browser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listbox_LogFile;
    }
}

