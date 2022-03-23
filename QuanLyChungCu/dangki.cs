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
    public partial class dangki : KryptonForm
    {
        public dangki()
        {
            InitializeComponent();
        }

        private void dangki_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "insert into nguoidung(tennd,taikhoan,matkhau) values('" + txttnd.Text + "','" + txttk.Text + "','" + txtmk.Text + "')";
            Connection.inupde(sql);
            MessageBox.Show("Đăng kí thành công", "Thông báo");
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
