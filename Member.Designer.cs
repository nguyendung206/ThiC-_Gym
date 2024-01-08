﻿namespace Gym
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            txtHodem = new TextBox();
            txtSdt = new TextBox();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dtpNgaysinh = new DateTimePicker();
            dtpNgaydky = new DateTimePicker();
            cbbTgtap = new ComboBox();
            cbbTghv = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnThem = new Button();
            btnReset = new Button();
            pictureBox1 = new PictureBox();
            txtDiachi = new TextBox();
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            btnAll = new Button();
            dtvDanhsach = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtHodem
            // 
            txtHodem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtHodem.Location = new Point(189, 140);
            txtHodem.Name = "txtHodem";
            txtHodem.Size = new Size(256, 27);
            txtHodem.TabIndex = 1;
            // 
            // txtSdt
            // 
            txtSdt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtSdt.Location = new Point(188, 309);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(256, 27);
            txtSdt.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTen.Location = new Point(189, 184);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(256, 27);
            txtTen.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEmail.Location = new Point(679, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(188, 224);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 27);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(272, 224);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 27);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpNgaysinh.Location = new Point(188, 264);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(256, 27);
            dtpNgaysinh.TabIndex = 5;
            // 
            // dtpNgaydky
            // 
            dtpNgaydky.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpNgaydky.Location = new Point(679, 223);
            dtpNgaydky.Name = "dtpNgaydky";
            dtpNgaydky.Size = new Size(256, 27);
            dtpNgaydky.TabIndex = 9;
            // 
            // cbbTgtap
            // 
            cbbTgtap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbbTgtap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTgtap.FormattingEnabled = true;
            cbbTgtap.Items.AddRange(new object[] { "6AM - 7AM", "7AM - 8AM", "8AM - 9AM", "9AM - 10AM", "1PM - 2PM", "2PM - 3PM", "3PM - 4PM", "4PM - 5PM" });
            cbbTgtap.Location = new Point(679, 265);
            cbbTgtap.Name = "cbbTgtap";
            cbbTgtap.Size = new Size(256, 28);
            cbbTgtap.TabIndex = 10;
            // 
            // cbbTghv
            // 
            cbbTghv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbbTghv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTghv.FormattingEnabled = true;
            cbbTghv.Items.AddRange(new object[] { "1 Tháng", "2 Tháng", "3 Tháng", "6 Tháng", "12 Tháng" });
            cbbTghv.Location = new Point(679, 308);
            cbbTghv.Name = "cbbTghv";
            cbbTghv.Size = new Size(255, 28);
            cbbTghv.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 136);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 11;
            label1.Text = "Họ đệm:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 184);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 12;
            label2.Text = "Tên:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 223);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 13;
            label3.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 266);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 14;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 309);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 15;
            label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(518, 136);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 16;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(517, 218);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 17;
            label7.Text = "Ngày đăng ký:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(518, 258);
            label8.Name = "label8";
            label8.Size = new Size(144, 28);
            label8.TabIndex = 18;
            label8.Text = "Thời gian tập:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(518, 179);
            label9.Name = "label9";
            label9.Size = new Size(83, 28);
            label9.TabIndex = 19;
            label9.Text = "Địa chỉ:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(517, 308);
            label10.Name = "label10";
            label10.Size = new Size(134, 28);
            label10.TabIndex = 20;
            label10.Text = "Gói Hội viên:";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(155, 678);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 46);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom;
            btnReset.BackColor = Color.FromArgb(255, 255, 192);
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(724, 678);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 46);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDiachi.Location = new Point(679, 180);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(256, 27);
            txtDiachi.TabIndex = 8;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.ForeColor = Color.Black;
            txtTimkiem.Location = new Point(418, 24);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(194, 27);
            txtTimkiem.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimkiem.ForeColor = Color.Black;
            btnTimkiem.Location = new Point(644, 24);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(111, 27);
            btnTimkiem.TabIndex = 1;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnAll
            // 
            btnAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.ForeColor = Color.Black;
            btnAll.Location = new Point(777, 24);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(119, 27);
            btnAll.TabIndex = 2;
            btnAll.Text = "Hiện thị tất cả";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // dtvDanhsach
            // 
            dtvDanhsach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtvDanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDanhsach.Location = new Point(41, 420);
            dtvDanhsach.Name = "dtvDanhsach";
            dtvDanhsach.RowHeadersWidth = 51;
            dtvDanhsach.RowTemplate.Height = 29;
            dtvDanhsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvDanhsach.Size = new Size(900, 233);
            dtvDanhsach.TabIndex = 29;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(538, 678);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 46);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.BackColor = Color.FromArgb(192, 255, 255);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(345, 678);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 46);
            btnSua.TabIndex = 13;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(16, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(937, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Hội viên";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtTimkiem);
            groupBox2.Controls.Add(btnTimkiem);
            groupBox2.Controls.Add(btnAll);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(16, 363);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(937, 309);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Hội viên";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(173, 24);
            label11.Name = "label11";
            label11.Size = new Size(239, 23);
            label11.TabIndex = 29;
            label11.Text = "Nhập tên hoặc số điện thoại:";
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 736);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(dtvDanhsach);
            Controls.Add(txtDiachi);
            Controls.Add(pictureBox1);
            Controls.Add(btnReset);
            Controls.Add(btnThem);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbTghv);
            Controls.Add(cbbTgtap);
            Controls.Add(dtpNgaydky);
            Controls.Add(dtpNgaysinh);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtEmail);
            Controls.Add(txtTen);
            Controls.Add(txtSdt);
            Controls.Add(txtHodem);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addmember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHodem;
        private TextBox txtSdt;
        private TextBox txtTen;
        private TextBox txtEmail;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dtpNgaysinh;
        private DateTimePicker dtpNgaydky;
        private ComboBox cbbTgtap;
        private ComboBox cbbTghv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnThem;
        private Button btnReset;
        private PictureBox pictureBox1;
        private TextBox txtDiachi;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private Button btnAll;
        private DataGridView dtvDanhsach;
        private Button btnXoa;
        private Button btnSua;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label11;
    }
}