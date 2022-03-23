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
    public partial class dangnhap : KryptonForm
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "select * from nguoidung where taikhoan ='" + txtuser.Text + "' and matkhau = '" + txtpass.Text + "' ";
            DataTable mytable = Connection.select(sql);
            if(mytable.Rows.Count > 0)
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai", "Thông báo");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dangki dk = new dangki();
            dk.Show();
        }
    }
}
