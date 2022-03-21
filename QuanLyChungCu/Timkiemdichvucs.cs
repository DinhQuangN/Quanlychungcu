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
    public partial class Timkiemdichvucs : KryptonForm
    {
        public Timkiemdichvucs()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if( rdma.Checked == true)
            {
                string sql = "select * from dichvu where madv like '%" + txttimkiem.Text + "%'";
                DataTable mytable = Connection.select(sql);
                dgvdv.DataSource = mytable;
            }
            else if (rdten.Checked == true)
            {
                string sql = "select * from dichvu where tendv like '%" + txttimkiem.Text + "%'";
                DataTable mytable = Connection.select(sql);
                dgvdv.DataSource = mytable;
            }
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
