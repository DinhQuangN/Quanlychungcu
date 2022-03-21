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
    public partial class Timkiemcanho : KryptonForm
    {
        public Timkiemcanho()
        {
            InitializeComponent();
        }

        private void Timkiemcanho_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (rdma.Checked == true)
            {
                string sql = "select * from canho where macanho like '%" + txtsearch.Text + "%'";
                DataTable mytable = Connection.select(sql);
                dgvch.DataSource = mytable;
            }
            else if (rdten.Checked == true)
            {
                string sql = "select * from canho where tencanho like '%" + txtsearch.Text + "%'";
                DataTable mytable = Connection.select(sql);
                dgvch.DataSource = mytable;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
