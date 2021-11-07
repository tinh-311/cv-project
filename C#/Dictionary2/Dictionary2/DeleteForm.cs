using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary2
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            textBox_tuTA.Focus();
        }

        #region even_click
        private void btn_OK_Click(object sender, EventArgs e)
        {
            delete();
        }
        #endregion

        // Bấm ESC để thoát
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Dispose();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region methods
        private void delete()
        {
            String s = (String)textBox_tuTA.Text.ToString();

            s = s.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            s = trimmer.Replace(s, " ");

            if (s == "")
            {
                MessageBox.Show("Bạn chưa nhập từ cần xóa !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_tuTA.Focus();
            }
            else
            {

                try
                {
                    s.Trim();
                    int k = cons.hash(s[0]);
                    Boolean kt = mainForm.hashTB.Linked_List[k].xoa(s);
                    if (kt == true)
                    {
                        MessageBox.Show("Đã xóa !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_tuTA.Text = "";
                        textBox_tuTA.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Từ không tồn tại !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_tuTA.Text = "";
                        textBox_tuTA.Focus();
                    }
                }
                catch { }
            }
        }
        #endregion
    }
}
