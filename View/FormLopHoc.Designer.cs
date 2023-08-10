namespace DEMO_APP_LICH_HOC.View
{
    partial class FormLopHoc
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
            btnQuayLai = new Button();
            btnThoat = new Button();
            dtgDSLopHoc = new DataGridView();
            btnDangXuat = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnQLTV = new Button();
            btnClear = new Button();
            txtMonHoc = new TextBox();
            txt = new Label();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            cmbxMaGiangVien = new ComboBox();
            txtNgayKT = new TextBox();
            txtNgayBD = new TextBox();
            txtMaLop = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDSLopHoc).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = SystemColors.MenuHighlight;
            btnQuayLai.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnQuayLai.ForeColor = SystemColors.HighlightText;
            btnQuayLai.Location = new Point(12, 6);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(101, 33);
            btnQuayLai.TabIndex = 35;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Lime;
            btnThoat.Location = new Point(900, 26);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 57);
            btnThoat.TabIndex = 34;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // dtgDSLopHoc
            // 
            dtgDSLopHoc.BackgroundColor = SystemColors.ButtonHighlight;
            dtgDSLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSLopHoc.Dock = DockStyle.Bottom;
            dtgDSLopHoc.Location = new Point(0, 455);
            dtgDSLopHoc.Name = "dtgDSLopHoc";
            dtgDSLopHoc.RowHeadersWidth = 51;
            dtgDSLopHoc.RowTemplate.Height = 29;
            dtgDSLopHoc.Size = new Size(1066, 189);
            dtgDSLopHoc.TabIndex = 32;
            dtgDSLopHoc.CellClick += dtgDSLopHoc_CellClick;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.OliveDrab;
            btnDangXuat.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Gold;
            btnDangXuat.Location = new Point(750, 26);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(117, 57);
            btnDangXuat.TabIndex = 33;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(393, 42);
            label1.Name = "label1";
            label1.Size = new Size(216, 33);
            label1.TabIndex = 31;
            label1.Text = "Quản Lý Lớp Học";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQLTV);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtMonHoc);
            groupBox1.Controls.Add(txt);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cmbxMaGiangVien);
            groupBox1.Controls.Add(txtNgayKT);
            groupBox1.Controls.Add(txtNgayBD);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(67, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(901, 315);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // btnQLTV
            // 
            btnQLTV.Font = new Font("Noto Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLTV.Location = new Point(683, 222);
            btnQLTV.Name = "btnQLTV";
            btnQLTV.Size = new Size(131, 59);
            btnQLTV.TabIndex = 31;
            btnQLTV.Text = "Quản lý thành viên lớp";
            btnQLTV.UseVisualStyleBackColor = true;
            btnQLTV.Click += btnQLTV_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(501, 226);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 55);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtMonHoc
            // 
            txtMonHoc.Location = new Point(587, 35);
            txtMonHoc.Name = "txtMonHoc";
            txtMonHoc.Size = new Size(180, 27);
            txtMonHoc.TabIndex = 29;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(440, 38);
            txt.Name = "txt";
            txt.Size = new Size(74, 20);
            txt.TabIndex = 28;
            txt.Text = "Môn học :";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Yellow;
            btnXoa.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(183, 224);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 59);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.SkyBlue;
            btnCapNhat.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = SystemColors.ControlLightLight;
            btnCapNhat.Location = new Point(342, 225);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(117, 57);
            btnCapNhat.TabIndex = 25;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.GreenYellow;
            btnThem.Location = new Point(30, 225);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 59);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cmbxMaGiangVien
            // 
            cmbxMaGiangVien.FormattingEnabled = true;
            cmbxMaGiangVien.Location = new Point(183, 89);
            cmbxMaGiangVien.Name = "cmbxMaGiangVien";
            cmbxMaGiangVien.Size = new Size(180, 28);
            cmbxMaGiangVien.TabIndex = 8;
            // 
            // txtNgayKT
            // 
            txtNgayKT.Location = new Point(587, 138);
            txtNgayKT.Name = "txtNgayKT";
            txtNgayKT.Size = new Size(180, 27);
            txtNgayKT.TabIndex = 7;
            // 
            // txtNgayBD
            // 
            txtNgayBD.Location = new Point(183, 138);
            txtNgayBD.Name = "txtNgayBD";
            txtNgayBD.Size = new Size(180, 27);
            txtNgayBD.TabIndex = 5;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(183, 38);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(180, 27);
            txtMaLop.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 138);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày kết thúc :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 92);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 2;
            label5.Text = "Mã Giảng Viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 146);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày Bắt Đầu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã lớp :";
            // 
            // FormLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 644);
            Controls.Add(btnQuayLai);
            Controls.Add(btnThoat);
            Controls.Add(dtgDSLopHoc);
            Controls.Add(btnDangXuat);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormLopHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLopHoc";
            FormClosing += FormLopHoc_FormClosing;
            Load += FormLopHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDSLopHoc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private Button btnThoat;
        private DataGridView dtgDSLopHoc;
        private Button btnDangXuat;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnClear;
        private TextBox txtMonHoc;
        private Label txt;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private ComboBox cmbxMaGiangVien;
        private TextBox txtNgayKT;
        private TextBox txtNgayBD;
        private TextBox txtMaLop;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnQLTV;
    }
}