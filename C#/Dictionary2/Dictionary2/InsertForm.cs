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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
            textBox_tuTA.Focus();
        }

        #region even_click
        private void btn_OK_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void btn_chuThich_Click(object sender, EventArgs e)
        {
            string chuThich = "Để thêm từ loại của từ bạn hãy thêm dấu * ở trước từ loại đó\n sau " +
                "đó bấm Enter để ghi nghĩa của từ loại đó\n\n VD:\n* Động từ\n- Đi, chạy\n- Nhảy,...\n" +
                "* Tính từ\n- Đẹp, xấu,...\n" +
                "\n=> Chú ý: Không được để bất kỳ một dòng trống nào trong ô ghi nghĩa của từ !";
            MessageBox.Show(chuThich, "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        // Bấm Esc để thoát form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Dispose();
            }

            if(keyData == Keys.Up)
            {
                textBox_tuTA.Focus();
            }

            if(keyData == Keys.Down)
            {
                rich_nghia.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region methods
        private void insert()
        {
            String tu = null;
            String nghia = null;
            Word x = new Word();

            tu = (String)textBox_tuTA.Text;
            tu = tu.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            tu = trimmer.Replace(tu, " ");

            if (tu == "" || nghia == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_tuTA.Focus();
            }
            else
            {
                try
                {
                    x.TuTA = tu;
                    int k = cons.hash(tu[0]);

                    bool kt = true;
                    for (Node i = mainForm.hashTB.Linked_List[k].First; i != null; i = i.Link)
                    {
                        string tuTA = cons.xuLyTen(i.Data.TuTA);

                        if (tuTA.ToUpper() == x.TuTA.ToUpper())
                        {
                            kt = false;
                            break;
                        }
                    }

                    if (kt == true)
                    {
                        var lines = rich_nghia.Text.Split('\n').ToList();
                        bool ktKiTuDau = true;
                        foreach (var line in lines)
                        {
                            string lineString = line.ToString();

                            lineString = lineString.Trim();
                            Regex trimmerLineString = new Regex(@"\s\s+");
                            lineString = trimmerLineString.Replace(lineString, " ");

                            if ((lineString[0] >= 'A' && lineString[0] <= 'Z') || (lineString[0] >= 'a' && lineString[0] <= 'z')
                                || (lineString[0] >= '0' && lineString[0] <= '9')
                                || (lineString[0] > 127))
                            {
                                ktKiTuDau = false;
                            }
                            else
                            {
                                ktKiTuDau = true;
                            }

                            if (ktKiTuDau == true)
                            {
                                if (lineString[1] != ' ')
                                {
                                    x.Nghia.Add(lineString.Insert(1, " "));
                                }
                                else
                                {
                                    x.Nghia.Add(lineString);
                                }
                            }
                            else
                            {
                                x.Nghia.Add(lineString.Insert(0, "- "));
                            }
                        }

                        mainForm.hashTB.Linked_List[k].insertLast(x);
                        MessageBox.Show("Thêm thành công !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_tuTA.Text = "";
                        rich_nghia.Text = "";
                        textBox_tuTA.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Từ đã tồn tại trong từ điển !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_tuTA.Text = "";
                        textBox_tuTA.Focus();
                    }

                }
                catch (Exception) // Lỗi dòng không có dữ liệu ở phần ghi nghĩa của từ
                {
                    MessageBox.Show("Vui lòng xóa tất cả dòng trống !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
    }
}
