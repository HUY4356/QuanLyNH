using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNH
{
    public partial class FormMain : Form
    {
        string ChuoiKN = "Data Source=HUY;Initial Catalog=QLNH;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection KeNoi = new SqlConnection();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            KeNoi.ConnectionString = ChuoiKN;

            //try
            //{
            //    KeNoi.Open();
            //    if(KeNoi.State == ConnectionState.Open)
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

            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            //btnNhanvien.Text = "Quản lý món ăn";
            btnNhanvien.Image = Properties.Resources.food_icon; // icon từ Resources
            btnNhanvien.ImageAlign = HorizontalAlignment.Left;
            btnNhanvien.TextAlign = HorizontalAlignment.Right;
        }

        private void btnBan_Click(object sender, EventArgs e)
        {

        }

        private void lblMaMon_Click(object sender, EventArgs e)
        {

        }
    }
}
