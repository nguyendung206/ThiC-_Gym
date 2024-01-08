namespace Gym
{
    partial class RegisterPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPT));
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbBaitap = new ComboBox();
            cbbGoi = new ComboBox();
            dtpNgaydky = new DateTimePicker();
            dtvDshv = new DataGridView();
            dtvDspt = new DataGridView();
            txtTkhv = new TextBox();
            txtTkpt = new TextBox();
            btnTkhv = new Button();
            btnAllhv = new Button();
            btnTkpt = new Button();
            btnAllpt = new Button();
            btnDangky = new Button();
            dtvDsdk = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvDshv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvDspt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvDsdk).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(322, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1107, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(322, 149);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 28;
            label3.Text = "Bài tập:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(675, 149);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 29;
            label4.Text = "Gói:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1016, 149);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 30;
            label5.Text = "Ngày đăng ký:";
            // 
            // cbbBaitap
            // 
            cbbBaitap.Anchor = AnchorStyles.Top;
            cbbBaitap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbBaitap.FormattingEnabled = true;
            cbbBaitap.Items.AddRange(new object[] { "Yoga", "Cardio", "Gym", "Aerobic" });
            cbbBaitap.Location = new Point(412, 149);
            cbbBaitap.Name = "cbbBaitap";
            cbbBaitap.Size = new Size(206, 28);
            cbbBaitap.TabIndex = 37;
            // 
            // cbbGoi
            // 
            cbbGoi.Anchor = AnchorStyles.Top;
            cbbGoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGoi.FormattingEnabled = true;
            cbbGoi.Items.AddRange(new object[] { "1 tháng - 1 triệu", "3 tháng - 2.5 triệu", "6 tháng - 4.5 triệu", "12 tháng - 9.5 triệu" });
            cbbGoi.Location = new Point(732, 148);
            cbbGoi.Name = "cbbGoi";
            cbbGoi.Size = new Size(204, 28);
            cbbGoi.TabIndex = 38;
            // 
            // dtpNgaydky
            // 
            dtpNgaydky.Anchor = AnchorStyles.Top;
            dtpNgaydky.Location = new Point(1187, 149);
            dtpNgaydky.Name = "dtpNgaydky";
            dtpNgaydky.Size = new Size(263, 27);
            dtpNgaydky.TabIndex = 39;
            // 
            // dtvDshv
            // 
            dtvDshv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtvDshv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDshv.Location = new Point(27, 249);
            dtvDshv.Name = "dtvDshv";
            dtvDshv.RowHeadersWidth = 51;
            dtvDshv.RowTemplate.Height = 29;
            dtvDshv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvDshv.Size = new Size(671, 274);
            dtvDshv.TabIndex = 40;
            // 
            // dtvDspt
            // 
            dtvDspt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = Color.White;
            dataGridViewCellStyle36.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle36.ForeColor = Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = Color.White;
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.True;
            dtvDspt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            dtvDspt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = SystemColors.Window;
            dataGridViewCellStyle37.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle37.ForeColor = Color.White;
            dataGridViewCellStyle37.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.False;
            dtvDspt.DefaultCellStyle = dataGridViewCellStyle37;
            dtvDspt.Location = new Point(17, 67);
            dtvDspt.Name = "dtvDspt";
            dtvDspt.RowHeadersWidth = 51;
            dataGridViewCellStyle38.BackColor = Color.White;
            dataGridViewCellStyle38.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle38.ForeColor = Color.Black;
            dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
            dtvDspt.RowsDefaultCellStyle = dataGridViewCellStyle38;
            dtvDspt.RowTemplate.Height = 29;
            dtvDspt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvDspt.Size = new Size(668, 274);
            dtvDspt.TabIndex = 41;
            // 
            // txtTkhv
            // 
            txtTkhv.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTkhv.ForeColor = Color.Black;
            txtTkhv.Location = new Point(293, 33);
            txtTkhv.Name = "txtTkhv";
            txtTkhv.Size = new Size(194, 27);
            txtTkhv.TabIndex = 42;
            // 
            // txtTkpt
            // 
            txtTkpt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTkpt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTkpt.ForeColor = Color.Black;
            txtTkpt.Location = new Point(230, 26);
            txtTkpt.Name = "txtTkpt";
            txtTkpt.Size = new Size(186, 27);
            txtTkpt.TabIndex = 43;
            // 
            // btnTkhv
            // 
            btnTkhv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTkhv.ForeColor = Color.Black;
            btnTkhv.Location = new Point(528, 32);
            btnTkhv.Name = "btnTkhv";
            btnTkhv.Size = new Size(94, 29);
            btnTkhv.TabIndex = 44;
            btnTkhv.Text = "Tìm kiếm";
            btnTkhv.UseVisualStyleBackColor = true;
            btnTkhv.Click += btnTkhv_Click;
            // 
            // btnAllhv
            // 
            btnAllhv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllhv.ForeColor = Color.Black;
            btnAllhv.Location = new Point(645, 33);
            btnAllhv.Name = "btnAllhv";
            btnAllhv.Size = new Size(94, 27);
            btnAllhv.TabIndex = 45;
            btnAllhv.Text = "Tất cả";
            btnAllhv.UseVisualStyleBackColor = true;
            btnAllhv.Click += btnAllhv_Click;
            // 
            // btnTkpt
            // 
            btnTkpt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTkpt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTkpt.ForeColor = Color.Black;
            btnTkpt.Location = new Point(441, 26);
            btnTkpt.Name = "btnTkpt";
            btnTkpt.Size = new Size(94, 29);
            btnTkpt.TabIndex = 46;
            btnTkpt.Text = "Tìm kiếm";
            btnTkpt.UseVisualStyleBackColor = true;
            btnTkpt.Click += btnTkpt_Click;
            // 
            // btnAllpt
            // 
            btnAllpt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAllpt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllpt.ForeColor = Color.Black;
            btnAllpt.Location = new Point(559, 26);
            btnAllpt.Name = "btnAllpt";
            btnAllpt.Size = new Size(94, 29);
            btnAllpt.TabIndex = 47;
            btnAllpt.Text = "Tất cả";
            btnAllpt.UseVisualStyleBackColor = true;
            // 
            // btnDangky
            // 
            btnDangky.Anchor = AnchorStyles.Top;
            btnDangky.BackColor = Color.FromArgb(192, 255, 192);
            btnDangky.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangky.Location = new Point(803, 375);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(142, 41);
            btnDangky.TabIndex = 48;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = false;
            btnDangky.Click += btnDangky_Click;
            // 
            // dtvDsdk
            // 
            dtvDsdk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = SystemColors.Control;
            dataGridViewCellStyle39.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle39.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            dtvDsdk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            dtvDsdk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = SystemColors.Window;
            dataGridViewCellStyle40.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle40.ForeColor = Color.White;
            dataGridViewCellStyle40.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = DataGridViewTriState.False;
            dtvDsdk.DefaultCellStyle = dataGridViewCellStyle40;
            dtvDsdk.Location = new Point(21, 33);
            dtvDsdk.Name = "dtvDsdk";
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = SystemColors.Control;
            dataGridViewCellStyle41.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle41.ForeColor = Color.Black;
            dataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.True;
            dtvDsdk.RowHeadersDefaultCellStyle = dataGridViewCellStyle41;
            dtvDsdk.RowHeadersWidth = 51;
            dataGridViewCellStyle42.BackColor = Color.White;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle42.ForeColor = Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dtvDsdk.RowsDefaultCellStyle = dataGridViewCellStyle42;
            dtvDsdk.RowTemplate.Height = 29;
            dtvDsdk.Size = new Size(1169, 356);
            dtvDsdk.TabIndex = 49;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAllhv);
            groupBox1.Controls.Add(btnTkhv);
            groupBox1.Controls.Add(txtTkhv);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 358);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách Hội viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 35);
            label2.Name = "label2";
            label2.Size = new Size(239, 23);
            label2.TabIndex = 54;
            label2.Text = "Nhập tên hoặc số điện thoại:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dtvDsdk);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(260, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1204, 409);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Đăng ký";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dtvDspt);
            groupBox3.Controls.Add(btnAllpt);
            groupBox3.Controls.Add(txtTkpt);
            groupBox3.Controls.Add(btnTkpt);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(1038, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(702, 358);
            groupBox3.TabIndex = 53;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách PT";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(62, 27);
            label6.Name = "label6";
            label6.Size = new Size(239, 23);
            label6.TabIndex = 54;
            label6.Text = "Nhập tên hoặc số điện thoại:";
            // 
            // RegisterPT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1764, 735);
            Controls.Add(dtvDshv);
            Controls.Add(btnDangky);
            Controls.Add(dtpNgaydky);
            Controls.Add(groupBox2);
            Controls.Add(cbbGoi);
            Controls.Add(cbbBaitap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterPT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterPT";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvDshv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvDspt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvDsdk).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbbBaitap;
        private ComboBox cbbGoi;
        private DateTimePicker dtpNgaydky;
        private DataGridView dtvDshv;
        private DataGridView dtvDspt;
        private TextBox txtTkhv;
        private TextBox txtTkpt;
        private Button btnTkhv;
        private Button btnAllhv;
        private Button btnTkpt;
        private Button btnAllpt;
        private Button btnDangky;
        private DataGridView dtvDsdk;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label6;
    }
}