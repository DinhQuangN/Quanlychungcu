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
        public static string makh = "";
        public void loaddata()
        {
            string sql = "SELECT dbo.khachhang.tenkh, dbo.thanhtoan.tengiaodich, dbo.thanhtoan.ngaythanhtoan, dbo.canho.tencanho, dbo.canho.dientich, dbo.canho.anh,thanhtien=dbo.canho.gia FROM dbo.canho INNER JOIN dbo.khachhang ON dbo.canho.makh = dbo.khachhang.makh INNER JOIN dbo.thanhtoan ON dbo.khachhang.makh = dbo.thanhtoan.makh";
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
            string sql = "insert into thanhtoan(tengiaodich,ngaythanhtoan,makh) values('" + txtten.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") + "','" + makh + "')";
            Connection.inupde(sql);
            loaddata();
        }

        private void cbbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            makh = cbbkh.SelectedValue.ToString();
        }
    }
}
