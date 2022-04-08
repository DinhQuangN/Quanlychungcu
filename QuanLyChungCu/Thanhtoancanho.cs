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

namespace QuanLyChungCu
{
    public partial class Thanhtoancanho : KryptonForm
    {
        public Thanhtoancanho()
        {
            InitializeComponent();
        }

        private void Thanhtoancanho_Load(object sender, EventArgs e)
        {
            loaddata();
            commboboxkh();
        }
        public static string Makh = "";
        public void loaddata()
        {
            string sql = "SELECT dbo.khachhang.tenkh, dbo.thanhtoan.ngaythanhtoan, dbo.thanhtoan.tengiaodich, dbo.canho.tencanho, dbo.canho.anh, dbo.canho.dientich,thanhtien = dbo.canho.gia FROM dbo.khachhang INNER JOIN dbo.thanhtoan ON dbo.khachhang.makh = dbo.thanhtoan.makh INNER JOIN dbo.hopdong ON dbo.khachhang.makh = dbo.hopdong.makh INNER JOIN dbo.canho ON dbo.hopdong.macanho = dbo.canho.macanho";
            DataTable mytable = Connection.select(sql);
            dgvthanhtoan.DataSource = mytable;
        }
        public void commboboxkh()
        {
            string sql = "select * from khachhang";
            DataTable mytable = Connection.select(sql);
            cbbkh.DisplayMember = "tenkh";
            cbbkh.ValueMember = "makh";
            cbbkh.DataSource = mytable;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            string sql = "insert into thanhtoan(tengiaodich,ngaythanhtoan,makh) values('" + txtten.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") + "','" + Makh + "')";
            Connection.inupde(sql);
            loaddata();
        }

        private void cbbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Makh = cbbkh.SelectedValue.ToString();
        }
    }
}
