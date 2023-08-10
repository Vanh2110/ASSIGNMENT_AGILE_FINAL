using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_APP_LICH_HOC.View
{
    public partial class FormQuanTriVien : Form
    {
        bool isExit = true;
        public FormQuanTriVien()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit)
            {
                MessageBox.Show("Bạn muốn thoát khỏi chương trình không ?", "Thông báo ", MessageBoxButtons.YesNo);
                Application.Exit();
            }
        }
        private void btnQLSV_Click(object sender, EventArgs e)
        {
            FormQLSinhVien fQLSV = new FormQLSinhVien();
            fQLSV.Show();
            this.Hide();
        }
        private void btnQLGV_Click(object sender, EventArgs e)
        {
            FormQLGiangVien fQLGV = new FormQLGiangVien();
            fQLGV.Show();
            this.Hide();
        }
        private void btnQLLopHoc_Click(object sender, EventArgs e)
        {
            FormLopHoc fLopHoc = new FormLopHoc();
            fLopHoc.Show();
            this.Hide();
        }
        private void btnQLLichHoc_Click(object sender, EventArgs e)
        {
            FormQLLichHoc fLich = new FormQLLichHoc();
            fLich.Show();
            this.Hide();
        }
    }
}
