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
    public partial class khachhang : KryptonForm
    {
        public khachhang()
        {
            InitializeComponent();
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            string sql = " select * from khachhang";
            DataTable mytable = Connection.select(sql);
            dgvkh.DataSource = mytable;
        }
        public void reset()
        {
            txttenkh.Text = "";
            txtsdt.Text = "";
            txtcmnd.Text = "";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "insert into khachhang(makh,tenkh,sdt,cmnd) values('" + txtmakh.Text + "','" + txttenkh.Text + "','" + txtsdt.Text + "','" + txtcmnd.Text + "')";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string sql = "update khachhang set tenkh='" + txttenkh.Text + "', sdt='" + txtsdt.Text + "',cmnd='" + txtcmnd.Text + "' where makh='" + txtmakh.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            string sql = "delete from khachhang where makh='" + txtmakh.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvkh.Rows[e.RowIndex];
            txtmakh.Text = row.Cells["makh"].Value.ToString();
            txttenkh.Text = row.Cells["tenkh"].Value.ToString();
            txtsdt.Text = row.Cells["sdt"].Value.ToString();
            txtcmnd.Text = row.Cells["cmnd"].Value.ToString();
        }
        private void AbrirFormulario<MiForm>() where MiForm : KryptonForm, new()
        {
            KryptonForm formulario;
            formulario = panel2.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel2.Controls.Add(formulario);
                panel2.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<timkiemkhachhang>();
            txttenkh.Enabled = false;
            txtsdt.Enabled = false;
            txtcmnd.Enabled = false;
            kryptonButton1.Enabled = false;
            kryptonButton2.Enabled = false;
            kryptonButton3.Enabled = false;

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            txttenkh.Enabled = true;
            txtsdt.Enabled = true;
            txtcmnd.Enabled = true;
            kryptonButton1.Enabled = true;
            kryptonButton2.Enabled = true;
            kryptonButton3.Enabled = true;
        }
    }
}
