using Gyn;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym
{
    public partial class Login : Form
    {
        SqlConnection con;

        public Login()
        {
            InitializeComponent();
            con = new SqlConnection("data source =LAPTOP-NL7BAQ6R\\SQLEXPRESS; database = Gym; integrated security= true");
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string taikhoan = txtTaikhoan.Text;
                string matkhau = txtMatkhau.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM admin WHERE taikhoan = @taikhoan AND matkhau = @matkhau";
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Đăng nhập thành công, mở Form Home
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tài khoản và mật khẩu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
            this.Hide();
        }
    }
}
