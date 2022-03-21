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
    public partial class Dich_vu : KryptonForm
    {
        public Dich_vu()
        {
            InitializeComponent();
        }

        private void Dich_vu_Load(object sender, EventArgs e)
        {
            loaddata();
            comboboxloaidv();
        }
        public void loaddata()
        {
            string sql = "SELECT dbo.dichvu.madv, dbo.dichvu.tendv, dbo.loaidichvu.tenloaidv, dbo.dichvu.gia FROM dbo.dichvu INNER JOIN dbo.loaidichvu ON dbo.dichvu.maloaidv = dbo.loaidichvu.maloaidv";
            DataTable mytable = Connection.select(sql);
            dgvdv.DataSource = mytable;
        }
        public void reset()
        {
            txtmadv.Text = "";
            txttendv.Text = "";
            txtgiadv.Text = "";
        }
        public static string Maloaidv = "";
        public void comboboxloaidv()
        {
            string sql = "select * from loaidichvu";
            DataTable mytable = Connection.select(sql);
            cbbloaidv.DisplayMember = "tenloaidv";
            cbbloaidv.ValueMember = "maloaidv";
            cbbloaidv.DataSource = mytable;
        }

        private void cbbloaidv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maloaidv = cbbloaidv.SelectedValue.ToString();
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string sql = "insert into dichvu(tendv,maloaidv,gia) values('" + txttendv.Text + "','" + Maloaidv + "','" + txtgiadv.Text + "')";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string sql = "update dichvu set tendv='" + txttendv.Text + "',maloaidv='" + Maloaidv + "',gia='" + txtgiadv.Text + "' where madv='" + txtmadv.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            string sql = "delete from dichvu where madv='" + txtmadv.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
        }

        private void dgvdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvdv.Rows[e.RowIndex];
            txtmadv.Text = row.Cells["madv"].Value.ToString();
            txttendv.Text = row.Cells["tendv"].Value.ToString();
            txtgiadv.Text = row.Cells["gia"].Value.ToString();
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

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Timkiemdichvucs>();
            txttendv.Enabled = false;
            cbbloaidv.Enabled = false;
            txtgiadv.Enabled = false;
            kryptonButton1.Enabled = false;
            kryptonButton2.Enabled = false;
            kryptonButton3.Enabled = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            txttendv.Enabled = true;
            cbbloaidv.Enabled = true;
            txtgiadv.Enabled = true;
            kryptonButton1.Enabled = true;
            kryptonButton2.Enabled = true;
            kryptonButton3.Enabled = true;
        }
    }
}
