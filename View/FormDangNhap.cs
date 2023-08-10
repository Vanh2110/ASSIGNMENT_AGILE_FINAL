using DEMO_APP_LICH_HOC.Controller.Service;
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
    public partial class FormDangNhap : Form
    {
        bool isExit = true;
        NguoiDungService _NDservice = new NguoiDungService();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TKDN = txtUser.Text;
            string MKDN = txtPass.Text;

            string loaiTK = _NDservice.KiemTraNguoiDung(TKDN, MKDN);


            if (loaiTK != null)
            {
                if (loaiTK.Equals("Quản trị viên"))
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo !");

                    FormQuanTriVien fQTV = new FormQuanTriVien();
                    fQTV.Show();
                    this.Hide();
                }
                else if (loaiTK.Equals("Giảng viên"))
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo !");

                    FormLichDayGV fGV = new FormLichDayGV();
                    fGV.Show();
                    this.Hide();
                }
                else if (loaiTK.Equals("Sinh viên"))
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo !");

                    FormLichHocSV fSV = new FormLichHocSV();
                    fSV.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
