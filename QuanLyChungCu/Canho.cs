using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyChungCu
{
    public partial class Canho : KryptonForm
    {
        public Canho()
        {
            InitializeComponent();
        }

        private void Canho_Load(object sender, EventArgs e)
        {
            loaddata();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DINHQUANG\SQLEXPRESS;Initial Catalog=QLCC;User ID=sa; Password=123456");
        SqlCommand cmd;
        string ImageLocation = "";
        public void loaddata()
        {
            string sql = "SELECT dbo.canho.macanho, dbo.canho.tencanho, dbo.canho.anh, dbo.canho.dientich, dbo.canho.gia, dbo.canho.tinhtrang FROM dbo.canho";
            DataTable mytable = Connection.select(sql);
            dgvch.DataSource = mytable;
        }
        public void reset()
        {
            txttench.Text = "";
            txtgia.Text = "";
            txtmach.Text = "";
            txttinhtrang.Text = "";
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ImageLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = ImageLocation;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            conn.Open();
            string sql = "insert into canho(tencanho,anh,dientich,gia,tinhtrang) values('" + txttench.Text + "',@images,'" + txtdt.Text + "','" + txtgia.Text + "','" + txttinhtrang.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            loaddata();
            reset();
        }

        private void dgvch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvch.Rows[e.RowIndex];
            txtmach.Text = row.Cells["macanho"].Value.ToString();
            txttench.Text = row.Cells["tencanho"].Value.ToString();
            if (row.Cells["anh"] != null)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(row.Cells["anh"].Value);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }
            else
            {
                pictureBox1.Image = null;
            }
            txtdt.Text = row.Cells["dientich"].Value.ToString();
            txtgia.Text = row.Cells["gia"].Value.ToString();
            txttinhtrang.Text = row.Cells["tinhtrang"].Value.ToString();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            conn.Open();
            string sql = "update canho set tencanho='" + txttench.Text + "',anh=@images,dientich='" + txtdt.Text + "',gia='" + txtgia.Text + "',tinhtrang='" + txttinhtrang.Text + "' where macanho='" + txtmach.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int n = cmd.ExecuteNonQuery();
            loaddata();
            reset();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            string sql = "delete from canho where macanho='" + txtmach.Text + "'";
            Connection.inupde(sql);
            loaddata();
            reset();
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
            AbrirFormulario<Timkiemcanho>();
            txttench.Enabled = false;
            txtdt.Enabled = false;
            txtgia.Enabled = false;
            txttinhtrang.Enabled = false;
            kryptonButton1.Enabled = false;
            kryptonButton2.Enabled = false;
            kryptonButton3.Enabled = false;
            kryptonButton6.Enabled = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            txttench.Enabled = true;
            txtdt.Enabled = true;
            txtgia.Enabled = true;
            txttinhtrang.Enabled = true;
            kryptonButton1.Enabled = true;
            kryptonButton2.Enabled = true;
            kryptonButton3.Enabled = true;
            kryptonButton6.Enabled = true;
        }
    }
}
