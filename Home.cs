using Gym;

namespace Gyn
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addMember_Click(object sender, EventArgs e)
        {
            Member mb = new Member();
            mb.Show();
        }


        private void addManager_Click_1(object sender, EventArgs e)
        {
            Manager mn = new Manager();
            mn.Show();
        }

        private void Equipment_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void RegisterPT_Click(object sender, EventArgs e)
        {
            RegisterPT rp = new RegisterPT();
            rp.Show();
        }
    }
}