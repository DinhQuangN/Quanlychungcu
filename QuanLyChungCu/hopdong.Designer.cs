namespace QuanLyChungCu
{
    partial class hopdong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbtenkh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbtench = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenhd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvhd = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tenhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.dientich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbtenkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbtench)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
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
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Controls.Add(this.kryptonButton4);
            this.panel1.Controls.Add(this.cbbtenkh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbtench);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttenhd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 437);
            this.panel1.TabIndex = 0;
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(22, 308);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(251, 49);
            this.kryptonButton4.TabIndex = 32;
            this.kryptonButton4.Values.Text = "Lưu thông tin";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // cbbtenkh
            // 
            this.cbbtenkh.DropDownWidth = 247;
            this.cbbtenkh.Location = new System.Drawing.Point(17, 245);
            this.cbbtenkh.Name = "cbbtenkh";
            this.cbbtenkh.Size = new System.Drawing.Size(247, 25);
            this.cbbtenkh.TabIndex = 5;
            this.cbbtenkh.SelectedIndexChanged += new System.EventHandler(this.cbbtenkh_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng";
            // 
            // cbbtench
            // 
            this.cbbtench.DropDownWidth = 247;
            this.cbbtench.Location = new System.Drawing.Point(12, 162);
            this.cbbtench.Name = "cbbtench";
            this.cbbtench.Size = new System.Drawing.Size(247, 25);
            this.cbbtench.TabIndex = 3;
            this.cbbtench.Text = "kryptonComboBox1";
            this.cbbtench.SelectedIndexChanged += new System.EventHandler(this.cbbtench_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên căn hộ";
            // 
            // txttenhd
            // 
            this.txttenhd.Location = new System.Drawing.Point(17, 67);
            this.txttenhd.Multiline = true;
            this.txttenhd.Name = "txttenhd";
            this.txttenhd.Size = new System.Drawing.Size(247, 30);
            this.txttenhd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hợp đồng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvhd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 437);
            this.panel2.TabIndex = 1;
            // 
            // dgvhd
            // 
            this.dgvhd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhd,
            this.tencanho,
            this.anh,
            this.dientich,
            this.gia,
            this.tenkh,
            this.cmnd,
            this.sdt});
            this.dgvhd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhd.Location = new System.Drawing.Point(0, 0);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.RowHeadersVisible = false;
            this.dgvhd.RowTemplate.Height = 24;
            this.dgvhd.Size = new System.Drawing.Size(798, 437);
            this.dgvhd.TabIndex = 0;
            this.dgvhd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhd_CellClick);
            // 
            // tenhd
            // 
            this.tenhd.DataPropertyName = "tenhd";
            this.tenhd.HeaderText = "Hợp đồng";
            this.tenhd.Name = "tenhd";
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
            // 
            // dientich
            // 
            this.dientich.DataPropertyName = "dientich";
            this.dientich.HeaderText = "Diện tích";
            this.dientich.Name = "dientich";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.Name = "tenkh";
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SDT";
            this.sdt.Name = "sdt";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(22, 376);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(251, 49);
            this.kryptonButton1.TabIndex = 33;
            this.kryptonButton1.Values.Text = "Xuất file";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // hopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1092, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "hopdong";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "hopdong";
            this.Load += new System.EventHandler(this.hopdong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbtenkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbtench)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbtenkh;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbtench;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenhd;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencanho;
        private System.Windows.Forms.DataGridViewImageColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dientich;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}