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
using static QuanLyNH.QLDB;

namespace QuanLyNH
{
    public partial class ucHoaDon : UserControl
    {
        public ucHoaDon()
        {
            InitializeComponent();
        }
        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM HoaDon";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt;
                }
                else
                {
                    dgvHoaDon.DataSource = null;
                    MessageBox.Show("Không có hóa đơn nào trong cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hóa đơn: " + ex.Message);
            }
        }   
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHD LIKE @TuKhoa OR MaBan LIKE @TuKhoa";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@TuKhoa", "%" + txtTimKiem.Text.Trim() + "%")
                );

                if (dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt; // hiển thị kết quả lên DataGridView
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn phù hợp.");
                    dgvHoaDon.DataSource = null; // xóa dữ liệu cũ nếu không có kết quả
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
