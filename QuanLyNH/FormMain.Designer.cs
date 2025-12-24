namespace QuanLyNH
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btnBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.qLNHDataSet = new QuanLyNH.QLNHDataSet();
            this.qLNHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpbMonAn = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.gpbThongtin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblMaMon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenMon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSetBindingSource)).BeginInit();
            this.gpbMonAn.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.gpbThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnNhanvien);
            this.guna2Panel1.Controls.Add(this.btnHoaDon);
            this.guna2Panel1.Controls.Add(this.btnMonAn);
            this.guna2Panel1.Controls.Add(this.btnBan);
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(11, 12);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(160, 657);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanvien.FillColor = System.Drawing.SystemColors.Control;
            this.btnNhanvien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanvien.Location = new System.Drawing.Point(1, 8);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(0);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(158, 45);
            this.btnNhanvien.TabIndex = 0;
            this.btnNhanvien.Text = "Quản lý nhân viên";
            this.btnNhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnBan
            // 
            this.btnBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBan.FillColor = System.Drawing.SystemColors.Control;
            this.btnBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.Black;
            this.btnBan.Location = new System.Drawing.Point(1, 53);
            this.btnBan.Margin = new System.Windows.Forms.Padding(0);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(158, 45);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Quản lý bàn";
            this.btnBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.BackColor = System.Drawing.SystemColors.Control;
            this.btnMonAn.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonAn.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMonAn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonAn.ForeColor = System.Drawing.Color.White;
            this.btnMonAn.Location = new System.Drawing.Point(1, 98);
            this.btnMonAn.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Size = new System.Drawing.Size(158, 45);
            this.btnMonAn.TabIndex = 2;
            this.btnMonAn.Text = "Quản lý món ăn";
            this.btnMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.FillColor = System.Drawing.SystemColors.Control;
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Location = new System.Drawing.Point(1, 143);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(158, 45);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1240, 657);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.DataSource = this.qLNHDataSetBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle27;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 55);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(15);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(378, 503);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // gpbMonAn
            // 
            this.gpbMonAn.BorderRadius = 5;
            this.gpbMonAn.Controls.Add(this.guna2DataGridView1);
            this.gpbMonAn.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.gpbMonAn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMonAn.ForeColor = System.Drawing.Color.Black;
            this.gpbMonAn.Location = new System.Drawing.Point(15, 64);
            this.gpbMonAn.Margin = new System.Windows.Forms.Padding(15, 3, 3, 20);
            this.gpbMonAn.Name = "gpbMonAn";
            this.gpbMonAn.Size = new System.Drawing.Size(408, 573);
            this.gpbMonAn.TabIndex = 1;
            this.gpbMonAn.Text = "Danh sách món ăn";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.gpbThongtin);
            this.guna2Panel3.Controls.Add(this.gpbMonAn);
            this.guna2Panel3.Location = new System.Drawing.Point(170, 12);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1082, 657);
            this.guna2Panel3.TabIndex = 2;
            // 
            // gpbThongtin
            // 
            this.gpbThongtin.BorderRadius = 5;
            this.gpbThongtin.Controls.Add(this.guna2TextBox3);
            this.gpbThongtin.Controls.Add(this.guna2TextBox2);
            this.gpbThongtin.Controls.Add(this.guna2TextBox1);
            this.gpbThongtin.Controls.Add(this.guna2HtmlLabel3);
            this.gpbThongtin.Controls.Add(this.lblTenMon);
            this.gpbThongtin.Controls.Add(this.lblMaMon);
            this.gpbThongtin.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.gpbThongtin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbThongtin.ForeColor = System.Drawing.Color.Black;
            this.gpbThongtin.Location = new System.Drawing.Point(441, 64);
            this.gpbThongtin.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.gpbThongtin.Name = "gpbThongtin";
            this.gpbThongtin.Size = new System.Drawing.Size(620, 262);
            this.gpbThongtin.TabIndex = 2;
            this.gpbThongtin.Text = "Thông tin món ăn";
            // 
            // lblMaMon
            // 
            this.lblMaMon.BackColor = System.Drawing.Color.Transparent;
            this.lblMaMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.ForeColor = System.Drawing.Color.Black;
            this.lblMaMon.Location = new System.Drawing.Point(44, 68);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(50, 17);
            this.lblMaMon.TabIndex = 0;
            this.lblMaMon.Text = "Mã món:";
            this.lblMaMon.Click += new System.EventHandler(this.lblMaMon_Click);
            // 
            // lblTenMon
            // 
            this.lblTenMon.BackColor = System.Drawing.Color.Transparent;
            this.lblTenMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.ForeColor = System.Drawing.Color.Black;
            this.lblTenMon.Location = new System.Drawing.Point(44, 115);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(54, 17);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Tên món:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(44, 164);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(50, 17);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Đơn giá:";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(178, 60);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 20, 10, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(425, 25);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(178, 108);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 20, 10, 3);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(425, 25);
            this.guna2TextBox2.TabIndex = 4;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(178, 156);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 20, 10, 3);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(225, 25);
            this.guna2TextBox3.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSetBindingSource)).EndInit();
            this.gpbMonAn.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.gpbThongtin.ResumeLayout(false);
            this.gpbThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnMonAn;
        private Guna.UI2.WinForms.Guna2Button btnBan;
        private Guna.UI2.WinForms.Guna2Button btnNhanvien;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2GroupBox gpbMonAn;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource qLNHDataSetBindingSource;
        private QLNHDataSet qLNHDataSet;
        private Guna.UI2.WinForms.Guna2GroupBox gpbThongtin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenMon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaMon;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}

