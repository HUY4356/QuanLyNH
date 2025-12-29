using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNH
{
    public partial class FormQLNhanVien : Form
    {
        SqlConnection ketNoi;
        SqlDataAdapter boDocGhi;
        DataSet dsQLNH;
        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void loadGridview()
        {
            string chuoiKN = (@"Data Source=localhost;Initial Catalog=QLNH;Integrated Security=True;Encrypt=False");
            ketNoi = new SqlConnection(chuoiKN);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ucQuanLyNhanVien uc = new ucQuanLyNhanVien();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);

        }
    }
}
