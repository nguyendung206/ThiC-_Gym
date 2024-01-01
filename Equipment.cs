using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym
{
    public partial class Equipment : Form
    {
        SqlConnection con;
        SqlDataAdapter DA;
        DataSet ds;

        public Equipment()
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
                DA = new SqlDataAdapter("SELECT * FROM thietbi", con);
                ds = new DataSet();
                DA.Fill(ds, "ThietBi");
                dtvDanhsach.DataSource = ds.Tables["ThietBi"];
                dtvDanhsach.Columns["tenthietbi"].HeaderText = "Tên thiết bị";
                dtvDanhsach.Columns["mota"].HeaderText = "Mô tả";
                dtvDanhsach.Columns["mathietbi"].HeaderText = "Mã thiết bị";
                dtvDanhsach.Columns["ngaynhap"].HeaderText = "Ngày nhập";
                dtvDanhsach.Columns["gia"].HeaderText = "Giá";
                dtvDanhsach.Columns["nhomco"].HeaderText = "Nhóm cơ";
                dtvDanhsach.Columns["mota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String tentb = txtTentb.Text;
                String mota = txtMota.Text;
                String ngaynhap = dtpNgaynhap.Text;
                Int64 gia = Int64.Parse(txtGia.Text);
                String nhomco = txtNhomco.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO thietbi (tenthietbi, mota, nhomco, ngaynhap, gia) " +
                                  "VALUES (@tentb, @mota, @nhomco, @ngaynhap, @gia)";
                cmd.Parameters.AddWithValue("@tentb", tentb);
                cmd.Parameters.AddWithValue("@mota", mota);
                cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
                cmd.Parameters.AddWithValue("@gia", gia);
                cmd.Parameters.AddWithValue("@nhomco", nhomco);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thiết bị thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thiết bị: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTentb.Clear();
            txtMota.Clear();
            dtpNgaynhap.Value = DateTime.Now;
            txtNhomco.Clear();
            txtGia.Clear();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string key = txtTimkiem.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM thietbi WHERE tenthietbi LIKE '%' + @key + '%'", con);
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

        private void dtvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtvDanhsach.Rows[e.RowIndex];
                string tenthietbi = row.Cells["tenthietbi"].Value.ToString();
                string mota = row.Cells["mota"].Value.ToString();
                string ngaynhap = row.Cells["ngaynhap"].Value.ToString();
                string gia = row.Cells["gia"].Value.ToString();
                string nhomco = row.Cells["nhomco"].Value.ToString();
                txtTentb.Text = tenthietbi;
                txtMota.Text = mota;
                dtpNgaynhap.Text = ngaynhap;
                txtGia.Text = gia;
                txtNhomco.Text = nhomco;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataGridViewRow selectedRow = dtvDanhsach.SelectedRows[0];
                String matb = selectedRow.Cells["mathietbi"].Value.ToString();
                String tentb = txtTentb.Text;
                String mota = txtMota.Text;
                String ngaynhap = dtpNgaynhap.Text;
                Int64 gia = Int64.Parse(txtGia.Text);
                String nhomco = txtNhomco.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE thietbi SET tenthietbi = @tentb, mota = @mota, nhomco = @nhomco, ngaynhap = @ngaynhap, gia = @gia " +
                                  "WHERE mathietbi = @matb";
                cmd.Parameters.AddWithValue("@matb", matb);
                cmd.Parameters.AddWithValue("@tentb", tentb);
                cmd.Parameters.AddWithValue("@mota", mota);
                cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
                cmd.Parameters.AddWithValue("@gia", gia);
                cmd.Parameters.AddWithValue("@nhomco", nhomco);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin thiết bị thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin thiết bị: " + ex.Message);
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
                con.Open();

                if (dtvDanhsach.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtvDanhsach.SelectedRows[0];
                    String matb = selectedRow.Cells["mathietbi"].Value.ToString();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM thietbi WHERE mathietbi = @matb";
                    cmd.Parameters.AddWithValue("@matb", matb);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thiết bị thành công");
                    LoadData();
                    btnReset_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa thiết bị: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
