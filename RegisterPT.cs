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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Gym
{
    public partial class RegisterPT : Form
    {
        SqlConnection con;
        SqlDataAdapter DA;
        DataSet ds;
        public RegisterPT()
        {
            InitializeComponent();
            con = new SqlConnection("data source =LAPTOP-NL7BAQ6R\\SQLEXPRESS; database = Gym; integrated security= true");
            LoadDataHV();
            LoadDataPT();
            LoadDataDK();
        }
        private void LoadDataHV()
        {
            try
            {
                DA = new SqlDataAdapter("SELECT * FROM hoivien", con);
                ds = new DataSet();
                DA.Fill(ds, "Hoivien");
                dtvDshv.DataSource = ds.Tables["Hoivien"];
                dtvDshv.Columns["mahoivien"].HeaderText = "Mã hội viên";
                dtvDshv.Columns["hodem"].HeaderText = "Họ đệm";
                dtvDshv.Columns["ten"].HeaderText = "Tên";
                dtvDshv.Columns["gioitinh"].HeaderText = "Giới tính";
                dtvDshv.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dtvDshv.Columns["sdt"].HeaderText = "Số điện thoại";
                dtvDshv.Columns["email"].HeaderText = "Email";
                dtvDshv.Columns["ngaydky"].HeaderText = "Ngày đăng ký";
                dtvDshv.Columns["tgtap"].HeaderText = "Thời gian tập";
                dtvDshv.Columns["diachi"].HeaderText = "Địa chỉ";
                dtvDshv.Columns["tghoivien"].HeaderText = "Thời gian hội viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadDataPT()
        {
            try
            {
                DA = new SqlDataAdapter("SELECT * FROM quanly", con);
                ds = new DataSet();
                DA.Fill(ds, "QuanLy");
                dtvDspt.DataSource = ds.Tables["QuanLy"];
                dtvDspt.Columns["maquanly"].HeaderText = "Mã PT";
                dtvDspt.Columns["hodem"].HeaderText = "Họ đệm";
                dtvDspt.Columns["ten"].HeaderText = "Tên";
                dtvDspt.Columns["gioitinh"].HeaderText = "Giới tính";
                dtvDspt.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dtvDspt.Columns["sdt"].HeaderText = "Số điện thoại";
                dtvDspt.Columns["email"].HeaderText = "Email";
                dtvDspt.Columns["ngaydky"].HeaderText = "Ngày đăng ký";
                dtvDspt.Columns["tinhtrang"].HeaderText = "Tình trạng";
                dtvDspt.Columns["diachi"].HeaderText = "Địa chỉ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadDataDK()
        {
            try
            {
                DA = new SqlDataAdapter("SELECT * FROM HV_PT", con);
                ds = new DataSet();
                DA.Fill(ds, "dangkypt");
                dtvDsdk.DataSource = ds.Tables["dangkypt"];
                dtvDsdk.Columns["mahoivien"].HeaderText = "Mã hội viên";
                dtvDsdk.Columns["maquanly"].HeaderText = "Mã PT";
                dtvDsdk.Columns["hotenhv"].HeaderText = "Họ tên Hội viên";
                dtvDsdk.Columns["hotenpt"].HeaderText = "Họ tên PT";
                dtvDsdk.Columns["baitap"].HeaderText = "Bài tập";
                dtvDsdk.Columns["goi"].HeaderText = "Gói";
                dtvDsdk.Columns["ngaydangky"].HeaderText = "Ngày đăng ký";
                dtvDsdk.Columns["hotenhv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtvDsdk.Columns["hotenpt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtvDsdk.Columns["ngaydangky"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtvDsdk.Columns["goi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (dtvDspt.SelectedRows.Count > 0 && dtvDshv.SelectedRows.Count > 0)
            {
                // Lấy thông tin của Quản lý
                DataGridViewRow selectedRowPT = dtvDspt.SelectedRows[0];
                String maquanly = selectedRowPT.Cells["maquanly"].Value.ToString();
                String hodempt = selectedRowPT.Cells["hodem"].Value.ToString();
                String tenpt = selectedRowPT.Cells["ten"].Value.ToString();
                String hotenpt = hodempt + ' ' + tenpt;

                // Lấy thông tin của Hội viên
                DataGridViewRow selectedRowHV = dtvDshv.SelectedRows[0];
                String mahoivien = selectedRowHV.Cells["mahoivien"].Value.ToString();
                String hodemhv = selectedRowHV.Cells["hodem"].Value.ToString();
                String tenhv = selectedRowHV.Cells["ten"].Value.ToString();
                String hotenhv = hodemhv + ' ' + tenhv;

                // Lấy thông tin từ các ComboBox và DateTimePicker
                String goi = (cbbGoi.SelectedItem != null) ? cbbGoi.SelectedItem.ToString() : null;
                String baitap = (cbbBaitap.SelectedItem != null) ? cbbBaitap.SelectedItem.ToString() : null;
                DateTime ngaydangky = dtpNgaydky.Value;

                // Kiểm tra thông tin trước khi đăng ký
                if (string.IsNullOrEmpty(goi) || string.IsNullOrEmpty(baitap))
                {
                    MessageBox.Show("Vui lòng chọn Bài tập và Gói trước khi đăng ký.");
                    return;
                }

                // Thực hiện insert vào bảng HV_PT
                SqlConnection con = new SqlConnection("data source =LAPTOP-NL7BAQ6R\\SQLEXPRESS; database = Gym; integrated security= true");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO HV_PT (mahoivien, maquanly, hotenhv, hotenpt, baitap, goi, ngaydangky) " +
                    "VALUES (@mahoivien, @maquanly, @hotenhv, @hotenpt, @baitap, @goi, @ngaydangky)";
                cmd.Parameters.AddWithValue("@mahoivien", mahoivien);
                cmd.Parameters.AddWithValue("@maquanly", maquanly);
                cmd.Parameters.AddWithValue("@hotenhv", hotenhv);
                cmd.Parameters.AddWithValue("@hotenpt", hotenpt);
                cmd.Parameters.AddWithValue("@baitap", baitap);
                cmd.Parameters.AddWithValue("@goi", goi);
                cmd.Parameters.AddWithValue("@ngaydangky", ngaydangky);

                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    LoadDataDK();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. Vui lòng kiểm tra lại thông tin.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cả Quản lý và Hội viên trước khi đăng ký.");
            }
        }

        private void btnTkhv_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string key = txtTkhv.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM hoivien WHERE ten LIKE '%' + @key + '%' or sdt LIKE '%' + @key + '%'", con);
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter searchDA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                searchDA.Fill(ds, "SearchResult");
                dtvDshv.DataSource = ds.Tables["SearchResult"];
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

        private void btnAllhv_Click(object sender, EventArgs e)
        {
            LoadDataHV();
        }

        private void btnTkpt_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string key = txtTkpt.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM quanly WHERE ten LIKE '%' + @key + '%' or sdt LIKE '%' + @key + '%'", con);
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter searchDA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                searchDA.Fill(ds, "SearchResult");
                dtvDspt.DataSource = ds.Tables["SearchResult"];
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
    }
}
