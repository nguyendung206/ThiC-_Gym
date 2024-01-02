namespace Gym
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            btnQuaylai = new Button();
            btnDangky = new Button();
            txtMatkhau = new TextBox();
            label1 = new Label();
            txtTaikhoan = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // btnQuaylai
            // 
            btnQuaylai.BackColor = Color.White;
            btnQuaylai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuaylai.ForeColor = Color.Black;
            btnQuaylai.Location = new Point(318, 385);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(114, 40);
            btnQuaylai.TabIndex = 15;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // btnDangky
            // 
            btnDangky.BackColor = Color.FromArgb(128, 255, 255);
            btnDangky.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangky.ForeColor = Color.Black;
            btnDangky.Location = new Point(180, 385);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(114, 40);
            btnDangky.TabIndex = 14;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = false;
            btnDangky.Click += btnDangky_Click;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(227, 305);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(205, 27);
            txtMatkhau.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 159);
            label1.Name = "label1";
            label1.Size = new Size(134, 41);
            label1.TabIndex = 9;
            label1.Text = "Đăng ký";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(227, 244);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(205, 27);
            txtTaikhoan.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(124, 244);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 10;
            label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 305);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 653);
            Controls.Add(btnQuaylai);
            Controls.Add(btnDangky);
            Controls.Add(txtMatkhau);
            Controls.Add(label1);
            Controls.Add(txtTaikhoan);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnQuaylai;
        private Button btnDangky;
        private TextBox txtMatkhau;
        private Label label1;
        private TextBox txtTaikhoan;
        private Label label2;
        private Label label3;
    }
}