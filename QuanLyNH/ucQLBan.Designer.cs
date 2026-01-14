namespace QuanLyNH
{
    partial class ucQLBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxDanhSachBan = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbxChiTietBan = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvDanhSachBan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbxChuiThich = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaBan = new Guna.UI2.WinForms.Guna2Button();
            this.lblChiTietBan = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.dgvDanhSachMon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTongTienTamTinh = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.btnThemMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoChoNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.nudSoChoNgoi = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbxTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxDanhSachBan.SuspendLayout();
            this.gbxChiTietBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.gbxChuiThich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChoNgoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1021, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxDanhSachBan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbxChiTietBan);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 596);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbxDanhSachBan
            // 
            this.gbxDanhSachBan.BackColor = System.Drawing.Color.White;
            this.gbxDanhSachBan.Controls.Add(this.cbxTrangThai);
            this.gbxDanhSachBan.Controls.Add(this.nudSoChoNgoi);
            this.gbxDanhSachBan.Controls.Add(this.txtMaBan);
            this.gbxDanhSachBan.Controls.Add(this.label6);
            this.gbxDanhSachBan.Controls.Add(this.label5);
            this.gbxDanhSachBan.Controls.Add(this.label4);
            this.gbxDanhSachBan.Controls.Add(this.btnXoaBan);
            this.gbxDanhSachBan.Controls.Add(this.btnSuaBan);
            this.gbxDanhSachBan.Controls.Add(this.btnThemBan);
            this.gbxDanhSachBan.Controls.Add(this.gbxChuiThich);
            this.gbxDanhSachBan.Controls.Add(this.dgvDanhSachBan);
            this.gbxDanhSachBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDanhSachBan.ForeColor = System.Drawing.Color.Black;
            this.gbxDanhSachBan.Location = new System.Drawing.Point(4, 4);
            this.gbxDanhSachBan.Name = "gbxDanhSachBan";
            this.gbxDanhSachBan.Size = new System.Drawing.Size(333, 589);
            this.gbxDanhSachBan.TabIndex = 0;
            this.gbxDanhSachBan.Text = "Danh sách bàn";
            // 
            // gbxChiTietBan
            // 
            this.gbxChiTietBan.Controls.Add(this.btnThanhToan);
            this.gbxChiTietBan.Controls.Add(this.btnLamMoi);
            this.gbxChiTietBan.Controls.Add(this.btnXoaMon);
            this.gbxChiTietBan.Controls.Add(this.btnSuaMon);
            this.gbxChiTietBan.Controls.Add(this.btnThemMon);
            this.gbxChiTietBan.Controls.Add(this.lblTien);
            this.gbxChiTietBan.Controls.Add(this.lblTongTienTamTinh);
            this.gbxChiTietBan.Controls.Add(this.dgvDanhSachMon);
            this.gbxChiTietBan.Controls.Add(this.lblBan);
            this.gbxChiTietBan.Controls.Add(this.lblChiTietBan);
            this.gbxChiTietBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChiTietBan.ForeColor = System.Drawing.Color.Black;
            this.gbxChiTietBan.Location = new System.Drawing.Point(3, 4);
            this.gbxChiTietBan.Name = "gbxChiTietBan";
            this.gbxChiTietBan.Size = new System.Drawing.Size(671, 589);
            this.gbxChiTietBan.TabIndex = 0;
            this.gbxChiTietBan.Text = "Chi tiết bàn";
            // 
            // dgvDanhSachBan
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDanhSachBan.ColumnHeadersHeight = 40;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTrangThai,
            this.colSoChoNgoi});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachBan.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDanhSachBan.GridColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.Location = new System.Drawing.Point(4, 44);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.RowHeadersVisible = false;
            this.dgvDanhSachBan.RowHeadersWidth = 51;
            this.dgvDanhSachBan.RowTemplate.Height = 24;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(326, 256);
            this.dgvDanhSachBan.TabIndex = 0;
            this.dgvDanhSachBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhSachBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhSachBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachBan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhSachBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachBan.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDanhSachBan.ThemeStyle.ReadOnly = false;
            this.dgvDanhSachBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachBan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDanhSachBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhSachBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBan_CellClick);
            // 
            // gbxChuiThich
            // 
            this.gbxChuiThich.BorderColor = System.Drawing.Color.White;
            this.gbxChuiThich.Controls.Add(this.flowLayoutPanel1);
            this.gbxChuiThich.Controls.Add(this.panel1);
            this.gbxChuiThich.Controls.Add(this.label3);
            this.gbxChuiThich.Controls.Add(this.label2);
            this.gbxChuiThich.CustomBorderColor = System.Drawing.Color.White;
            this.gbxChuiThich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChuiThich.ForeColor = System.Drawing.Color.Black;
            this.gbxChuiThich.Location = new System.Drawing.Point(4, 306);
            this.gbxChuiThich.Name = "gbxChuiThich";
            this.gbxChuiThich.Size = new System.Drawing.Size(326, 115);
            this.gbxChuiThich.TabIndex = 1;
            this.gbxChuiThich.Text = "Chú thích:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xanh lá là bàn còn trống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đỏ là bàn không còn trống";
            // 
            // btnThemBan
            // 
            this.btnThemBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBan.ForeColor = System.Drawing.Color.Black;
            this.btnThemBan.Location = new System.Drawing.Point(4, 540);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(80, 45);
            this.btnThemBan.TabIndex = 2;
            this.btnThemBan.Text = "Thêm";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBan.ForeColor = System.Drawing.Color.Black;
            this.btnSuaBan.Location = new System.Drawing.Point(123, 540);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(80, 45);
            this.btnSuaBan.TabIndex = 3;
            this.btnSuaBan.Text = "Sửa";
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaBan.FillColor = System.Drawing.Color.Red;
            this.btnXoaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBan.ForeColor = System.Drawing.Color.Black;
            this.btnXoaBan.Location = new System.Drawing.Point(250, 541);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(80, 45);
            this.btnXoaBan.TabIndex = 4;
            this.btnXoaBan.Text = "Xoá";
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // lblChiTietBan
            // 
            this.lblChiTietBan.AutoSize = true;
            this.lblChiTietBan.BackColor = System.Drawing.Color.White;
            this.lblChiTietBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietBan.Location = new System.Drawing.Point(3, 44);
            this.lblChiTietBan.Name = "lblChiTietBan";
            this.lblChiTietBan.Size = new System.Drawing.Size(102, 19);
            this.lblChiTietBan.TabIndex = 0;
            this.lblChiTietBan.Text = "Chi tiết bàn:";
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.BackColor = System.Drawing.Color.White;
            this.lblBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.Location = new System.Drawing.Point(111, 44);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(13, 19);
            this.lblBan.TabIndex = 1;
            this.lblBan.Text = " ";
            // 
            // dgvDanhSachMon
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachMon.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDanhSachMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachMon.Location = new System.Drawing.Point(7, 85);
            this.dgvDanhSachMon.Name = "dgvDanhSachMon";
            this.dgvDanhSachMon.RowHeadersVisible = false;
            this.dgvDanhSachMon.RowHeadersWidth = 51;
            this.dgvDanhSachMon.RowTemplate.Height = 24;
            this.dgvDanhSachMon.Size = new System.Drawing.Size(659, 323);
            this.dgvDanhSachMon.TabIndex = 2;
            this.dgvDanhSachMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhSachMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhSachMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachMon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachMon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhSachMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMon.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDanhSachMon.ThemeStyle.ReadOnly = false;
            this.dgvDanhSachMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachMon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDanhSachMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblTongTienTamTinh
            // 
            this.lblTongTienTamTinh.AutoSize = true;
            this.lblTongTienTamTinh.BackColor = System.Drawing.Color.White;
            this.lblTongTienTamTinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTamTinh.Location = new System.Drawing.Point(7, 415);
            this.lblTongTienTamTinh.Name = "lblTongTienTamTinh";
            this.lblTongTienTamTinh.Size = new System.Drawing.Size(151, 19);
            this.lblTongTienTamTinh.TabIndex = 3;
            this.lblTongTienTamTinh.Text = "Tổng tiền tạm tính:";
            // 
            // lblTien
            // 
            this.lblTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(164, 415);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(158, 16);
            this.lblTien.TabIndex = 4;
            this.lblTien.Text = " ";
            // 
            // btnThemMon
            // 
            this.btnThemMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.Black;
            this.btnThemMon.Location = new System.Drawing.Point(20, 478);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(95, 45);
            this.btnThemMon.TabIndex = 5;
            this.btnThemMon.Text = "Thêm";
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.ForeColor = System.Drawing.Color.Black;
            this.btnSuaMon.Location = new System.Drawing.Point(190, 478);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(95, 45);
            this.btnSuaMon.TabIndex = 6;
            this.btnSuaMon.Text = "Sửa";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaMon.FillColor = System.Drawing.Color.Red;
            this.btnXoaMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.ForeColor = System.Drawing.Color.Black;
            this.btnXoaMon.Location = new System.Drawing.Point(378, 478);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(95, 45);
            this.btnXoaMon.TabIndex = 7;
            this.btnXoaMon.Text = "Xoá";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.Silver;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(554, 478);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 45);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.LimeGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(249, 541);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(180, 45);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh Toán";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(19, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 17);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(17, 17);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // colMaBan
            // 
            this.colMaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaBan.DataPropertyName = "MaBan";
            this.colMaBan.HeaderText = "Mã bàn";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colSoChoNgoi
            // 
            this.colSoChoNgoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSoChoNgoi.DataPropertyName = "SoChoNgoi";
            this.colSoChoNgoi.HeaderText = "Số chổ ngồi";
            this.colSoChoNgoi.MinimumWidth = 6;
            this.colSoChoNgoi.Name = "colSoChoNgoi";
            this.colSoChoNgoi.Width = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã bàn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số chổ ngồi:";
            // 
            // txtMaBan
            // 
            this.txtMaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBan.DefaultText = "";
            this.txtMaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.ForeColor = System.Drawing.Color.Black;
            this.txtMaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaBan.Location = new System.Drawing.Point(128, 411);
            this.txtMaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.PlaceholderText = "";
            this.txtMaBan.SelectedText = "";
            this.txtMaBan.Size = new System.Drawing.Size(199, 36);
            this.txtMaBan.TabIndex = 10;
            // 
            // nudSoChoNgoi
            // 
            this.nudSoChoNgoi.BackColor = System.Drawing.Color.Transparent;
            this.nudSoChoNgoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSoChoNgoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoChoNgoi.Location = new System.Drawing.Point(128, 503);
            this.nudSoChoNgoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSoChoNgoi.Name = "nudSoChoNgoi";
            this.nudSoChoNgoi.Size = new System.Drawing.Size(199, 36);
            this.nudSoChoNgoi.TabIndex = 12;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbxTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbxTrangThai.ItemHeight = 30;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
            this.cbxTrangThai.Location = new System.Drawing.Point(128, 454);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(199, 36);
            this.cbxTrangThai.TabIndex = 13;
            // 
            // ucQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "ucQLBan";
            this.Size = new System.Drawing.Size(1030, 657);
            this.Load += new System.EventHandler(this.ucQLBan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxDanhSachBan.ResumeLayout(false);
            this.gbxDanhSachBan.PerformLayout();
            this.gbxChiTietBan.ResumeLayout(false);
            this.gbxChiTietBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.gbxChuiThich.ResumeLayout(false);
            this.gbxChuiThich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChoNgoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2GroupBox gbxDanhSachBan;
        private Guna.UI2.WinForms.Guna2Button btnXoaBan;
        private Guna.UI2.WinForms.Guna2Button btnSuaBan;
        private Guna.UI2.WinForms.Guna2Button btnThemBan;
        private Guna.UI2.WinForms.Guna2GroupBox gbxChuiThich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachBan;
        private Guna.UI2.WinForms.Guna2GroupBox gbxChiTietBan;
        private Guna.UI2.WinForms.Guna2Button btnThemMon;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblTongTienTamTinh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachMon;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Label lblChiTietBan;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoaMon;
        private Guna.UI2.WinForms.Guna2Button btnSuaMon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoChoNgoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMaBan;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSoChoNgoi;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTrangThai;
    }
}
