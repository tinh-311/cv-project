
namespace Dictionary2
{
    partial class InsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.btn_chuThich = new System.Windows.Forms.Button();
            this.lb_chuthich = new System.Windows.Forms.Label();
            this.rich_nghia = new System.Windows.Forms.RichTextBox();
            this.label_NhapNghia = new System.Windows.Forms.Label();
            this.label_NhapTu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tu = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_tuTA = new System.Windows.Forms.TextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_chuThich
            // 
            this.btn_chuThich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(61)))));
            this.btn_chuThich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chuThich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chuThich.ForeColor = System.Drawing.Color.White;
            this.btn_chuThich.Location = new System.Drawing.Point(566, 172);
            this.btn_chuThich.Name = "btn_chuThich";
            this.btn_chuThich.Size = new System.Drawing.Size(22, 18);
            this.btn_chuThich.TabIndex = 23;
            this.btn_chuThich.UseVisualStyleBackColor = false;
            this.btn_chuThich.Click += new System.EventHandler(this.btn_chuThich_Click);
            // 
            // lb_chuthich
            // 
            this.lb_chuthich.AutoSize = true;
            this.lb_chuthich.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chuthich.ForeColor = System.Drawing.Color.White;
            this.lb_chuthich.Location = new System.Drawing.Point(194, 172);
            this.lb_chuthich.Name = "lb_chuthich";
            this.lb_chuthich.Size = new System.Drawing.Size(344, 18);
            this.lb_chuthich.TabIndex = 22;
            this.lb_chuthich.Text = "Thêm kí tự * ở đầu để ghi từ loại - VD: * Danh từ";
            // 
            // rich_nghia
            // 
            this.rich_nghia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.rich_nghia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rich_nghia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rich_nghia.ForeColor = System.Drawing.Color.Green;
            this.rich_nghia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rich_nghia.Location = new System.Drawing.Point(192, 194);
            this.rich_nghia.Name = "rich_nghia";
            this.rich_nghia.Size = new System.Drawing.Size(396, 195);
            this.rich_nghia.TabIndex = 21;
            this.rich_nghia.Text = "";
            // 
            // label_NhapNghia
            // 
            this.label_NhapNghia.AutoSize = true;
            this.label_NhapNghia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_NhapNghia.ForeColor = System.Drawing.Color.White;
            this.label_NhapNghia.Location = new System.Drawing.Point(47, 194);
            this.label_NhapNghia.Name = "label_NhapNghia";
            this.label_NhapNghia.Size = new System.Drawing.Size(130, 24);
            this.label_NhapNghia.TabIndex = 20;
            this.label_NhapNghia.Text = "Nhập nghĩa: ";
            // 
            // label_NhapTu
            // 
            this.label_NhapTu.AutoSize = true;
            this.label_NhapTu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_NhapTu.ForeColor = System.Drawing.Color.White;
            this.label_NhapTu.Location = new System.Drawing.Point(47, 104);
            this.label_NhapTu.Name = "label_NhapTu";
            this.label_NhapTu.Size = new System.Drawing.Size(99, 24);
            this.label_NhapTu.TabIndex = 19;
            this.label_NhapTu.Text = "Nhập từ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 18;
            // 
            // lb_tu
            // 
            this.lb_tu.AutoSize = true;
            this.lb_tu.Location = new System.Drawing.Point(472, 71);
            this.lb_tu.Name = "lb_tu";
            this.lb_tu.Size = new System.Drawing.Size(0, 17);
            this.lb_tu.TabIndex = 17;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(285, 419);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(106, 43);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_tuTA
            // 
            this.textBox_tuTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.textBox_tuTA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_tuTA.ForeColor = System.Drawing.Color.Green;
            this.textBox_tuTA.Location = new System.Drawing.Point(192, 103);
            this.textBox_tuTA.Name = "textBox_tuTA";
            this.textBox_tuTA.Size = new System.Drawing.Size(396, 30);
            this.textBox_tuTA.TabIndex = 15;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(251, 33);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(164, 38);
            this.lb_title.TabIndex = 14;
            this.lb_title.Text = "THÊM TỪ";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(634, 495);
            this.Controls.Add(this.btn_chuThich);
            this.Controls.Add(this.lb_chuthich);
            this.Controls.Add(this.rich_nghia);
            this.Controls.Add(this.label_NhapNghia);
            this.Controls.Add(this.label_NhapTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_tu);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_tuTA);
            this.Controls.Add(this.lb_title);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chuThich;
        private System.Windows.Forms.Label lb_chuthich;
        private System.Windows.Forms.RichTextBox rich_nghia;
        private System.Windows.Forms.Label label_NhapNghia;
        private System.Windows.Forms.Label label_NhapTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tu;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox_tuTA;
        private System.Windows.Forms.Label lb_title;
    }
}