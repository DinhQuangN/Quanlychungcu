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
    public partial class timkiemkhachhang : KryptonForm
    {
        public timkiemkhachhang()
        {
            InitializeComponent();
        }

        private void timkiemkhachhang_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (rdma.Checked == true)
            {
            string sql = "select * from  khachhang where makh like '%" + txtsearch.Text + "%'";
            DataTable mytable = Connection.select(sql);
            dgvkh.DataSource = mytable;

            }
            else if (rdten.Checked == true)
            {
                string sql = "select * from  khachhang where tenkh like '%" + txtsearch.Text + "%'";
                DataTable mytable = Connection.select(sql);
                dgvkh.DataSource = mytable;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
