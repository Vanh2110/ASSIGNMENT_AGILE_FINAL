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
    public partial class FormLichDayGV : Form
    {
        LichHocService _service = new LichHocService();
        bool isExit = true;
        public FormLichDayGV()
        {
            InitializeComponent();
        }
        private void FormLichDayGV_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            int stt = 1;
            dtgDSLichDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDSLichDay.ColumnCount = 7;
            dtgDSLichDay.Columns[0].Visible = false;
            dtgDSLichDay.Columns[1].Name = "STT";
            dtgDSLichDay.Columns[2].Name = "Lớp";
            dtgDSLichDay.Columns[3].Name = "Ngày trong tuần";
            dtgDSLichDay.Columns[4].Name = "Phòng";
            dtgDSLichDay.Columns[5].Name = "Giờ BĐ";
            dtgDSLichDay.Columns[6].Name = "Giờ KT";
            dtgDSLichDay.Rows.Clear();
            foreach (var item in _service.GetLichHoc())
            {
                var result = _service.GetLopHoc().First(g => g.Id == item.IdLopHoc);
                dtgDSLichDay.Rows.Add(item.Id, stt++, result.Ma,
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
        private void FormLichDayGV_FormClosing(object sender, FormClosingEventArgs e)
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
