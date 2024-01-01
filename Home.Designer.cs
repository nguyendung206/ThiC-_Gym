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
            tìmKiếmHộiViênToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addMember, addManager, Equipment, tìmKiếmHộiViênToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1051, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addMember
            // 
            addMember.BackColor = Color.Silver;
            addMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addMember.Name = "addMember";
            addMember.Size = new Size(164, 32);
            addMember.Text = "Thêm Hội viên";
            addMember.Click += addMember_Click;
            // 
            // addManager
            // 
            addManager.BackColor = Color.FromArgb(224, 224, 224);
            addManager.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addManager.Name = "addManager";
            addManager.Size = new Size(158, 32);
            addManager.Text = "Thêm Quản lý";
            addManager.Click += addManager_Click_1;
            // 
            // Equipment
            // 
            Equipment.BackColor = Color.Silver;
            Equipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Equipment.Name = "Equipment";
            Equipment.Size = new Size(136, 32);
            Equipment.Text = "Thiết bị tập";
            Equipment.Click += Equipment_Click;
            // 
            // tìmKiếmHộiViênToolStripMenuItem
            // 
            tìmKiếmHộiViênToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            tìmKiếmHộiViênToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tìmKiếmHộiViênToolStripMenuItem.Name = "tìmKiếmHộiViênToolStripMenuItem";
            tìmKiếmHộiViênToolStripMenuItem.Size = new Size(184, 32);
            tìmKiếmHộiViênToolStripMenuItem.Text = "Quản lý Hội viên";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            đăngXuấtToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(124, 32);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.BackColor = Color.Silver;
            thoátToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(81, 32);
            thoátToolStripMenuItem.Text = "Thoát";
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
        private ToolStripMenuItem tìmKiếmHộiViênToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}