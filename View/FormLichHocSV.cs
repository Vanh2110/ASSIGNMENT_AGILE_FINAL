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
    public partial class FormLichHocSV : Form
    {
        LichHocService _service = new LichHocService();
        bool isExit = true;
        public FormLichHocSV()
        {
            InitializeComponent();
        }
        private void FormLichHocSV_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            int stt = 1;
            dtgDSLichHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDSLichHoc.ColumnCount = 7;
            dtgDSLichHoc.Columns[0].Visible = false;
            dtgDSLichHoc.Columns[1].Name = "STT";
            dtgDSLichHoc.Columns[2].Name = "Lớp";
            dtgDSLichHoc.Columns[3].Name = "Ngày trong tuần";
            dtgDSLichHoc.Columns[4].Name = "Phòng";
            dtgDSLichHoc.Columns[5].Name = "Giờ BĐ";
            dtgDSLichHoc.Columns[6].Name = "Giờ KT";
            dtgDSLichHoc.Rows.Clear();
            foreach (var item in _service.GetLichHoc())
            {
                var result = _service.GetLopHoc().First(g => g.Id == item.IdLopHoc);
                dtgDSLichHoc.Rows.Add(item.Id, stt++, result.Ma,
                    (item.NgayTrongTuan), item.Phong, item.GioBatDau,
                    item.GioKetThuc);
            }
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
                Application.Exit();
        }
        private void FormLichHocSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
