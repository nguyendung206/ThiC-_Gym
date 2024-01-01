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
            Addmember am = new Addmember();
            am.Show();
        }


        private void addManager_Click_1(object sender, EventArgs e)
        {
            Addmanager am = new Addmanager();
            am.Show();
        }

        private void Equipment_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }
    }
}