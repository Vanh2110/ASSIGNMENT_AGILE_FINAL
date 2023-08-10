namespace DEMO_APP_LICH_HOC.View
{
    partial class FormLichHocSV
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
            groupBox1 = new GroupBox();
            dtgDSLichHoc = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDSLichHoc).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(651, 383);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 57);
            btnExit.TabIndex = 34;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OliveDrab;
            btnLogout.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Gold;
            btnLogout.Location = new Point(506, 383);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 57);
            btnLogout.TabIndex = 33;
            btnLogout.Text = "Log-out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgDSLichHoc);
            groupBox1.Location = new Point(33, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 280);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch học  ";
            // 
            // dtgDSLichHoc
            // 
            dtgDSLichHoc.BackgroundColor = SystemColors.ActiveCaption;
            dtgDSLichHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSLichHoc.Dock = DockStyle.Fill;
            dtgDSLichHoc.GridColor = SystemColors.ButtonHighlight;
            dtgDSLichHoc.Location = new Point(3, 23);
            dtgDSLichHoc.Name = "dtgDSLichHoc";
            dtgDSLichHoc.RowHeadersWidth = 51;
            dtgDSLichHoc.RowTemplate.Height = 29;
            dtgDSLichHoc.Size = new Size(675, 254);
            dtgDSLichHoc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(301, 10);
            label1.Name = "label1";
            label1.Size = new Size(126, 33);
            label1.TabIndex = 31;
            label1.Text = "Sinh Viên";
            // 
            // FormLichHocSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormLichHocSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLichHocSV";
            FormClosing += FormLichHocSV_FormClosing;
            Load += FormLichHocSV_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDSLichHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnLogout;
        private GroupBox groupBox1;
        private DataGridView dtgDSLichHoc;
        private Label label1;
    }
}