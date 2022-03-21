using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyChungCu
{
    public partial class Thongkeluongnhanvie : KryptonForm
    {
        public Thongkeluongnhanvie()
        {
            InitializeComponent();
            cbbluachon.Items.Add("Sắp xếp từ A - Z");
            cbbluachon.Items.Add("Sắp xếp từ Z- A");
            cbbluachon.Items.Add("Sắp xếp desc");
            cbbluachon.Items.Add("Sắp xếp asc");
            cbbluachon.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Thongkeluongnhanvie_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata2();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DINHQUANG\SQLEXPRESS;Initial Catalog=QLCC;User ID=sa; Password=123456");

        public void loaddata()
        {
            string sql = "SELECT dbo.nhanvien.tennv, dbo.nhanvien.sdt, dbo.nhanvien.cmnd, dbo.nhanvien.diachi, thanhtien = luong.hesoluong*luong.luongcoban FROM dbo.nhanvien INNER JOIN dbo.luong ON dbo.nhanvien.manv = dbo.luong.manv";
            DataTable mytable = Connection.select(sql);
            dgvthongke.DataSource = mytable;
        }
        public void loaddata2()
        {
            string sql = "SELECT sum(luong.hesoluong*luong.luongcoban) as tong FROM dbo.nhanvien INNER JOIN dbo.luong ON dbo.nhanvien.manv = dbo.luong.manv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txttong.Text = dr["tong"].ToString();
            }
            dr.Close();
            
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvthongke.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvthongke.Columns[i].HeaderText;

            }
            for (int i = 0; i < dgvthongke.Rows.Count; i++)
            {
                for (int j = 0; j < dgvthongke.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvthongke.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void cbbluachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbluachon.Text.ToString() == "Sắp xếp từ A - Z")
            {
                string sql = "SELECT dbo.nhanvien.tennv, dbo.nhanvien.sdt, dbo.nhanvien.cmnd, dbo.nhanvien.diachi, thanhtien = luong.hesoluong*luong.luongcoban FROM dbo.nhanvien INNER JOIN dbo.luong ON dbo.nhanvien.manv = dbo.luong.manv order by tennv asc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
            if (cbbluachon.Text.ToString() == "Sắp xếp từ Z - A")
            {
                string sql = "SELECT dbo.nhanvien.tennv, dbo.nhanvien.sdt, dbo.nhanvien.cmnd, dbo.nhanvien.diachi, thanhtien = luong.hesoluong*luong.luongcoban FROM dbo.nhanvien INNER JOIN dbo.luong ON dbo.nhanvien.manv = dbo.luong.manv order by tennv desc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
            if (cbbluachon.Text.ToString() == "Sắp xếp desc")
            {
                string sql = "SELECT dbo.nhanvien.tennv, dbo.nhanvien.sdt, dbo.nhanvien.cmnd, dbo.nhanvien.diachi, thanhtien = luong.hesoluong*luong.luongcoban FROM dbo.nhanvien INNER JOIN dbo.luong ON dbo.nhanvien.manv = dbo.luong.manv order by thanhtien desc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
            if (cbbluachon.Text.ToString() == "Sắp xếp asc")
            {
                string sql = "SELECT dbo.nhanvien.tennv, dbo.nhanvien.sdt, dbo.nhanvien.cmnd, dbo.nhanvien.diachi, thanhtien = luong.hesoluong*luong.luongcoban FROM dbo.nhanvien INNER JOIN dbo.luong ON dbo.nhanvien.manv = dbo.luong.manv order by thanhtien asc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
        }
    }
}
