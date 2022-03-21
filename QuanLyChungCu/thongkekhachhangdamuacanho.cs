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
    public partial class thongkekhachhangdamuacanho : KryptonForm
    {
        public thongkekhachhangdamuacanho()
        {
            InitializeComponent();
            cbbluachon.Items.Add("Sắp xếp từ A - Z");
            cbbluachon.Items.Add("Sắp xếp từ Z- A");
            cbbluachon.Items.Add("Sắp xếp desc");
            cbbluachon.Items.Add("Sắp xếp asc");
            cbbluachon.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void thongkekhachhangdamuacanho_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata2();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DINHQUANG\SQLEXPRESS;Initial Catalog=QLCC;User ID=sa; Password=123456");

        public void loaddata()
        {
            string sql = "SELECT dbo.khachhang.tenkh, dbo.khachhang.sdt, dbo.khachhang.cmnd, dbo.canho.tencanho, dbo.canho.dientich, dbo.canho.gia, dbo.thanhtoan.ngaythanhtoan, dbo.hopdong.tenhd FROM dbo.thanhtoan INNER JOIN dbo.khachhang ON dbo.thanhtoan.makh = dbo.khachhang.makh INNER JOIN dbo.hopdong ON dbo.khachhang.makh = dbo.hopdong.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho";
            DataTable mytable = Connection.select(sql);
            dgvthongke.DataSource = mytable;
        }

        public void loaddata2()
        {
            string sql = "SELECT sum(dbo.canho.gia) as tong FROM dbo.thanhtoan INNER JOIN dbo.khachhang ON dbo.thanhtoan.makh = dbo.khachhang.makh INNER JOIN dbo.hopdong ON dbo.khachhang.makh = dbo.hopdong.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho";
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
                string sql = "SELECT dbo.khachhang.tenkh, dbo.khachhang.sdt, dbo.khachhang.cmnd, dbo.canho.tencanho, dbo.canho.dientich, dbo.canho.gia, dbo.thanhtoan.ngaythanhtoan, dbo.hopdong.tenhd FROM dbo.thanhtoan INNER JOIN dbo.khachhang ON dbo.thanhtoan.makh = dbo.khachhang.makh INNER JOIN dbo.hopdong ON dbo.khachhang.makh = dbo.hopdong.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho order by tenkh asc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
            if (cbbluachon.Text.ToString() == "Sắp xếp từ Z - A")
            {
                string sql = "SELECT dbo.khachhang.tenkh, dbo.khachhang.sdt, dbo.khachhang.cmnd, dbo.canho.tencanho, dbo.canho.dientich, dbo.canho.gia, dbo.thanhtoan.ngaythanhtoan, dbo.hopdong.tenhd FROM dbo.thanhtoan INNER JOIN dbo.khachhang ON dbo.thanhtoan.makh = dbo.khachhang.makh INNER JOIN dbo.hopdong ON dbo.khachhang.makh = dbo.hopdong.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho order by tenkh desc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
            if (cbbluachon.Text.ToString() == "Sắp xếp desc")
            {
                string sql = "SELECT dbo.khachhang.tenkh, dbo.khachhang.sdt, dbo.khachhang.cmnd, dbo.canho.tencanho, dbo.canho.dientich, dbo.canho.gia, dbo.thanhtoan.ngaythanhtoan, dbo.hopdong.tenhd FROM dbo.thanhtoan INNER JOIN dbo.khachhang ON dbo.thanhtoan.makh = dbo.khachhang.makh INNER JOIN dbo.hopdong ON dbo.khachhang.makh = dbo.hopdong.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho order by gia desc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
            if (cbbluachon.Text.ToString() == "Sắp xếp asc")
            {
                string sql = "SELECT dbo.khachhang.tenkh, dbo.khachhang.sdt, dbo.khachhang.cmnd, dbo.canho.tencanho, dbo.canho.dientich, dbo.canho.gia, dbo.thanhtoan.ngaythanhtoan, dbo.hopdong.tenhd FROM dbo.thanhtoan INNER JOIN dbo.khachhang ON dbo.thanhtoan.makh = dbo.khachhang.makh INNER JOIN dbo.hopdong ON dbo.khachhang.makh = dbo.hopdong.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho order by gia asc";
                DataTable mytable = Connection.select(sql);
                dgvthongke.DataSource = mytable;
            }
        }
    }
}
