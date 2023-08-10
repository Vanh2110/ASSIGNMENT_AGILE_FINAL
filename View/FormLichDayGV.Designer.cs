namespace DEMO_APP_LICH_HOC.View
{
    partial class FormLichDayGV
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
            groupBox1 = new GroupBox();
            dtgDSLichDay = new DataGridView();
            label1 = new Label();
            btnExit = new Button();
            btnLogout = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDSLichDay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgDSLichDay);
            groupBox1.Location = new Point(60, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 280);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch dạy ";
            // 
            // dtgDSLichDay
            // 
            dtgDSLichDay.BackgroundColor = SystemColors.ActiveCaption;
            dtgDSLichDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSLichDay.Dock = DockStyle.Fill;
            dtgDSLichDay.GridColor = SystemColors.ButtonHighlight;
            dtgDSLichDay.Location = new Point(3, 23);
            dtgDSLichDay.Name = "dtgDSLichDay";
            dtgDSLichDay.RowHeadersWidth = 51;
            dtgDSLichDay.RowTemplate.Height = 29;
            dtgDSLichDay.Size = new Size(675, 254);
            dtgDSLichDay.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(328, 45);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 2;
            label1.Text = "Giảng Viên";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(678, 418);
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
            btnLogout.Location = new Point(533, 418);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 57);
            btnLogout.TabIndex = 29;
            btnLogout.Text = "Log-out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormLichDayGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 487);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormLichDayGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLichDayGV";
            FormClosing += FormLichDayGV_FormClosing;
            Load += FormLichDayGV_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDSLichDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtgDSLichDay;
        private Label label1;
        private Button btnExit;
        private Button btnLogout;
    }
}