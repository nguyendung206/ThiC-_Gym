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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.BackColor = Color.FromArgb(192, 255, 255);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(331, 693);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 46);
            btnSua.TabIndex = 2;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(524, 693);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 46);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtvDanhsach
            // 
            dtvDanhsach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtvDanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDanhsach.Location = new Point(35, 448);
            dtvDanhsach.Name = "dtvDanhsach";
            dtvDanhsach.RowHeadersWidth = 51;
            dtvDanhsach.RowTemplate.Height = 29;
            dtvDanhsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvDanhsach.Size = new Size(900, 217);
            dtvDanhsach.TabIndex = 60;
            // 
            // btnAll
            // 
            btnAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.ForeColor = Color.Black;
            btnAll.Location = new Point(752, 25);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(119, 29);
            btnAll.TabIndex = 2;
            btnAll.Text = "Hiện thị tất cả";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimkiem.ForeColor = Color.Black;
            btnTimkiem.Location = new Point(601, 25);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(115, 29);
            btnTimkiem.TabIndex = 1;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(378, 25);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(194, 27);
            txtTimkiem.TabIndex = 0;
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDiachi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(666, 85);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(256, 27);
            txtDiachi.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(267, 0);
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
            btnReset.Location = new Point(710, 693);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 46);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(141, 693);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 46);
            btnThem.TabIndex = 1;
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
            label9.Location = new Point(505, 84);
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
            label8.Location = new Point(505, 137);
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
            label7.Location = new Point(505, 182);
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
            label5.Location = new Point(22, 230);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 46;
            label5.Text = "Số điện thoại:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 182);
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
            label3.Location = new Point(23, 137);
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
            label2.Location = new Point(23, 89);
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
            dtpNgaydky.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaydky.Location = new Point(666, 184);
            dtpNgaydky.Name = "dtpNgaydky";
            dtpNgaydky.Size = new Size(257, 27);
            dtpNgaydky.TabIndex = 9;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpNgaysinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaysinh.Location = new Point(170, 180);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(257, 27);
            dtpNgaysinh.TabIndex = 4;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(255, 138);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 27);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(171, 138);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 27);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(666, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(171, 89);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(256, 27);
            txtTen.TabIndex = 1;
            // 
            // txtSdt
            // 
            txtSdt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtSdt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(170, 230);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(256, 27);
            txtSdt.TabIndex = 5;
            txtSdt.TextChanged += txtSdt_TextChanged;
            // 
            // txtHodem
            // 
            txtHodem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtHodem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHodem.Location = new Point(170, 40);
            txtHodem.Name = "txtHodem";
            txtHodem.Size = new Size(256, 27);
            txtHodem.TabIndex = 0;
            // 
            // txtTinhtrang
            // 
            txtTinhtrang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTinhtrang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTinhtrang.Location = new Point(666, 135);
            txtTinhtrang.Name = "txtTinhtrang";
            txtTinhtrang.Size = new Size(256, 27);
            txtTinhtrang.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtTinhtrang);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(txtHodem);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgaydky);
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 276);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin PT";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTimkiem);
            groupBox2.Controls.Add(btnAll);
            groupBox2.Controls.Add(btnTimkiem);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 388);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(946, 288);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách PT";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(138, 26);
            label10.Name = "label10";
            label10.Size = new Size(239, 23);
            label10.TabIndex = 60;
            label10.Text = "Nhập tên hoặc số điện thoại:";
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 751);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(dtvDanhsach);
            Controls.Add(pictureBox1);
            Controls.Add(btnReset);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý PT";
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
    }
}