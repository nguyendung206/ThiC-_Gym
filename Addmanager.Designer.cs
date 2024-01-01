namespace Gym
{
    partial class Addmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmanager));
            pictureBox1 = new PictureBox();
            btnReset = new Button();
            btnThem = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpNgaydky = new DateTimePicker();
            dtpNgaysinh = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtEmail = new TextBox();
            txtTen = new TextBox();
            txtSdt = new TextBox();
            txtHodem = new TextBox();
            txtDiachi = new TextBox();
            txtTinhtrang = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom;
            btnReset.Location = new Point(476, 599);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(113, 44);
            btnReset.TabIndex = 45;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(218, 599);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 44);
            btnThem.TabIndex = 44;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(436, 420);
            label9.Name = "label9";
            label9.Size = new Size(83, 28);
            label9.TabIndex = 42;
            label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(436, 339);
            label8.Name = "label8";
            label8.Size = new Size(116, 28);
            label8.TabIndex = 41;
            label8.Text = "Tình trạng:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(435, 256);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 40;
            label7.Text = "Ngày đăng ký:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(435, 172);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 39;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 499);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 38;
            label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 420);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 37;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 339);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 36;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 259);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 35;
            label2.Text = "Tên:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 172);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 34;
            label1.Text = "Họ đệm:";
            // 
            // dtpNgaydky
            // 
            dtpNgaydky.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpNgaydky.Format = DateTimePickerFormat.Short;
            dtpNgaydky.Location = new Point(597, 261);
            dtpNgaydky.Name = "dtpNgaydky";
            dtpNgaydky.Size = new Size(194, 27);
            dtpNgaydky.TabIndex = 30;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(185, 418);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(194, 27);
            dtpNgaysinh.TabIndex = 29;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(269, 340);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(185, 340);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEmail.Location = new Point(597, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 26;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTen.Location = new Point(185, 259);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(194, 27);
            txtTen.TabIndex = 25;
            // 
            // txtSdt
            // 
            txtSdt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtSdt.Location = new Point(185, 499);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(194, 27);
            txtSdt.TabIndex = 24;
            // 
            // txtHodem
            // 
            txtHodem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtHodem.Location = new Point(185, 176);
            txtHodem.Name = "txtHodem";
            txtHodem.Size = new Size(194, 27);
            txtHodem.TabIndex = 23;
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDiachi.Location = new Point(597, 418);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(194, 27);
            txtDiachi.TabIndex = 46;
            // 
            // txtTinhtrang
            // 
            txtTinhtrang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTinhtrang.Location = new Point(597, 340);
            txtTinhtrang.Name = "txtTinhtrang";
            txtTinhtrang.Size = new Size(194, 27);
            txtTinhtrang.TabIndex = 47;
            // 
            // Addmanager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(816, 707);
            Controls.Add(txtTinhtrang);
            Controls.Add(txtDiachi);
            Controls.Add(btnReset);
            Controls.Add(btnThem);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNgaydky);
            Controls.Add(dtpNgaysinh);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtEmail);
            Controls.Add(txtTen);
            Controls.Add(txtSdt);
            Controls.Add(txtHodem);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Addmanager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addmanager";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnReset;
        private Button btnThem;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgaydky;
        private DateTimePicker dtpNgaysinh;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtEmail;
        private TextBox txtTen;
        private TextBox txtSdt;
        private TextBox txtHodem;
        private TextBox txtDiachi;
        private TextBox txtTinhtrang;
    }
}