using Guna.UI2.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNH
{
    public partial class frmMain : Form
    {
        string ChuoiKN = "Data Source=HUY;Initial Catalog=QLNH;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection KeNoi;

        public frmMain()
        {
            InitializeComponent();
            KeNoi = new SqlConnection(ChuoiKN);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    KeNoi.Open();
            //    if (KeNoi.State == ConnectionState.Open)
            //        MessageBox.Show("Kết nối thành công", "Thông báo");
            //}
            //catch (Exception)
            //{
            //    if (KeNoi.State != ConnectionState.Open)
            //        MessageBox.Show("Kết nối thất bại", "Thông báo");
            //}
            //finally
            //{
            //    KeNoi.Close();
            //}
            this.FormBorderStyle = FormBorderStyle.None;

       
        }

        private void btnQuanLyMonAn_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            QuanLyMonAn uc = new QuanLyMonAn();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucHoaDon uc = new ucHoaDon();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnQuanLyNhanvien_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void lblConten_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {
            //ptbLogo.Image = Image.FromFile("Anh1.jpg");
        }
    }
}
