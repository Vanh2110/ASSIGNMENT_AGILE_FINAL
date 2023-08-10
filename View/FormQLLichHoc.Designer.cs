namespace DEMO_APP_LICH_HOC.View
{
    partial class FormQLLichHoc
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbxLop = new ComboBox();
            dtgDSLichHoc = new DataGridView();
            cmbxNgayTrongTuan = new ComboBox();
            txtPhongHoc = new TextBox();
            txtGioBD = new TextBox();
            txtGioKT = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            btnLogout = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            err = new ErrorProvider(components);
            btnQuayLai = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDSLichHoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(343, 22);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lý lịch học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 93);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 187);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày trong tuần";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 93);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Phòng học";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 158);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Giờ bắt đầu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 224);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 5;
            label6.Text = "Giờ kết thúc";
            // 
            // cmbxLop
            // 
            cmbxLop.FormattingEnabled = true;
            cmbxLop.Location = new Point(151, 93);
            cmbxLop.Name = "cmbxLop";
            cmbxLop.Size = new Size(193, 28);
            cmbxLop.TabIndex = 6;
            // 
            // dtgDSLichHoc
            // 
            dtgDSLichHoc.BackgroundColor = SystemColors.ButtonHighlight;
            dtgDSLichHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSLichHoc.Location = new Point(-2, 326);
            dtgDSLichHoc.Name = "dtgDSLichHoc";
            dtgDSLichHoc.RowHeadersWidth = 51;
            dtgDSLichHoc.RowTemplate.Height = 29;
            dtgDSLichHoc.Size = new Size(1015, 188);
            dtgDSLichHoc.TabIndex = 7;
            dtgDSLichHoc.CellClick += dtgDSLichHoc_CellClick;
            // 
            // cmbxNgayTrongTuan
            // 
            cmbxNgayTrongTuan.FormattingEnabled = true;
            cmbxNgayTrongTuan.Location = new Point(151, 184);
            cmbxNgayTrongTuan.Name = "cmbxNgayTrongTuan";
            cmbxNgayTrongTuan.Size = new Size(193, 28);
            cmbxNgayTrongTuan.TabIndex = 8;
            // 
            // txtPhongHoc
            // 
            txtPhongHoc.Location = new Point(518, 90);
            txtPhongHoc.Name = "txtPhongHoc";
            txtPhongHoc.Size = new Size(125, 27);
            txtPhongHoc.TabIndex = 9;
            // 
            // txtGioBD
            // 
            txtGioBD.Location = new Point(518, 155);
            txtGioBD.Name = "txtGioBD";
            txtGioBD.Size = new Size(125, 27);
            txtGioBD.TabIndex = 10;
            // 
            // txtGioKT
            // 
            txtGioKT.Location = new Point(518, 221);
            txtGioKT.Name = "txtGioKT";
            txtGioKT.Size = new Size(125, 27);
            txtGioKT.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(689, 149);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 55);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(859, 236);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 57);
            btnExit.TabIndex = 28;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OliveDrab;
            btnLogout.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Gold;
            btnLogout.Location = new Point(689, 236);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 57);
            btnLogout.TabIndex = 27;
            btnLogout.Text = "Log-out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(856, 54);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 59);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(859, 149);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 57);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.MenuHighlight;
            btnNew.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.GreenYellow;
            btnNew.Location = new Point(689, 54);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(117, 59);
            btnNew.TabIndex = 24;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = SystemColors.MenuHighlight;
            btnQuayLai.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnQuayLai.ForeColor = SystemColors.HighlightText;
            btnQuayLai.Location = new Point(12, 12);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(101, 33);
            btnQuayLai.TabIndex = 36;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormQLLichHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 512);
            Controls.Add(btnQuayLai);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtGioKT);
            Controls.Add(txtGioBD);
            Controls.Add(txtPhongHoc);
            Controls.Add(cmbxNgayTrongTuan);
            Controls.Add(dtgDSLichHoc);
            Controls.Add(cmbxLop);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQLLichHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLichHoc";
            FormClosing += FormQLLichHoc_FormClosing;
            Load += FormLichHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDSLichHoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbxLop;
        private DataGridView dtgDSLichHoc;
        private ComboBox cmbxNgayTrongTuan;
        private TextBox txtPhongHoc;
        private TextBox txtGioBD;
        private TextBox txtGioKT;
        private Button btnClear;
        private Button btnExit;
        private Button btnLogout;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private ErrorProvider err;
        private Button btnQuayLai;
    }
}