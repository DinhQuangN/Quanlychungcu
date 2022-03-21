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
    public partial class Luongcoban : KryptonForm
    {
        public Luongcoban()
        {
            InitializeComponent();
        }

        private void Luongcoban_Load(object sender, EventArgs e)
        {
            loaddata();
            comboboxmanv();
        }
        public static string Manv = "";
        public void loaddata()
        {
            string sql = "SELECT dbo.luong.maluong, dbo.luong.hesoluong, dbo.luong.luongcoban, dbo.nhanvien.tennv FROM dbo.luong INNER JOIN dbo.nhanvien ON dbo.luong.manv = dbo.nhanvien.manv";
            DataTable mytable = Connection.select(sql);
            dgvluong.DataSource = mytable;
        }
        public void reset()
        {
            txtmal.Text = "";
            txthsl.Text = "";
            txtlcb.Text = "";
        }
        public void comboboxmanv()
        {
            string sql = "select * from nhanvien";
            DataTable mytable = Connection.select(sql);
            cbbmanv.DisplayMember = "tennv";
            cbbmanv.ValueMember = "manv";
            cbbmanv.DataSource = mytable;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "insert into luong(hesoluong,luongcoban,manv) values('" + txthsl.Text + "','" + txtlcb.Text + "','" + Manv + "')";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manv = cbbmanv.SelectedValue.ToString();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string sql = "update luong set hesoluong='" + txthsl.Text + "',luongcoban='" + txtlcb.Text + "',manv='" + Manv + "' where maluong='" + txtmal.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            string sql = "delete from luong where maluong='" + txtmal.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();

        }

        private void dgvluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvluong.Rows[e.RowIndex];
            txtmal.Text = row.Cells["maluong"].Value.ToString();
            txthsl.Text = row.Cells["hesoluong"].Value.ToString();
            txtlcb.Text = row.Cells["luongcoban"].Value.ToString();
        }
    }
}
