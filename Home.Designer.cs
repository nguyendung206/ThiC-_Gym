namespace Gyn
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            menuStrip1 = new MenuStrip();
            addMember = new ToolStripMenuItem();
            addManager = new ToolStripMenuItem();
            Equipment = new ToolStripMenuItem();
            Logout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addMember, addManager, Equipment, Logout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1051, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addMember
            // 
            addMember.BackColor = Color.Silver;
            addMember.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addMember.Name = "addMember";
            addMember.Size = new Size(206, 35);
            addMember.Text = "Quản lý Hội viên";
            addMember.Click += addMember_Click;
            // 
            // addManager
            // 
            addManager.BackColor = Color.FromArgb(224, 224, 224);
            addManager.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addManager.Name = "addManager";
            addManager.Size = new Size(143, 35);
            addManager.Text = "Quản lý PT";
            addManager.Click += addManager_Click_1;
            // 
            // Equipment
            // 
            Equipment.BackColor = Color.Silver;
            Equipment.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Equipment.Name = "Equipment";
            Equipment.Size = new Size(151, 35);
            Equipment.Text = "Thiết bị tập";
            Equipment.Click += Equipment_Click;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Red;
            Logout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.ForeColor = Color.White;
            Logout.Name = "Logout";
            Logout.RightToLeft = RightToLeft.No;
            Logout.Size = new Size(139, 35);
            Logout.Text = "Đăng xuất";
            Logout.TextDirection = ToolStripTextDirection.Horizontal;
            Logout.Click += Logout_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1051, 630);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Trang chủ";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addMember;
        private ToolStripMenuItem addManager;
        private ToolStripMenuItem Equipment;
        private ToolStripMenuItem Logout;
    }
}