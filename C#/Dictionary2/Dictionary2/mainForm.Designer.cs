
namespace Dictionary2
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.lb_date = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.richTextBox_Main = new System.Windows.Forms.RichTextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_gio = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_Main = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_date.ForeColor = System.Drawing.Color.White;
            this.lb_date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_date.Location = new System.Drawing.Point(557, 141);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(0, 19);
            this.lb_date.TabIndex = 18;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_search.Location = new System.Drawing.Point(420, 163);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 33);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Tra từ";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(61)))));
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Reset.Location = new System.Drawing.Point(498, 546);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(115, 40);
            this.btn_Reset.TabIndex = 17;
            this.btn_Reset.Text = "Xóa";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // richTextBox_Main
            // 
            this.richTextBox_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.richTextBox_Main.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox_Main.Font = new System.Drawing.Font("Cambria", 13.2F);
            this.richTextBox_Main.ForeColor = System.Drawing.Color.MediumBlue;
            this.richTextBox_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox_Main.Location = new System.Drawing.Point(558, 163);
            this.richTextBox_Main.Name = "richTextBox_Main";
            this.richTextBox_Main.ReadOnly = true;
            this.richTextBox_Main.Size = new System.Drawing.Size(486, 342);
            this.richTextBox_Main.TabIndex = 16;
            this.richTextBox_Main.Text = "";
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lb_search.ForeColor = System.Drawing.Color.White;
            this.lb_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_search.Location = new System.Drawing.Point(32, 167);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(99, 24);
            this.lb_search.TabIndex = 12;
            this.lb_search.Text = "Nhập từ: ";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold);
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_title.Location = new System.Drawing.Point(343, 58);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(445, 57);
            this.lb_title.TabIndex = 10;
            this.lb_title.Text = "TỪ ĐIỂN ANH VIỆT";
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.textBox_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_search.ForeColor = System.Drawing.Color.Green;
            this.textBox_search.Location = new System.Drawing.Point(147, 163);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(249, 30);
            this.textBox_search.TabIndex = 20;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(147, 448);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(249, 57);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_delete.Location = new System.Drawing.Point(147, 342);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(249, 57);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Xóa từ";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lb_gio
            // 
            this.lb_gio.AutoSize = true;
            this.lb_gio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_gio.ForeColor = System.Drawing.Color.White;
            this.lb_gio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_gio.Location = new System.Drawing.Point(934, 141);
            this.lb_gio.Name = "lb_gio";
            this.lb_gio.Size = new System.Drawing.Size(0, 19);
            this.lb_gio.TabIndex = 19;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_insert.Location = new System.Drawing.Point(147, 237);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(249, 57);
            this.btn_insert.TabIndex = 11;
            this.btn_insert.Text = "Thêm từ";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1110, 28);
            this.menuStrip_Main.TabIndex = 21;
            this.menuStrip_Main.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaHiểnThịToolStripMenuItem,
            this.thêmTừToolStripMenuItem,
            this.xóaTừToolStripMenuItem,
            this.traTừToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // xóaHiểnThịToolStripMenuItem
            // 
            this.xóaHiểnThịToolStripMenuItem.Name = "xóaHiểnThịToolStripMenuItem";
            this.xóaHiểnThịToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.xóaHiểnThịToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.xóaHiểnThịToolStripMenuItem.Text = "Xóa hiển thị";
            this.xóaHiểnThịToolStripMenuItem.Click += new System.EventHandler(this.xóaHiểnThịToolStripMenuItem_Click);
            // 
            // thêmTừToolStripMenuItem
            // 
            this.thêmTừToolStripMenuItem.Name = "thêmTừToolStripMenuItem";
            this.thêmTừToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thêmTừToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.thêmTừToolStripMenuItem.Text = "Thêm từ";
            this.thêmTừToolStripMenuItem.Click += new System.EventHandler(this.thêmTừToolStripMenuItem_Click);
            // 
            // xóaTừToolStripMenuItem
            // 
            this.xóaTừToolStripMenuItem.Name = "xóaTừToolStripMenuItem";
            this.xóaTừToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaTừToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.xóaTừToolStripMenuItem.Text = "Xóa từ";
            this.xóaTừToolStripMenuItem.Click += new System.EventHandler(this.xóaTừToolStripMenuItem_Click);
            // 
            // traTừToolStripMenuItem
            // 
            this.traTừToolStripMenuItem.Name = "traTừToolStripMenuItem";
            this.traTừToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.traTừToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.traTừToolStripMenuItem.Text = "Tra từ";
            this.traTừToolStripMenuItem.Click += new System.EventHandler(this.traTừToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // timer_Main
            // 
            this.timer_Main.Enabled = true;
            this.timer_Main.Interval = 1000;
            this.timer_Main.Tick += new System.EventHandler(this.timer_Main_Tick);
            // 
            // mainForm
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1110, 619);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.richTextBox_Main);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lb_gio);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.RichTextBox richTextBox_Main;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lb_gio;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHiểnThịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer_Main;
    }
}