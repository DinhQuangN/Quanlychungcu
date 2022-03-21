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
    public partial class Timkiemnhanvien : KryptonForm
    {
        public Timkiemnhanvien()
        {
            InitializeComponent();
        }

        private void Timkiemnhanvien_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (rdma.Checked == true)
            {
                string sql = "select * from nhanvien where manv like '%" + txttimkiem.Text + "%'";
                DataTable mytable = Connection.select(sql);
                dgvnv.DataSource = mytable;
            }
            else if (rdten.Checked == true)
            {
                string sql = "select * from nhanvien where tennv like '%" + txttimkiem.Text + "%'";
                DataTable mytable = Connection.select(sql);
                dgvnv.DataSource = mytable;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
