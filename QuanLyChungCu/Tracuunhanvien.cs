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
    public partial class Tracuunhanvien : KryptonForm
    {
        public Tracuunhanvien()
        {
            InitializeComponent();
        }

        private void Tracuunhanvien_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "select * from nhanvien where manv like '%" + txttracuu.Text + "%' or tennv like '%" + txttracuu.Text + "%'";
            DataTable mytable = Connection.select(sql);
            dgvnv.DataSource = mytable;
        }
    }
}
