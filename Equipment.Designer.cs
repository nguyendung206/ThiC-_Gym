namespace Gym
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            pictureBox1 = new PictureBox();
            btnReset = new Button();
            btnThem = new Button();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMota = new RichTextBox();
            dtpNgaynhap = new DateTimePicker();
            txtTentb = new TextBox();
            txtGia = new TextBox();
            txtNhomco = new TextBox();
            btnXoa = new Button();
            dtvDanhsach = new DataGridView();
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            btnAll = new Button();
            btnSua = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom;
            btnReset.BackColor = Color.FromArgb(255, 255, 192);
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(731, 702);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 41);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(147, 702);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 41);
            btnThem.TabIndex = 2;
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
            label9.Location = new Point(10, 83);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 44;
            label9.Text = "Nhóm cơ bắp:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 131);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 40;
            label5.Text = "Giá:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 182);
            label4.Name = "label4";
            label4.Size = new Size(173, 28);
            label4.TabIndex = 39;
            label4.Text = "Ngày nhận hàng:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(570, 135);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 37;
            label2.Text = "Mô tả:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 36;
            label1.Text = "Tên thiết bị:";
            // 
            // txtMota
            // 
            txtMota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtMota.Location = new Point(595, 33);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(295, 185);
            txtMota.TabIndex = 4;
            txtMota.Text = "";
            // 
            // dtpNgaynhap
            // 
            dtpNgaynhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpNgaynhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaynhap.Location = new Point(196, 184);
            dtpNgaynhap.Name = "dtpNgaynhap";
            dtpNgaynhap.Size = new Size(287, 27);
            dtpNgaynhap.TabIndex = 3;
            // 
            // txtTentb
            // 
            txtTentb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTentb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTentb.Location = new Point(196, 33);
            txtTentb.Name = "txtTentb";
            txtTentb.Size = new Size(287, 27);
            txtTentb.TabIndex = 0;
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(196, 135);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(287, 27);
            txtGia.TabIndex = 2;
            // 
            // txtNhomco
            // 
            txtNhomco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNhomco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhomco.Location = new Point(196, 83);
            txtNhomco.Name = "txtNhomco";
            txtNhomco.Size = new Size(287, 27);
            txtNhomco.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(538, 702);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 41);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtvDanhsach
            // 
            dtvDanhsach.AllowUserToAddRows = false;
            dtvDanhsach.AllowUserToDeleteRows = false;
            dtvDanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDanhsach.Location = new Point(64, 409);
            dtvDanhsach.Name = "dtvDanhsach";
            dtvDanhsach.ReadOnly = true;
            dtvDanhsach.RowHeadersWidth = 51;
            dtvDanhsach.RowTemplate.Height = 29;
            dtvDanhsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvDanhsach.Size = new Size(880, 264);
            dtvDanhsach.TabIndex = 49;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.ForeColor = Color.Black;
            txtTimkiem.Location = new Point(367, 23);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(187, 27);
            txtTimkiem.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimkiem.ForeColor = Color.Black;
            btnTimkiem.Location = new Point(582, 21);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 31);
            btnTimkiem.TabIndex = 1;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnAll
            // 
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.ForeColor = Color.Black;
            btnAll.Location = new Point(695, 21);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(118, 31);
            btnAll.TabIndex = 2;
            btnAll.Text = "Hiển thị tất cả";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.BackColor = Color.FromArgb(192, 255, 255);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(341, 702);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 41);
            btnSua.TabIndex = 3;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNhomco);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtTentb);
            groupBox1.Controls.Add(dtpNgaynhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(54, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(902, 231);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thiết bị";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTimkiem);
            groupBox2.Controls.Add(btnAll);
            groupBox2.Controls.Add(btnTimkiem);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(54, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(902, 340);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách thiết bị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(208, 24);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 12;
            label3.Text = "Nhập tên thiệt bị:";
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 764);
            Controls.Add(btnSua);
            Controls.Add(dtvDanhsach);
            Controls.Add(btnXoa);
            Controls.Add(btnReset);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            Load += Equipment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvDanhsach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnReset;
        private Button btnThem;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private RichTextBox txtMota;
        private DateTimePicker dtpNgaynhap;
        private TextBox txtTentb;
        private TextBox txtGia;
        private TextBox txtNhomco;
        private Button btnXoa;
        private DataGridView dtvDanhsach;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private Button btnAll;
        private Button btnSua;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
    }
}