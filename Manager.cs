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

namespace Gym
{
    public partial class Manager : Form
    {
        SqlConnection con;
        SqlDataAdapter DA;
        DataSet ds;
        public Manager()
        {
            InitializeComponent();
            con = new SqlConnection("data source =LAPTOP-NL7BAQ6R\\SQLEXPRESS; database = Gym; integrated security= true");
            LoadData();
            dtvDanhsach.CellClick += new DataGridViewCellEventHandler(dtvDanhsach_CellClick);
        }
        private void LoadData()
        {
            try
            {
                DA = new SqlDataAdapter("SELECT * FROM quanly", con);
                ds = new DataSet();
                DA.Fill(ds, "QuanLy");
                dtvDanhsach.DataSource = ds.Tables["QuanLy"];
                dtvDanhsach.Columns["maquanly"].HeaderText = "Mã quản lý";
                dtvDanhsach.Columns["hodem"].HeaderText = "Họ đệm";
                dtvDanhsach.Columns["ten"].HeaderText = "Tên";
                dtvDanhsach.Columns["gioitinh"].HeaderText = "Giới tính";
                dtvDanhsach.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dtvDanhsach.Columns["sdt"].HeaderText = "Số điện thoại";
                dtvDanhsach.Columns["email"].HeaderText = "Email";
                dtvDanhsach.Columns["ngaydky"].HeaderText = "Ngày đăng ký";
                dtvDanhsach.Columns["tinhtrang"].HeaderText = "Tình trạng";
                dtvDanhsach.Columns["diachi"].HeaderText = "Địa chỉ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void dtvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtvDanhsach.Rows[e.RowIndex];
                string hodem = row.Cells["hodem"].Value.ToString();
                string ten = row.Cells["ten"].Value.ToString();
                string gioitinh = row.Cells["gioitinh"].Value.ToString();
                string ngaysinh = row.Cells["ngaysinh"].Value.ToString();
                string sdt = row.Cells["sdt"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string ngaydky = row.Cells["ngaydky"].Value.ToString();
                string tinhtrang = row.Cells["tinhtrang"].Value.ToString();
                string diachi = row.Cells["diachi"].Value.ToString();

                txtHodem.Text = hodem;
                txtTen.Text = ten;
                if (gioitinh == "Nam")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                dtpNgaysinh.Text = ngaysinh;
                txtSdt.Text = sdt;
                txtEmail.Text = email;
                dtpNgaydky.Text = ngaydky;
                txtTinhtrang.Text = tinhtrang;
                txtDiachi.Text = diachi;
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            String hodem = txtHodem.Text;
            String ten = txtTen.Text;
            String gioitinh = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                gioitinh = radioButton1.Text;
            }
            else
            {
                gioitinh = radioButton2.Text;
            }
            String ngaysinh = dtpNgaydky.Text;
            String sdt = txtSdt.Text;
            String email = txtEmail.Text;
            String ngaydky = dtpNgaydky.Text;
            String diachi = txtDiachi.Text;
            String tinhtrang = txtTinhtrang.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =LAPTOP-NL7BAQ6R\\SQLEXPRESS; database = Gym; integrated security= true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO quanly (hodem, ten, gioitinh, ngaysinh, sdt, email, ngaydky, tinhtrang, diachi) " +
                  "VALUES (@hodem, @ten, @gioitinh, @ngaysinh, @sdt, @email, @ngaydky, @tinhtrang, @diachi)";
            cmd.Parameters.AddWithValue("@hodem", hodem);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@ngaydky", ngaydky);
            cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);
            MessageBox.Show("Thêm Quản lý thành công");
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHodem.Clear();
            txtTen.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dtpNgaydky.Value = DateTime.Now;
            dtpNgaysinh.Value = DateTime.Now;
            txtSdt.Clear();
            txtEmail.Clear();
            txtDiachi.Clear();
            txtTinhtrang.Clear();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string key = txtTimkiem.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM quanly WHERE ten LIKE '%' + @key + '%' or sdt LIKE '%' + @key + '%'", con);
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter searchDA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                searchDA.Fill(ds, "SearchResult");
                dtvDanhsach.DataSource = ds.Tables["SearchResult"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataGridViewRow selectedRow = dtvDanhsach.SelectedRows[0];
                String maquanly = selectedRow.Cells["maquanly"].Value.ToString();
                String hodem = txtHodem.Text;
                String ten = txtTen.Text;
                String gioitinh = "";
                bool isChacked = radioButton1.Checked;
                if (isChacked)
                {
                    gioitinh = radioButton1.Text;
                }
                else
                {
                    gioitinh = radioButton2.Text;
                }
                String ngaysinh = dtpNgaydky.Text;
                String sdt = txtSdt.Text;
                String email = txtEmail.Text;
                String ngaydky = dtpNgaydky.Text;
                String diachi = txtDiachi.Text;
                String tinhtrang = txtTinhtrang.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE quanly SET hodem = @hodem, ten = @ten, gioitinh = @gioitinh, " +
                                  "ngaysinh = @ngaysinh, sdt = @sdt, email = @email, ngaydky = @ngaydky, " +
                                  "diachi = @diachi, tinhtrang = @tinhtrang WHERE maquanly = @maquanly";
                cmd.Parameters.AddWithValue("@maquanly", maquanly);
                cmd.Parameters.AddWithValue("@hodem", hodem);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@ngaydky", ngaydky);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật Quản lý thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật Quản lý: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvDanhsach.SelectedRows.Count > 0)
                {
                    con.Open();
                    string maquanly = dtvDanhsach.SelectedRows[0].Cells["maquanly"].Value.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM quanly WHERE maquanly = @maquanly";
                    cmd.Parameters.AddWithValue("@maquanly", maquanly);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa Quản lý thành công");
                    LoadData();
                    btnReset_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hội viên để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hội viên: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
