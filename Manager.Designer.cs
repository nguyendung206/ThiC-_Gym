namespace Gym
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            btnSua = new Button();
            btnXoa = new Button();
            dtvDanhsach = new DataGridView();
            btnAll = new Button();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            label11 = new Label();
            txtDiachi = new TextBox();
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
            txtTinhtrang = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.BackColor = Color.FromArgb(192, 255, 255);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(331, 678);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 46);
            btnSua.TabIndex = 62;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = Color.FromArgb(255, 192, 192);
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(524, 678);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 46);
            btnXoa.TabIndex = 61;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtvDanhsach
            // 
            dtvDanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDanhsach.Location = new Point(35, 477);
            dtvDanhsach.Name = "dtvDanhsach";
            dtvDanhsach.RowHeadersWidth = 51;
            dtvDanhsach.RowTemplate.Height = 29;
            dtvDanhsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvDanhsach.Size = new Size(900, 188);
            dtvDanhsach.TabIndex = 60;
            // 
            // btnAll
            // 
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.Location = new Point(679, 429);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(119, 29);
            btnAll.TabIndex = 59;
            btnAll.Text = "Hiện thị tất cả";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimkiem.Location = new Point(551, 429);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(115, 29);
            btnTimkiem.TabIndex = 58;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimkiem.Location = new Point(328, 431);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(194, 27);
            txtTimkiem.TabIndex = 57;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(35, 430);
            label11.Name = "label11";
            label11.Size = new Size(200, 28);
            label11.TabIndex = 56;
            label11.Text = "Danh sách Hội viên:";
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDiachi.Location = new Point(678, 199);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(256, 27);
            txtDiachi.TabIndex = 55;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom;
            btnReset.BackColor = Color.FromArgb(255, 255, 192);
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(710, 678);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 46);
            btnReset.TabIndex = 53;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(141, 678);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 46);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(517, 198);
            label9.Name = "label9";
            label9.Size = new Size(83, 28);
            label9.TabIndex = 50;
            label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(517, 260);
            label8.Name = "label8";
            label8.Size = new Size(116, 28);
            label8.TabIndex = 49;
            label8.Text = "Tình trạng:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(517, 317);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 48;
            label7.Text = "Ngày đăng ký:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(517, 142);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 47;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 371);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 46;
            label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 317);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 45;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 260);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 44;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 203);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 43;
            label2.Text = "Tên:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 142);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 42;
            label1.Text = "Họ đệm:";
            // 
            // dtpNgaydky
            // 
            dtpNgaydky.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpNgaydky.Location = new Point(679, 319);
            dtpNgaydky.Name = "dtpNgaydky";
            dtpNgaydky.Size = new Size(256, 27);
            dtpNgaydky.TabIndex = 39;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpNgaysinh.Location = new Point(183, 315);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(256, 27);
            dtpNgaysinh.TabIndex = 38;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(267, 261);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 37;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(183, 261);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 36;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEmail.Location = new Point(678, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 35;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTen.Location = new Point(183, 203);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(256, 27);
            txtTen.TabIndex = 34;
            // 
            // txtSdt
            // 
            txtSdt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtSdt.Location = new Point(183, 371);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(256, 27);
            txtSdt.TabIndex = 33;
            // 
            // txtHodem
            // 
            txtHodem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtHodem.Location = new Point(183, 146);
            txtHodem.Name = "txtHodem";
            txtHodem.Size = new Size(256, 27);
            txtHodem.TabIndex = 32;
            // 
            // txtTinhtrang
            // 
            txtTinhtrang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTinhtrang.Location = new Point(678, 258);
            txtTinhtrang.Name = "txtTinhtrang";
            txtTinhtrang.Size = new Size(256, 27);
            txtTinhtrang.TabIndex = 63;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 736);
            Controls.Add(txtTinhtrang);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(dtvDanhsach);
            Controls.Add(btnAll);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label11);
            Controls.Add(txtDiachi);
            Controls.Add(pictureBox1);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addmanager";
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Button btnXoa;
        private DataGridView dtvDanhsach;
        private Button btnAll;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private Label label11;
        private TextBox txtDiachi;
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
        private TextBox txtTinhtrang;
    }
}