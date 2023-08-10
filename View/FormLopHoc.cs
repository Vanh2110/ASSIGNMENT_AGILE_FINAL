using DEMO_APP_LICH_HOC.Controller.Service;
using DEMO_APP_LICH_HOC.Model.DomainClass;
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
    public partial class FormLopHoc : Form
    {
        LopHocService _service = new LopHocService();
        List<Guid> _lstIdGiangVien = new List<Guid>();
        Guid? _idwc;
        bool isExit = true;
        public FormLopHoc()
        {
            InitializeComponent();
        }
        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadGrid();
        }
        public void LoadCombobox()
        {
            foreach (var item in _service.GetGiangVien())
            {
                _lstIdGiangVien.Add(item.Id);
                cmbxMaGiangVien.Items.Add(item.MaGiangVien);
            }
        }
        public void LoadGrid()
        {
            int stt = 1;
            dtgDSLopHoc.ColumnCount = 7;
            dtgDSLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDSLopHoc.Columns[0].Visible = false;
            dtgDSLopHoc.Columns[1].Name = "STT";
            dtgDSLopHoc.Columns[2].Name = "Mã lớp";
            dtgDSLopHoc.Columns[3].Name = "Môn học";
            dtgDSLopHoc.Columns[4].Name = "Mã giảng viên";
            dtgDSLopHoc.Columns[5].Name = "Ngày bắt đầu";
            dtgDSLopHoc.Columns[6].Name = "Ngày kết thúc";
            dtgDSLopHoc.Rows.Clear();
            foreach (var item in _service.GetLopHoc())
            {
                var result = _service.GetGiangVien().First(g => g.Id == item.IdGiangVien);
                dtgDSLopHoc.Rows.Add(item.Id, stt++, item.Ma, item.Ten, result.MaGiangVien,
                    item.NgayBatDau, item.NgayKetThuc);
            }
        }
        private void dtgDSLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            _idwc = Guid.Parse(dtgDSLopHoc.Rows[index].Cells[0].Value.ToString());
            var lop = _service.GetLopHoc().FirstOrDefault(g => g.Id == _idwc);
            txtMaLop.Text = lop.Ma;
            txtMonHoc.Text = lop.Ten;
            txtNgayBD.Text = lop.NgayBatDau.ToString();
            txtNgayKT.Text = lop.NgayKetThuc.ToString();

            int indexCombobox = _lstIdGiangVien.FindIndex(g => g == lop.IdGiangVien);
            cmbxMaGiangVien.SelectedIndex = indexCombobox;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHoc lop = new LopHoc();
            lop.Ma = txtMaLop.Text;
            lop.Ten = txtMonHoc.Text;
            lop.NgayBatDau = DateTime.Parse(txtNgayBD.Text);
            lop.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
            lop.IdGiangVien = _lstIdGiangVien[cmbxMaGiangVien.SelectedIndex];

            _service.AddLopHoc(lop);
            LoadGrid();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void btnQLTV_Click(object sender, EventArgs e)
        {
            FormThanhVienLop fTVL = new FormThanhVienLop();
            fTVL.Show();
            this.Hide();
        }
        private void FormLopHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQuanTriVien fQTV = new FormQuanTriVien();
            fQTV.Show();
            this.Hide();
        }
    }
}
