using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Reflection;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace QuanLyChungCu
{
    public partial class hopdong : KryptonForm
    {
        public hopdong()
        {
            InitializeComponent();
        }

        private void hopdong_Load(object sender, EventArgs e)
        {
            loaddata();
            comboboxmacanho();
            comboboxtenkh();
        }
        public static string mach = "";
        public static string makh = "";
        public static string Tenhd = "";
        public static string Tencanho = "";
        public static string Dientich = "";
        public static string Gia = "";
        public static string Tenkh = "";
        public static string Cmnd = "";
        public static string Sdt = "";
        public void loaddata()
        {
            string sql = "SELECT dbo.hopdong.tenhd, dbo.canho.tencanho, dbo.canho.anh, dbo.canho.dientich, dbo.canho.gia, dbo.khachhang.tenkh, dbo.khachhang.cmnd, dbo.khachhang.sdt FROM dbo.hopdong INNER JOIN dbo.khachhang ON dbo.hopdong.makh = dbo.khachhang.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho";
            DataTable mytable = Connection.select(sql);
            dgvhd.DataSource = mytable;
        }
        public void comboboxmacanho()
        {
            string sql = "select * from canho";
            DataTable mytable = Connection.select(sql);
            cbbtench.DisplayMember = "tencanho";
            cbbtench.ValueMember = "macanho";
            cbbtench.DataSource = mytable;
        }

        private void cbbtench_SelectedIndexChanged(object sender, EventArgs e)
        {
            mach = cbbtench.SelectedValue.ToString();
        }

        public void comboboxtenkh()
        {
            string sql = "select * from khachhang";
            DataTable mytable = Connection.select(sql);
            cbbtenkh.DisplayMember = "tenkh";
            cbbtenkh.ValueMember = "makh";
            cbbtenkh.DataSource = mytable;
        }

        private void cbbtenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            makh = cbbtenkh.SelectedValue.ToString();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            string sql = "insert into hopdong(tenhd,macanho,makh) values('" + txttenhd.Text + "','" + mach + "','" + makh + "')";
            Connection.inupde(sql);
            loaddata();
        }

        private void dgvhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvhd.Rows[e.RowIndex];
            Tenhd = row.Cells["tenhd"].Value.ToString();
            Tencanho = row.Cells["tencanho"].Value.ToString();
            Dientich = row.Cells["dientich"].Value.ToString();
            Gia = row.Cells["gia"].Value.ToString();
            Tenkh = row.Cells["tenkh"].Value.ToString();
            Cmnd = row.Cells["cmnd"].Value.ToString();
            Sdt = row.Cells["sdt"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Tenkh);

        }
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                this.FindAndReplace(wordApp, "<tenkh>", Tenkh);
                this.FindAndReplace(wordApp, "<sdt>", Sdt);
                this.FindAndReplace(wordApp, "<dt>", Dientich);
                this.FindAndReplace(wordApp, "<gia>", Gia);
                this.FindAndReplace(wordApp, "<tench>", Tencanho);
                this.FindAndReplace(wordApp, "<cmnd>", Cmnd);

                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            CreateWordDocument(@"E:\Microsoft Visual Studio\QuanLyChungCu\QuanLyChungCu\hopdong.docx", @"E:\Microsoft Visual Studio\QuanLyChungCu\QuanLyChungCu\banhopdong.docx");
        }
    }
}
