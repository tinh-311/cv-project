
namespace GameCaro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_chessBoard = new System.Windows.Forms.Panel();
            this.label_Logo = new System.Windows.Forms.Label();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel_control = new System.Windows.Forms.Panel();
            this.btn_LAN = new System.Windows.Forms.Button();
            this.button_NewGame = new System.Windows.Forms.Button();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.pictureBox_Mark = new System.Windows.Forms.PictureBox();
            this.progressBar_CountDown = new System.Windows.Forms.ProgressBar();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chessBoard
            // 
            this.panel_chessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.panel_chessBoard.Location = new System.Drawing.Point(13, 41);
            this.panel_chessBoard.Name = "panel_chessBoard";
            this.panel_chessBoard.Size = new System.Drawing.Size(855, 716);
            this.panel_chessBoard.TabIndex = 0;
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.label_Logo.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logo.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_Logo.Location = new System.Drawing.Point(29, 162);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(289, 55);
            this.label_Logo.TabIndex = 5;
            this.label_Logo.Text = "Caro Game";
            // 
            // panel_Logo
            // 
            this.panel_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Logo.Controls.Add(this.label_Logo);
            this.panel_Logo.Controls.Add(this.pictureBox_Logo);
            this.panel_Logo.ForeColor = System.Drawing.Color.White;
            this.panel_Logo.Location = new System.Drawing.Point(876, 41);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(350, 242);
            this.panel_Logo.TabIndex = 1;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(119, 22);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(122, 116);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // panel_control
            // 
            this.panel_control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_control.BackColor = System.Drawing.SystemColors.Control;
            this.panel_control.Controls.Add(this.btn_LAN);
            this.panel_control.Controls.Add(this.button_NewGame);
            this.panel_control.Controls.Add(this.label_PlayerName);
            this.panel_control.Controls.Add(this.textBox_IP);
            this.panel_control.Controls.Add(this.pictureBox_Mark);
            this.panel_control.Controls.Add(this.progressBar_CountDown);
            this.panel_control.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_control.Location = new System.Drawing.Point(876, 286);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(350, 471);
            this.panel_control.TabIndex = 0;
            // 
            // btn_LAN
            // 
            this.btn_LAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_LAN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_LAN.ForeColor = System.Drawing.Color.White;
            this.btn_LAN.Location = new System.Drawing.Point(19, 403);
            this.btn_LAN.Name = "btn_LAN";
            this.btn_LAN.Size = new System.Drawing.Size(315, 52);
            this.btn_LAN.TabIndex = 7;
            this.btn_LAN.Text = "Lan";
            this.btn_LAN.UseVisualStyleBackColor = false;
            this.btn_LAN.Click += new System.EventHandler(this.btn_LAN_Click);
            // 
            // button_NewGame
            // 
            this.button_NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.button_NewGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button_NewGame.ForeColor = System.Drawing.Color.White;
            this.button_NewGame.Location = new System.Drawing.Point(19, 319);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(312, 52);
            this.button_NewGame.TabIndex = 6;
            this.button_NewGame.Text = "New Game";
            this.button_NewGame.UseVisualStyleBackColor = false;
            this.button_NewGame.Click += new System.EventHandler(this.button_NewGame_Click);
            // 
            // label_PlayerName
            // 
            this.label_PlayerName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerName.Location = new System.Drawing.Point(52, 91);
            this.label_PlayerName.Name = "label_PlayerName";
            this.label_PlayerName.Size = new System.Drawing.Size(276, 45);
            this.label_PlayerName.TabIndex = 0;
            this.label_PlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox_IP.Location = new System.Drawing.Point(20, 248);
            this.textBox_IP.Multiline = true;
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(309, 37);
            this.textBox_IP.TabIndex = 3;
            this.textBox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_Mark
            // 
            this.pictureBox_Mark.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_Mark.Location = new System.Drawing.Point(163, 14);
            this.pictureBox_Mark.Name = "pictureBox_Mark";
            this.pictureBox_Mark.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Mark.TabIndex = 2;
            this.pictureBox_Mark.TabStop = false;
            // 
            // progressBar_CountDown
            // 
            this.progressBar_CountDown.Location = new System.Drawing.Point(20, 173);
            this.progressBar_CountDown.Name = "progressBar_CountDown";
            this.progressBar_CountDown.Size = new System.Drawing.Size(309, 41);
            this.progressBar_CountDown.TabIndex = 1;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(60, 24);
            this.menu.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1242, 760);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.panel_Logo);
            this.Controls.Add(this.panel_chessBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_chessBoard;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.PictureBox pictureBox_Mark;
        private System.Windows.Forms.ProgressBar progressBar_CountDown;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label_Logo;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button button_NewGame;
        private System.Windows.Forms.Button btn_LAN;
        private System.Windows.Forms.Label label_PlayerName;
    }
}

