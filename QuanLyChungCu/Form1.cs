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
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : KryptonForm, new()
        {
            KryptonForm formulario;
            formulario = panel1.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel1.Controls.Add(formulario);
                panel1.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Dich_vu>();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<khachhang>();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Nhanvien>();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Canho>();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<hopdong>();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Loaidichvu>();
        }
        private void AbrirFormularioTK<MiForm>() where MiForm : KryptonForm, new()
        {
            KryptonForm formulario;
            formulario = panel11.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel11.Controls.Add(formulario);
                panel11.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            AbrirFormularioTK<Thongkeluongnhanvie>();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            AbrirFormularioTK<thongkekhachhangdamuacanho>();
        }

        private void AbrirFormularioTC<MiForm>() where MiForm : KryptonForm, new()
        {
            KryptonForm formulario;
            formulario = panel14.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel14.Controls.Add(formulario);
                panel14.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            AbrirFormularioTC<Tracuunhanvien>();
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            AbrirFormularioTC<tracuukhachhang>();
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Thanhtoan>();
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Thanhtoancanho>();
        }
    }
}
