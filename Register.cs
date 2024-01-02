using Gyn;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym
{
    public partial class Register : Form
    {
        SqlConnection con;

        public Register()
        {
            InitializeComponent();
            con = new SqlConnection("data source =LAPTOP-NL7BAQ6R\\SQLEXPRESS; database = Gym; integrated security= true");
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string taikhoan = txtTaikhoan.Text;
                string matkhau = txtMatkhau.Text;
                if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                SqlCommand checkCmd = new SqlCommand("SELECT * FROM admin WHERE taikhoan = @taikhoan", con);
                checkCmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                SqlDataReader reader = checkCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác.");
                    reader.Close();
                    return;
                }
                reader.Close();

                SqlCommand cmd = new SqlCommand("INSERT INTO admin (taikhoan, matkhau) VALUES (@taikhoan, @matkhau)", con);
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
