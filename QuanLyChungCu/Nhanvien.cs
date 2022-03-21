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
    public partial class Nhanvien : KryptonForm
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            string sql = "select * from nhanvien";
            DataTable mytable = Connection.select(sql);
            dgvnv.DataSource = mytable;
        }
        public void reset()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
            txtcmnd.Text = "";
            txtdiachi.Text = "";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "insert into nhanvien(tennv,sdt,cmnd,diachi) values('" + txttennv.Text + "','" + txtsdt.Text + "','" + txtcmnd.Text + "','" + txtdiachi.Text + "') ";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string sql = "update nhanvien set tennv='" + txttennv.Text + "',sdt='" + txtsdt.Text + "',cmnd='" + txtcmnd.Text + "',diachi='" + txtdiachi.Text + "' where manv='" + txtmanv.Text + "'  ";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            string sql = "delete from nhanvien where manv='" + txtmanv.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvnv.Rows[e.RowIndex];
            txtmanv.Text = row.Cells["manv"].Value.ToString();
            txttennv.Text = row.Cells["tennv"].Value.ToString();
            txtsdt.Text = row.Cells["sdt"].Value.ToString();
            txtcmnd.Text = row.Cells["cmnd"].Value.ToString();
            txtdiachi.Text = row.Cells["diachi"].Value.ToString();
        }
        private void AbrirFormulario<MiForm>() where MiForm : KryptonForm, new()
        {
            KryptonForm formulario;
            formulario = panel3.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel3.Controls.Add(formulario);
                panel3.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Timkiemnhanvien>();
            txtcmnd.Enabled = false;
            txtdiachi.Enabled = false;
            txtmanv.Enabled = false;
            txtsdt.Enabled = false;
            txttennv.Enabled = false;
            kryptonButton1.Enabled = false;
            kryptonButton2.Enabled = false;
            kryptonButton3.Enabled = false;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            txtcmnd.Enabled = true;
            txtdiachi.Enabled = true;
            txtmanv.Enabled = true;
            txtsdt.Enabled = true;
            txttennv.Enabled = true;
            kryptonButton1.Enabled = true;
            kryptonButton2.Enabled = true;
            kryptonButton3.Enabled = true;
        }
    }
}
