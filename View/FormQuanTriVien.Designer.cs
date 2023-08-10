namespace DEMO_APP_LICH_HOC.View
{
    partial class FormQuanTriVien
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
            btnExit = new Button();
            btnLogout = new Button();
            label1 = new Label();
            btnQLLopHoc = new Button();
            btnQLGV = new Button();
            btnQLSV = new Button();
            btnQLLichHoc = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(666, 455);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 57);
            btnExit.TabIndex = 30;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OliveDrab;
            btnLogout.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Gold;
            btnLogout.Location = new Point(519, 455);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 57);
            btnLogout.TabIndex = 29;
            btnLogout.Text = "Log-out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(292, 45);
            label1.Name = "label1";
            label1.Size = new Size(176, 33);
            label1.TabIndex = 28;
            label1.Text = "Quản Trị Viên";
            // 
            // btnQLLopHoc
            // 
            btnQLLopHoc.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLLopHoc.Location = new Point(406, 137);
            btnQLLopHoc.Name = "btnQLLopHoc";
            btnQLLopHoc.Size = new Size(178, 60);
            btnQLLopHoc.TabIndex = 27;
            btnQLLopHoc.Text = "Quản lý lớp học ";
            btnQLLopHoc.UseVisualStyleBackColor = true;
            btnQLLopHoc.Click += btnQLLopHoc_Click;
            // 
            // btnQLGV
            // 
            btnQLGV.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLGV.Location = new Point(148, 273);
            btnQLGV.Name = "btnQLGV";
            btnQLGV.Size = new Size(178, 60);
            btnQLGV.TabIndex = 26;
            btnQLGV.Text = "Quản lý Giảng Viên";
            btnQLGV.UseVisualStyleBackColor = true;
            btnQLGV.Click += btnQLGV_Click;
            // 
            // btnQLSV
            // 
            btnQLSV.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLSV.Location = new Point(148, 137);
            btnQLSV.Name = "btnQLSV";
            btnQLSV.Size = new Size(178, 60);
            btnQLSV.TabIndex = 25;
            btnQLSV.Text = "Quản lý Sinh Viên";
            btnQLSV.UseVisualStyleBackColor = true;
            btnQLSV.Click += btnQLSV_Click;
            // 
            // btnQLLichHoc
            // 
            btnQLLichHoc.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLLichHoc.Location = new Point(406, 273);
            btnQLLichHoc.Name = "btnQLLichHoc";
            btnQLLichHoc.Size = new Size(178, 60);
            btnQLLichHoc.TabIndex = 31;
            btnQLLichHoc.Text = "Quản lý lịch học";
            btnQLLichHoc.UseVisualStyleBackColor = true;
            btnQLLichHoc.Click += btnQLLichHoc_Click;
            // 
            // FormQuanTriVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 524);
            Controls.Add(btnQLLichHoc);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(btnQLLopHoc);
            Controls.Add(btnQLGV);
            Controls.Add(btnQLSV);
            Name = "FormQuanTriVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanTriVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnLogout;
        private Label label1;
        private Button btnQLLopHoc;
        private Button btnQLGV;
        private Button btnQLSV;
        private Button btnQLLichHoc;
    }
}