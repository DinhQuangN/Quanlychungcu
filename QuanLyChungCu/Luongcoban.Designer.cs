namespace QuanLyChungCu
{
    partial class Luongcoban
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmal = new System.Windows.Forms.TextBox();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbmanv = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvluong = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.maluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmanv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 531);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kryptonButton3);
            this.groupBox1.Controls.Add(this.kryptonButton2);
            this.groupBox1.Controls.Add(this.kryptonButton1);
            this.groupBox1.Controls.Add(this.cbbmanv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlcb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txthsl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lương";
            // 
            // txtmal
            // 
            this.txtmal.Enabled = false;
            this.txtmal.Location = new System.Drawing.Point(17, 93);
            this.txtmal.Multiline = true;
            this.txtmal.Name = "txtmal";
            this.txtmal.Size = new System.Drawing.Size(247, 30);
            this.txtmal.TabIndex = 1;
            // 
            // txthsl
            // 
            this.txthsl.Location = new System.Drawing.Point(17, 184);
            this.txthsl.Multiline = true;
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(247, 30);
            this.txthsl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số lương";
            // 
            // txtlcb
            // 
            this.txtlcb.Location = new System.Drawing.Point(17, 276);
            this.txtlcb.Multiline = true;
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(247, 30);
            this.txtlcb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lương cơ bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên nhân viên";
            // 
            // cbbmanv
            // 
            this.cbbmanv.DropDownWidth = 247;
            this.cbbmanv.Location = new System.Drawing.Point(17, 367);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(247, 25);
            this.cbbmanv.TabIndex = 7;
            this.cbbmanv.SelectedIndexChanged += new System.EventHandler(this.cbbmanv_SelectedIndexChanged);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(85, 480);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(105, 34);
            this.kryptonButton3.TabIndex = 38;
            this.kryptonButton3.Values.Text = "Xóa";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(159, 440);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(105, 34);
            this.kryptonButton2.TabIndex = 37;
            this.kryptonButton2.Values.Text = "Sửa";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(26, 440);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(105, 34);
            this.kryptonButton1.TabIndex = 36;
            this.kryptonButton1.Values.Text = "Lưu";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // dgvluong
            // 
            this.dgvluong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maluong,
            this.hesoluong,
            this.tennv});
            this.dgvluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvluong.Location = new System.Drawing.Point(294, 0);
            this.dgvluong.Name = "dgvluong";
            this.dgvluong.RowHeadersVisible = false;
            this.dgvluong.RowTemplate.Height = 24;
            this.dgvluong.Size = new System.Drawing.Size(631, 531);
            this.dgvluong.TabIndex = 1;
            this.dgvluong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvluong_CellClick);
            // 
            // maluong
            // 
            this.maluong.DataPropertyName = "maluong";
            this.maluong.HeaderText = "Mã lương";
            this.maluong.Name = "maluong";
            // 
            // hesoluong
            // 
            this.hesoluong.DataPropertyName = "hesoluong";
            this.hesoluong.HeaderText = "Hệ số lương";
            this.hesoluong.Name = "hesoluong";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            // 
            // Luongcoban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(925, 531);
            this.Controls.Add(this.dgvluong);
            this.Controls.Add(this.panel1);
            this.Name = "Luongcoban";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Luongcoban";
            this.Load += new System.EventHandler(this.Luongcoban_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmanv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbmanv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmal;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
    }
}