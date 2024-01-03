using Gyn;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym
{
    public partial class Member : Form
    {
        SqlConnection con;
        SqlDataAdapter DA;
        DataSet ds;

        public Member()
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
                DA = new SqlDataAdapter("SELECT * FROM hoivien", con);
                ds = new DataSet();
                DA.Fill(ds, "Hoivien");
                dtvDanhsach.DataSource = ds.Tables["Hoivien"];
                dtvDanhsach.Columns["mahoivien"].HeaderText = "Mã hội viên";
                dtvDanhsach.Columns["hodem"].HeaderText = "Họ đệm";
                dtvDanhsach.Columns["ten"].HeaderText = "Tên";
                dtvDanhsach.Columns["gioitinh"].HeaderText = "Giới tính";
                dtvDanhsach.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dtvDanhsach.Columns["sdt"].HeaderText = "Số điện thoại";
                dtvDanhsach.Columns["email"].HeaderText = "Email";
                dtvDanhsach.Columns["ngaydky"].HeaderText = "Ngày đăng ký";
                dtvDanhsach.Columns["tgtap"].HeaderText = "Thời gian tập";
                dtvDanhsach.Columns["diachi"].HeaderText = "Địa chỉ";
                dtvDanhsach.Columns["tghoivien"].HeaderText = "Thời gian hội viên";
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
                string tgtap = row.Cells["tgtap"].Value.ToString();
                string diachi = row.Cells["diachi"].Value.ToString();
                string tghv = row.Cells["tghoivien"].Value.ToString();

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
                cbbTgtap.Text = tgtap;
                txtDiachi.Text = diachi;
                cbbTghv.Text = tghv;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String hodem = txtHodem.Text;
                String ten = txtTen.Text;
                String gioitinh = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                String ngaysinh = dtpNgaysinh.Text;
                String sdt = txtSdt.Text;
                String email = txtEmail.Text;
                String ngaydky = dtpNgaydky.Text;
                String tgtap = cbbTgtap.Text;
                String diachi = txtDiachi.Text;
                String tghv = cbbTghv.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO hoivien (hodem, ten, gioitinh, ngaysinh, sdt, email, ngaydky, tgtap, diachi, tghoivien) " +
                                  "VALUES (@hodem, @ten, @gioitinh, @ngaysinh, @sdt, @email, @ngaydky, @tgtap, @diachi, @tghv)";
                cmd.Parameters.AddWithValue("@hodem", hodem);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@ngaydky", ngaydky);
                cmd.Parameters.AddWithValue("@tgtap", tgtap);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@tghv", tghv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Hội viên thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm Hội viên: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
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
            cbbTghv.ResetText();
            cbbTgtap.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataGridViewRow selectedRow = dtvDanhsach.SelectedRows[0];
                String mahoivien = selectedRow.Cells["mahoivien"].Value.ToString();
                String hodem = txtHodem.Text;
                String ten = txtTen.Text;
                String gioitinh = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                String ngaysinh = dtpNgaysinh.Text;
                String sdt = txtSdt.Text;
                String email = txtEmail.Text;
                String ngaydky = dtpNgaydky.Text;
                String tgtap = cbbTgtap.Text;
                String diachi = txtDiachi.Text;
                String tghv = cbbTghv.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE hoivien SET hodem = @hodem, ten = @ten, gioitinh = @gioitinh, " +
                                  "ngaysinh = @ngaysinh, sdt = @sdt, email = @email, ngaydky = @ngaydky, " +
                                  "tgtap = @tgtap, diachi = @diachi, tghoivien = @tghv WHERE mahoivien = @mahoivien";
                cmd.Parameters.AddWithValue("@mahoivien", mahoivien);
                cmd.Parameters.AddWithValue("@hodem", hodem);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@ngaydky", ngaydky);
                cmd.Parameters.AddWithValue("@tgtap", tgtap);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@tghv", tghv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật Hội viên thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật Hội viên: " + ex.Message);
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
                    string mahoivien = dtvDanhsach.SelectedRows[0].Cells["mahoivien"].Value.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM hoivien WHERE mahoivien = @mahoivien";
                    cmd.Parameters.AddWithValue("@mahoivien", mahoivien);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa hội viên thành công");
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string key = txtTimkiem.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM hoivien WHERE ten LIKE '%' + @key + '%' or sdt LIKE '%' + @key + '%'", con);
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
