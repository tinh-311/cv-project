
namespace Dictionary2
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.label_NhapTu = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_tuTA = new System.Windows.Forms.TextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_NhapTu
            // 
            this.label_NhapTu.AutoSize = true;
            this.label_NhapTu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_NhapTu.ForeColor = System.Drawing.Color.White;
            this.label_NhapTu.Location = new System.Drawing.Point(38, 81);
            this.label_NhapTu.Name = "label_NhapTu";
            this.label_NhapTu.Size = new System.Drawing.Size(99, 24);
            this.label_NhapTu.TabIndex = 16;
            this.label_NhapTu.Text = "Nhập từ: ";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(52)))));
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(206, 146);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(82, 32);
            this.btn_OK.TabIndex = 15;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_tuTA
            // 
            this.textBox_tuTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.textBox_tuTA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_tuTA.ForeColor = System.Drawing.Color.Green;
            this.textBox_tuTA.Location = new System.Drawing.Point(153, 77);
            this.textBox_tuTA.Name = "textBox_tuTA";
            this.textBox_tuTA.Size = new System.Drawing.Size(274, 30);
            this.textBox_tuTA.TabIndex = 14;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(199, 24);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(98, 28);
            this.lb_title.TabIndex = 13;
            this.lb_title.Text = "XÓA TỪ";
            // 
            // DeleteForm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(464, 202);
            this.Controls.Add(this.label_NhapTu);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_tuTA);
            this.Controls.Add(this.lb_title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NhapTu;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox_tuTA;
        private System.Windows.Forms.Label lb_title;
    }
}