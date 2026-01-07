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
    public partial class ucQuanLyNhanVien : UserControl
    {
        string ChuoiKN = "Data Source=localhost;Initial Catalog=QLNH;Integrated Security=True;Encrypt=False";
        SqlConnection KetNoi;

        string maNVDangChon = "";
        public ucQuanLyNhanVien()
        {
            InitializeComponent();
            KetNoi = new SqlConnection(ChuoiKN); 
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                if (KetNoi.State != ConnectionState.Open)
                    KetNoi.Open();

                string query = "SELECT MaNV, HoTen, ChucVu FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, KetNoi);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDanhSachnhanVien.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (KetNoi.State == ConnectionState.Open)
                    KetNoi.Close();
            }

            //dgvDanhSachnhanVien.Columns["MaNV"].HeaderText = "Mã NV";
            //dgvDanhSachnhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            //dgvDanhSachnhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
        }

        private void dgvDanhSachnhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maNV = dgvDanhSachnhanVien.Rows[e.RowIndex].Cells["colMaNV"].Value.ToString();

                maNVDangChon = maNV;

                try
                {
                    if (KetNoi.State != ConnectionState.Open) KetNoi.Open();

                    string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(query, KetNoi))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMaNV.Text = reader["MaNV"].ToString();
                                txtHoTen.Text = reader["HoTen"].ToString();

                                if (reader["NgaySinh"] != DBNull.Value)
                                    dtpNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);

                                txtQueQuan.Text = reader["QueQuan"].ToString();
                                txtSoDienThoai.Text = reader["SoDT"].ToString();
                                cbxChucVu.Text = reader["ChucVu"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy thông tin: " + ex.Message);
                }
                finally
                {
                    if (KetNoi.State == ConnectionState.Open) KetNoi.Close();
                }
            }
        }

        private void dgvDanhSachnhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ChuoiKN))
                {
                    conn.Open();
                    string query = "SELECT MaNV, HoTen, ChucVu FROM NhanVien";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvDanhSachnhanVien.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtQueQuan.Clear();
            txtSoDienThoai.Clear();
            cbxChucVu.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;

            maNVDangChon = ""; 
            txtMaNV.Focus();
            LoadData(); 
        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNVDangChon))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trong danh sách!");
                return;
            }

            try
            {
                using (SqlConnection KetNoi = new SqlConnection(ChuoiKN))
                {
                    KetNoi.Open();
                    string query = "UPDATE NhanVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, QueQuan=@QueQuan, SoDT=@SoDT, ChucVu=@ChucVu WHERE MaNV=@MaNV";

                    using (SqlCommand cmd = new SqlCommand(query, KetNoi))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNVDangChon); // Sửa dựa trên Mã NV đang chọn
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                        cmd.Parameters.AddWithValue("@SoDT", txtSoDienThoai.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", cbxChucVu.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        btnLamMoi_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNVDangChon))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection KetNoi = new SqlConnection(ChuoiKN))
                    {
                        KetNoi.Open();
                        string query = "DELETE FROM NhanVien WHERE MaNV=@MaNV";

                        using (SqlCommand cmd = new SqlCommand(query, KetNoi))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", maNVDangChon);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa nhân viên!");
                            btnLamMoi_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message + "\n(Có thể nhân viên này đang dính khóa ngoại với bảng Hóa Đơn/Lương)");
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text)) { MessageBox.Show("Vui lòng nhập họ tên!"); return; }

            try
            {
                using (SqlConnection KetNoi = new SqlConnection(ChuoiKN))
                {
                    KetNoi.Open();

                    string query = "INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, QueQuan, SoDT, ChucVu) VALUES (@MaNV, @HoTen, @NgaySinh, @QueQuan, @SoDT, @ChucVu)";

                    using (SqlCommand cmd = new SqlCommand(query, KetNoi))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                        cmd.Parameters.AddWithValue("@SoDT", txtSoDienThoai.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", cbxChucVu.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhân viên thành công!");
                        btnLamMoi_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }
    }
}
