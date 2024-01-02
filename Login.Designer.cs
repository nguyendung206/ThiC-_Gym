namespace Gym
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnDangky = new Button();
            btnDangnhap = new Button();
            txtMatkhau = new TextBox();
            txtTaikhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDangky
            // 
            btnDangky.BackColor = Color.FromArgb(128, 255, 255);
            btnDangky.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangky.ForeColor = Color.Black;
            btnDangky.Location = new Point(318, 381);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(114, 40);
            btnDangky.TabIndex = 8;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = false;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.FromArgb(128, 255, 128);
            btnDangnhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.ForeColor = Color.Black;
            btnDangnhap.Location = new Point(180, 381);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(114, 40);
            btnDangnhap.TabIndex = 7;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(227, 305);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(205, 27);
            txtMatkhau.TabIndex = 6;
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(227, 244);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(205, 27);
            txtTaikhoan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 305);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 244);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(206, 159);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(159, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 653);
            Controls.Add(btnDangky);
            Controls.Add(btnDangnhap);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatkhau);
            Controls.Add(label1);
            Controls.Add(txtTaikhoan);
            Controls.Add(label2);
            Controls.Add(label3);
            ForeColor = Color.White;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDangky;
        private Button btnDangnhap;
        private TextBox txtMatkhau;
        private TextBox txtTaikhoan;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}