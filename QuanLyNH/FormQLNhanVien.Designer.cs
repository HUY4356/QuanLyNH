namespace QuanLyNH
{
    partial class FormQLNhanVien
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
            this.qLNHDataSet = new QuanLyNH.QLNHDataSet();
            this.qLNHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.grbDanhSachNhanVien = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.grbThongTinNhanVien = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSetBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.grbDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.grbThongTinNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLNHDataSet
            // 
            this.qLNHDataSet.DataSetName = "QLNHDataSet";
            this.qLNHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNHDataSetBindingSource
            // 
            this.qLNHDataSetBindingSource.DataSource = this.qLNHDataSet;
            this.qLNHDataSetBindingSource.Position = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnHoaDon);
            this.guna2Panel1.Controls.Add(this.btnQuanLyMonAn);
            this.guna2Panel1.Controls.Add(this.btnQuanLyBan);
            this.guna2Panel1.Controls.Add(this.btnQuanLyNhanVien);
            this.guna2Panel1.Location = new System.Drawing.Point(13, 13);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(160, 657);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.FillColor = System.Drawing.SystemColors.Control;
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Location = new System.Drawing.Point(1, 143);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(158, 45);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "Hoá đơn";
            this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQuanLyMonAn
            // 
            this.btnQuanLyMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyMonAn.FillColor = System.Drawing.SystemColors.Control;
            this.btnQuanLyMonAn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMonAn.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyMonAn.Location = new System.Drawing.Point(1, 98);
            this.btnQuanLyMonAn.Name = "btnQuanLyMonAn";
            this.btnQuanLyMonAn.Size = new System.Drawing.Size(158, 45);
            this.btnQuanLyMonAn.TabIndex = 2;
            this.btnQuanLyMonAn.Text = "Quản lý món ăn";
            this.btnQuanLyMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQuanLyBan
            // 
            this.btnQuanLyBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyBan.FillColor = System.Drawing.SystemColors.Control;
            this.btnQuanLyBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBan.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyBan.Location = new System.Drawing.Point(1, 53);
            this.btnQuanLyBan.Name = "btnQuanLyBan";
            this.btnQuanLyBan.Size = new System.Drawing.Size(158, 45);
            this.btnQuanLyBan.TabIndex = 1;
            this.btnQuanLyBan.Text = "Quản lý bàn";
            this.btnQuanLyBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyNhanVien.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(1, 8);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(158, 45);
            this.btnQuanLyNhanVien.TabIndex = 0;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // panelContent
            // 
            this.panelContent.BorderColor = System.Drawing.Color.DarkGray;
            this.panelContent.BorderThickness = 1;
            this.panelContent.Controls.Add(this.grbDanhSachNhanVien);
            this.panelContent.Controls.Add(this.grbThongTinNhanVien);
            this.panelContent.Location = new System.Drawing.Point(173, 13);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1077, 657);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // grbDanhSachNhanVien
            // 
            this.grbDanhSachNhanVien.Controls.Add(this.dgvDanhSachNhanVien);
            this.grbDanhSachNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachNhanVien.ForeColor = System.Drawing.Color.Black;
            this.grbDanhSachNhanVien.Location = new System.Drawing.Point(163, 309);
            this.grbDanhSachNhanVien.Name = "grbDanhSachNhanVien";
            this.grbDanhSachNhanVien.Size = new System.Drawing.Size(750, 322);
            this.grbDanhSachNhanVien.TabIndex = 3;
            this.grbDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(19, 52);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            this.dgvDanhSachNhanVien.RowTemplate.Height = 24;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(712, 255);
            this.dgvDanhSachNhanVien.TabIndex = 0;
            this.dgvDanhSachNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNhanVien_CellContentClick);
            // 
            // grbThongTinNhanVien
            // 
            this.grbThongTinNhanVien.Controls.Add(this.btnXoa);
            this.grbThongTinNhanVien.Controls.Add(this.btnSua);
            this.grbThongTinNhanVien.Controls.Add(this.btnLamMoi);
            this.grbThongTinNhanVien.Controls.Add(this.btnThem);
            this.grbThongTinNhanVien.Controls.Add(this.cbxChucVu);
            this.grbThongTinNhanVien.Controls.Add(this.txtHoTen);
            this.grbThongTinNhanVien.Controls.Add(this.txtMaNV);
            this.grbThongTinNhanVien.Controls.Add(this.lblChucVu);
            this.grbThongTinNhanVien.Controls.Add(this.lblHoTen);
            this.grbThongTinNhanVien.Controls.Add(this.lblMaNV);
            this.grbThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.grbThongTinNhanVien.ForeColor = System.Drawing.Color.Black;
            this.grbThongTinNhanVien.Location = new System.Drawing.Point(163, 26);
            this.grbThongTinNhanVien.Name = "grbThongTinNhanVien";
            this.grbThongTinNhanVien.Size = new System.Drawing.Size(750, 260);
            this.grbThongTinNhanVien.TabIndex = 2;
            this.grbThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // btnXoa
            // 
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(445, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 47);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            // 
            // btnSua
            // 
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.Gold;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(310, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 47);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(583, 191);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 47);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnThem
            // 
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(170, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 47);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.ForeColor = System.Drawing.Color.Black;
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Location = new System.Drawing.Point(170, 122);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(510, 25);
            this.cbxChucVu.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(170, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(510, 25);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(170, 46);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(510, 25);
            this.txtMaNV.TabIndex = 3;
            // 
            // lblChucVu
            // 
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.ForeColor = System.Drawing.Color.Black;
            this.lblChucVu.Location = new System.Drawing.Point(19, 128);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(53, 18);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(19, 91);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(45, 18);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.ForeColor = System.Drawing.Color.Black;
            this.lblMaNV.Location = new System.Drawing.Point(19, 52);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(47, 18);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý nhân viên";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.FormQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSetBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.grbDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.grbThongTinNhanVien.ResumeLayout(false);
            this.grbThongTinNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource qLNHDataSetBindingSource;
        private QLNHDataSet qLNHDataSet;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2GroupBox grbDanhSachNhanVien;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private Guna.UI2.WinForms.Guna2GroupBox grbThongTinNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChucVu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaNV;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyMonAn;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyBan;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyNhanVien;
    }
}