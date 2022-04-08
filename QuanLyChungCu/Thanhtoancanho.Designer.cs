namespace QuanLyChungCu
{
    partial class Thanhtoancanho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.dgvthanhtoan = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiaodich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.dientich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbkh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthanhtoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbkh)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // dgvthanhtoan
            // 
            this.dgvthanhtoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthanhtoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenkh,
            this.ngaythanhtoan,
            this.tengiaodich,
            this.tencanho,
            this.anh,
            this.dientich,
            this.thanhtien});
            this.dgvthanhtoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvthanhtoan.Location = new System.Drawing.Point(0, 0);
            this.dgvthanhtoan.Name = "dgvthanhtoan";
            this.dgvthanhtoan.RowHeadersVisible = false;
            this.dgvthanhtoan.RowTemplate.Height = 24;
            this.dgvthanhtoan.Size = new System.Drawing.Size(506, 450);
            this.dgvthanhtoan.TabIndex = 0;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.Name = "tenkh";
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.DataPropertyName = "ngaythanhtoan";
            this.ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            // 
            // tengiaodich
            // 
            this.tengiaodich.DataPropertyName = "tengiaodich";
            this.tengiaodich.HeaderText = "Tên giao dịch";
            this.tengiaodich.Name = "tengiaodich";
            // 
            // tencanho
            // 
            this.tencanho.DataPropertyName = "tencanho";
            this.tencanho.HeaderText = "Tên căn hộ";
            this.tencanho.Name = "tencanho";
            // 
            // anh
            // 
            this.anh.DataPropertyName = "anh";
            this.anh.HeaderText = "Ảnh";
            this.anh.Name = "anh";
            this.anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dientich
            // 
            this.dientich.DataPropertyName = "dientich";
            this.dientich.HeaderText = "Diện tích";
            this.dientich.Name = "dientich";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvthanhtoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 450);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 450);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kryptonButton4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbkh);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(21, 241);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(260, 45);
            this.kryptonButton4.TabIndex = 37;
            this.kryptonButton4.Values.Text = "Thanh toán";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng";
            // 
            // cbbkh
            // 
            this.cbbkh.DropDownWidth = 243;
            this.cbbkh.Location = new System.Drawing.Point(21, 178);
            this.cbbkh.Name = "cbbkh";
            this.cbbkh.Size = new System.Drawing.Size(243, 25);
            this.cbbkh.TabIndex = 2;
            this.cbbkh.Text = "kryptonComboBox1";
            this.cbbkh.SelectedIndexChanged += new System.EventHandler(this.cbbkh_SelectedIndexChanged);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(17, 87);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(247, 30);
            this.txtten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên giao dich";
            // 
            // Thanhtoancanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Thanhtoancanho";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Thanhtoancanho";
            this.Load += new System.EventHandler(this.Thanhtoancanho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthanhtoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvthanhtoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbkh;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiaodich;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencanho;
        private System.Windows.Forms.DataGridViewImageColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dientich;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}