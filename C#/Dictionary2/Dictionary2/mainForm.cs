using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary2
{
    public partial class mainForm : Form
    {
        public static HashTable hashTB;
        public mainForm()
        {
            InitializeComponent();
            hashTB = new HashTable();
            hashTB.docFileBinary();

            richTextBox_Main.SelectionIndent += 22;
            richTextBox_Main.SelectionRightIndent += 22;
            
            // Focus vào ô search sẵn sàn search
            this.ActiveControl = textBox_search;
        }

        // Timer hiển thị ngày giờ
        private void timer_Main_Tick(object sender, EventArgs e)
        {
            lb_date.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            lb_gio.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        #region even_click
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string s = (string)textBox_search.Text;
                s = s.Trim(); // Cắt khoảng trắng đầu và cuối chuỗi
                Regex trimmer = new Regex(@"\s\s+");
                s = trimmer.Replace(s, " "); // Cắt tất cả khoảng trắng dư trong chuỗi

                if (s == "")
                {
                    MessageBox.Show("Bạn chưa nhập từ cần tìm !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_search.Focus();
                }
                else
                {
                    int temp = cons.hash(s[0]);
                    richTextBox_Main.Text = "";
                    List<string> tu = new List<string>();
                    List<string> tuLoai = new List<string>();

                    Boolean kt = false;

                    for (Node i = hashTB.Linked_List[temp].First; i != null; i = i.Link)
                    {
                        String k = cons.xuLyTen(i.Data.TuTA);

                        if (s.ToUpper() == k.ToUpper())
                        {
                            string t = $"\n📗 {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(i.Data.TuTA.ToLower())}"; // Viết hoa kí tự đầu
                            richTextBox_Main.Text += t;
                            tu.Add(i.Data.TuTA);

                            for (int j = 0; j < i.Data.Nghia.Count(); j++)
                            {
                                string nghia = i.Data.Nghia[j];

                                if (nghia[0] == '*')
                                {
                                    nghia = nghia.Substring(2);
                                    richTextBox_Main.Text += $"\n🔸 {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nghia.ToLower())}";
                                    tuLoai.Add(nghia);
                                }
                                else
                                {
                                    richTextBox_Main.Text += $"\n{nghia}";
                                }
                            }
                            richTextBox_Main.Text = $"{richTextBox_Main.Text}\n";
                            kt = true;
                        }
                    }

                    if (kt == false)
                    {
                        MessageBox.Show("Không tìm thấy !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_search.Focus();
                    }
                    else
                    {

                        foreach (string item in tu)
                        {
                            string richString = richTextBox_Main.Text.ToString();

                            string selectTu = $"📗 {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.ToLower())}";
                            List<int> dsTu = cons.AllIndexesOf(richString, selectTu);
                            foreach (int index in dsTu)
                            {
                                richTextBox_Main.Select(index, selectTu.Length);
                                richTextBox_Main.SelectionColor = Color.Green;
                                richTextBox_Main.SelectionFont = new Font("Cambria", 18, FontStyle.Bold);
                            }

                            foreach (string i in tuLoai)
                            {
                                string selectTuLoai = $"🔸 {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(i.ToLower())}";
                                List<int> dsTuLoai = cons.AllIndexesOf(richString, selectTuLoai);
                                foreach (int index in dsTuLoai)
                                {
                                    richTextBox_Main.Select(index, selectTuLoai.Length);
                                    richTextBox_Main.SelectionColor = Color.DarkOrchid;
                                    richTextBox_Main.SelectionFont = new Font("Cambria", 15, FontStyle.Bold);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox_search.Text = "";
            textBox_search.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            richTextBox_Main.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận lưu thay đổi", "Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                hashTB.ghiFileBinary();
                MessageBox.Show("Đã lưu thay đổi của bạn !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xác nhận trước khi đóng form
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region hotkeys
        private void traTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            textBox_search.Focus();
        }

        private void xóaHiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            richTextBox_Main.Text = "";
        }

        private void thêmTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
        }

        private void xóaTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận lưu thay đổi", "Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                hashTB.ghiFileBinary();
                MessageBox.Show("Đã lưu thay đổi của bạn !", "Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                this.Dispose();
            }
        }
        #endregion

        #region methods
        // Select một chuỗi target xuất hiện đầu tiên từ trên xuống trong RichTextBox
        private void SelectRichText(RichTextBox rch, string target)
        {
            string text = rch.Text.ToString();
            int pos = text.IndexOf(target);

            if (pos < 0)
            {
                // Not found. Select nothing.
                rch.Select(0, 0);
            }
            else
            {
                // Found the text. Select it.
                rch.Select(pos, target.Length);
            }
        }

        // Select một chuỗi target xuất hiện đầu tiên từ dưới lên trong RichTextBox
        private void SelectRichTextLast(RichTextBox rch, string target)
        {
            string text = rch.Text.ToString();
            int pos = text.LastIndexOf(target);

            if (pos < 0)
            {
                // Not found. Select nothing.
                rch.Select(0, 0);
            }
            else
            {
                // Found the text. Select it.
                rch.Select(pos, target.Length);
            }
        }

        // Tô màu cho chuỗi target trong RichTextBox
        private void HighlightRichText(RichTextBox rch, string target, Color bgcolor, Color fgcolor)
        {
            if ((target == null) || (target.Length == 0)) return;
            int pos = rch.Text.IndexOf(target);
            while (pos >= 0)
            {
                rch.Select(pos, target.Length);
                rch.SelectionBackColor = bgcolor;
                rch.SelectionColor = fgcolor;
                pos = rch.Text.IndexOf(target, pos + target.Length);
            }
        }

        #endregion
    }
}
