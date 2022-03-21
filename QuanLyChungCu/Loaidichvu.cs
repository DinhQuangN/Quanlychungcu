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
    public partial class Loaidichvu : KryptonForm
    {
        public Loaidichvu()
        {
            InitializeComponent();
        }

        private void Loaidichvu_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            string sql = "select * from loaidichvu";
            DataTable mytable = Connection.select(sql);
            dgvloaidv.DataSource = mytable;
        }
        public void reset()
        {
            txtmadv.Text = " ";
            txttendv.Text = " ";
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "insert into loaidichvu(tenloaidv) values('" + txttendv.Text + "')";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string sql = "update loaidichvu set tenloaidv = '" + txttendv.Text + "' where maloaidv = '" + txtmadv.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            string sql = "delete from loaidichvu where maloaidv = '" + txtmadv.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void dgvloaidv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvloaidv.Rows[e.RowIndex];
            txtmadv.Text = row.Cells["maloaidv"].Value.ToString();
            txttendv.Text = row.Cells["tenloaidv"].Value.ToString();
        }
    }
}
