namespace DEMO_APP_LICH_HOC.View
{
    partial class FormThanhVienLop
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
            label5 = new Label();
            dtgSinhVien = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnNew = new Button();
            cmbxMaLop = new ComboBox();
            txtMaSV = new TextBox();
            txtTenSV = new TextBox();
            txtEmail = new TextBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dtgSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = SystemColors.MenuHighlight;
            btnQuayLai.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnQuayLai.ForeColor = SystemColors.HighlightText;
            btnQuayLai.Location = new Point(12, 12);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(101, 33);
            btnQuayLai.TabIndex = 29;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 186);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 25;
            label5.Text = "Email:";
            // 
            // dtgSinhVien
            // 
            dtgSinhVien.BackgroundColor = SystemColors.ActiveCaption;
            dtgSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSinhVien.Location = new Point(65, 285);
            dtgSinhVien.Name = "dtgSinhVien";
            dtgSinhVien.RowHeadersWidth = 51;
            dtgSinhVien.RowTemplate.Height = 29;
            dtgSinhVien.Size = new Size(956, 230);
            dtgSinhVien.TabIndex = 24;
            dtgSinhVien.CellClick += dtgSinhVien_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 124);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 18;
            label4.Text = "Tên SV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 186);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 17;
            label3.Text = "Mã SV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 128);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 16;
            label2.Text = "Mã lớp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(237, 52);
            label1.Name = "label1";
            label1.Size = new Size(338, 41);
            label1.TabIndex = 15;
            label1.Text = "Quản lý thành viên lớp";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(793, 186);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 55);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.MenuHighlight;
            btnNew.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.GreenYellow;
            btnNew.Location = new Point(793, 94);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(117, 59);
            btnNew.TabIndex = 30;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // cmbxMaLop
            // 
            cmbxMaLop.FormattingEnabled = true;
            cmbxMaLop.Location = new Point(152, 125);
            cmbxMaLop.Name = "cmbxMaLop";
            cmbxMaLop.Size = new Size(205, 28);
            cmbxMaLop.TabIndex = 34;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(152, 186);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(205, 27);
            txtMaSV.TabIndex = 38;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(497, 121);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(205, 27);
            txtTenSV.TabIndex = 39;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(497, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 27);
            txtEmail.TabIndex = 40;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // FormThanhVienLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 550);
            Controls.Add(txtEmail);
            Controls.Add(txtTenSV);
            Controls.Add(txtMaSV);
            Controls.Add(cmbxMaLop);
            Controls.Add(btnClear);
            Controls.Add(btnNew);
            Controls.Add(btnQuayLai);
            Controls.Add(label5);
            Controls.Add(dtgSinhVien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormThanhVienLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThanhVienLop";
            Load += FormThanhVienLop_Load;
            ((System.ComponentModel.ISupportInitialize)dtgSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private Label label5;
        private DataGridView dtgSinhVien;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button btnNew;
        private ComboBox cmbxMaLop;
        private TextBox txtMaSV;
        private TextBox txtTenSV;
        private TextBox txtEmail;
        private ErrorProvider err;
    }
}