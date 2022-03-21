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
    public partial class Thanhtoan : KryptonForm
    {
        public Thanhtoan()
        {
            InitializeComponent();
        }

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            loaddata();
            comboboxmanv();
        }
        public static string Manv = "";
        public void loaddata()
        {
            string sql = "select tengiaodich,ngaythanhtoan,nhanvien.tennv, thanhtien=hesoluong*luongcoban from nhanvien,luong,thanhtoan where nhanvien.manv=luong.manv and nhanvien.manv=thanhtoan.manv";
            DataTable mytable = Connection.select(sql);
            dgvthanhtoan.DataSource = mytable;
        }
        public void comboboxmanv() {
            string sql = "select * from nhanvien";
            DataTable mytable = Connection.select(sql);
            cbbnhanvien.DisplayMember = "tennv";
            cbbnhanvien.ValueMember = "manv";
            cbbnhanvien.DataSource = mytable;
        }
        
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            string sql = "insert into thanhtoan(tengiaodich,ngaythanhtoan,manv) values('" + txtten.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") + "','" + Manv + "')";
            Connection.inupde(sql);
            loaddata();
        }

        private void cbbnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manv = cbbnhanvien.SelectedValue.ToString();
        }
    }
}
