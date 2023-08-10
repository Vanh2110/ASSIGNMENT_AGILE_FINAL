namespace DEMO_APP_LICH_HOC.View
{
    partial class FormQLGiangVien
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
            btnQuayLai = new Button();
            dtgDSGV = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnExit = new Button();
            btnLogout = new Button();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            rtbDiaChi = new RichTextBox();
            txtMaGV = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dtgDSGV).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
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
            btnQuayLai.TabIndex = 13;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // dtgDSGV
            // 
            dtgDSGV.BackgroundColor = SystemColors.ButtonHighlight;
            dtgDSGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSGV.Dock = DockStyle.Bottom;
            dtgDSGV.Location = new Point(0, 654);
            dtgDSGV.Name = "dtgDSGV";
            dtgDSGV.RowHeadersWidth = 51;
            dtgDSGV.RowTemplate.Height = 29;
            dtgDSGV.Size = new Size(1136, 151);
            dtgDSGV.TabIndex = 12;
            dtgDSGV.CellClick += dtgDSGV_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(416, 35);
            label1.Name = "label1";
            label1.Size = new Size(248, 33);
            label1.TabIndex = 10;
            label1.Text = "Quản Lý Giảng Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(rtbDiaChi);
            groupBox1.Controls.Add(txtMaGV);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(126, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 545);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(537, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 55);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(707, 457);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 57);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OliveDrab;
            btnLogout.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Gold;
            btnLogout.Location = new Point(537, 457);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 57);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Log-out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(300, 291);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 20;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(169, 291);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 19;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(169, 229);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(282, 27);
            txtSDT.TabIndex = 18;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(169, 105);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(282, 27);
            txtTen.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 27);
            txtEmail.TabIndex = 16;
            // 
            // rtbDiaChi
            // 
            rtbDiaChi.Location = new Point(169, 349);
            rtbDiaChi.Name = "rtbDiaChi";
            rtbDiaChi.Size = new Size(282, 114);
            rtbDiaChi.TabIndex = 15;
            rtbDiaChi.Text = "";
            // 
            // txtMaGV
            // 
            txtMaGV.Location = new Point(169, 43);
            txtMaGV.Name = "txtMaGV";
            txtMaGV.Size = new Size(282, 27);
            txtMaGV.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(704, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 59);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(707, 370);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 57);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.MenuHighlight;
            btnNew.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.GreenYellow;
            btnNew.Location = new Point(537, 275);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(117, 59);
            btnNew.TabIndex = 10;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 173);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 9;
            label8.Text = "Email :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 234);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 8;
            label7.Text = "SĐT :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 295);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 7;
            label6.Text = "Giới tính :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 356);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 112);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 51);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã GV :";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // FormQLGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 805);
            Controls.Add(btnQuayLai);
            Controls.Add(dtgDSGV);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormQLGiangVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQLGiangVien";
            FormClosing += FormQLGiangVien_FormClosing;
            Load += FormQLGiangVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDSGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private DataGridView dtgDSGV;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnExit;
        private Button btnLogout;
        private RadioButton radNu;
        private RadioButton radNam;
        private TextBox txtSDT;
        private TextBox txtTen;
        private TextBox txtEmail;
        private RichTextBox rtbDiaChi;
        private TextBox txtMaGV;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private ErrorProvider err;
    }
}