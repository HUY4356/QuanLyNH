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
            this.pnlSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQuanLyNhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyBan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.qLNHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHDataSet = new QuanLyNH.QLNHDataSet();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSideBar.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSideBar.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlSideBar.BorderThickness = 1;
            this.pnlSideBar.Controls.Add(this.btnQuanLyNhanvien);
            this.pnlSideBar.Controls.Add(this.btnQuanLyHoaDon);
            this.pnlSideBar.Controls.Add(this.btnQuanLyMonAn);
            this.pnlSideBar.Controls.Add(this.btnQuanLyBan);
            this.pnlSideBar.ForeColor = System.Drawing.Color.Black;
            this.pnlSideBar.Location = new System.Drawing.Point(12, 79);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(210, 590);
            this.pnlSideBar.TabIndex = 0;
            this.pnlSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnQuanLyNhanvien
            // 
            this.btnQuanLyNhanvien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanLyNhanvien.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanLyNhanvien.BorderRadius = 3;
            this.btnQuanLyNhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyNhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyNhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyNhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyNhanvien.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuanLyNhanvien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanvien.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyNhanvien.Location = new System.Drawing.Point(5, 5);
            this.btnQuanLyNhanvien.Name = "btnQuanLyNhanvien";
            this.btnQuanLyNhanvien.Size = new System.Drawing.Size(200, 50);
            this.btnQuanLyNhanvien.TabIndex = 0;
            this.btnQuanLyNhanvien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnQuanLyHoaDon
            // 
            this.btnQuanLyHoaDon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanLyHoaDon.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanLyHoaDon.BorderRadius = 3;
            this.btnQuanLyHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyHoaDon.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuanLyHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyHoaDon.Location = new System.Drawing.Point(5, 173);
            this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            this.btnQuanLyHoaDon.Size = new System.Drawing.Size(200, 50);
            this.btnQuanLyHoaDon.TabIndex = 3;
            this.btnQuanLyHoaDon.Text = "Hóa đơn";
            this.btnQuanLyHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQuanLyMonAn
            // 
            this.btnQuanLyMonAn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanLyMonAn.BorderColor = System.Drawing.SystemColors.Control;
            this.btnQuanLyMonAn.BorderRadius = 3;
            this.btnQuanLyMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyMonAn.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQuanLyMonAn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMonAn.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyMonAn.Location = new System.Drawing.Point(5, 117);
            this.btnQuanLyMonAn.Name = "btnQuanLyMonAn";
            this.btnQuanLyMonAn.Size = new System.Drawing.Size(200, 50);
            this.btnQuanLyMonAn.TabIndex = 2;
            this.btnQuanLyMonAn.Text = "Quản lý món ăn";
            this.btnQuanLyMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQuanLyBan
            // 
            this.btnQuanLyBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanLyBan.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanLyBan.BorderRadius = 3;
            this.btnQuanLyBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyBan.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuanLyBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBan.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyBan.Location = new System.Drawing.Point(5, 61);
            this.btnQuanLyBan.Name = "btnQuanLyBan";
            this.btnQuanLyBan.Size = new System.Drawing.Size(200, 50);
            this.btnQuanLyBan.TabIndex = 1;
            this.btnQuanLyBan.Text = "Quản lý bàn";
            this.btnQuanLyBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel2.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1240, 657);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(210, 66);
            this.guna2Panel4.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(1, 1);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(208, 65);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Quản Lý Nhà Hàng";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLNHDataSetBindingSource
            // 
            this.qLNHDataSetBindingSource.DataSource = this.qLNHDataSet;
            this.qLNHDataSetBindingSource.Position = 0;
            // 
            // qLNHDataSet
            // 
            this.qLNHDataSet.DataSetName = "QLNHDataSet";
            this.qLNHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlContent
            // 
            this.pnlContent.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContent.BorderThickness = 1;
            this.pnlContent.Location = new System.Drawing.Point(221, 12);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1030, 657);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlSideBar;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyMonAn;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyBan;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyNhanvien;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.BindingSource qLNHDataSetBindingSource;
        private QLNHDataSet qLNHDataSet;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
    }
}

