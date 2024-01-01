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
    public partial class Addmanager : Form
    {
        public Addmanager()
        {
            InitializeComponent();
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
            Int64 sdt = Int64.Parse(txtSdt.Text);
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
    }
}
