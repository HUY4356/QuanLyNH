using Guna.UI2.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
        string ChuoiKN = "Data Source=localhost;Initial Catalog=QLNH;Integrated Security=True;Encrypt=False";
        SqlConnection KeNoi;

        public FormMain()
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

            try
            {
                if (KeNoi.State != ConnectionState.Open)
                    KeNoi.Open();

                string query = "SELECT * FROM MonAn";
                SqlDataAdapter adapter = new SqlDataAdapter(query, KeNoi);
                DataTable table = new DataTable();
                adapter.Fill(table);
                //dgvMonAn.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (KeNoi.State == ConnectionState.Open)
                    KeNoi.Close();
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucQuanLyNhanVien uc = new ucQuanLyNhanVien();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);

        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucQLBan uc = new ucQLBan();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);

        }

        private void lblMaMon_Click(object sender, EventArgs e)
        {

        }

        private void dgwMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gpbThongtin_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
