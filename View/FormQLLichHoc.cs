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
    public partial class FormQLLichHoc : Form
    {
        LichHocService _service = new LichHocService();
        List<Guid> _lstIdLopHoc = new List<Guid>();
        Guid? _idwc;
        bool isExit = true;
        public FormQLLichHoc()
        {
            InitializeComponent();
        }
        private void FormLichHoc_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadGrid();
        }
        public void LoadCombobox()
        {
            cmbxNgayTrongTuan.Items.Add("Thứ 2 - 4 - 6");
            cmbxNgayTrongTuan.Items.Add("Thứ 3 - 5 - 7");
            cmbxNgayTrongTuan.SelectedIndex = 0;
            foreach (var item in _service.GetLopHoc())
            {
                _lstIdLopHoc.Add(item.Id);
                cmbxLop.Items.Add(item.Ma);
            }
            cmbxLop.SelectedIndex = 0;
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
        private void dtgDSLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            _idwc = Guid.Parse(dtgDSLichHoc.Rows[index].Cells[0].Value.ToString());
            var lich = _service.GetLichHoc().FirstOrDefault(g => g.Id == _idwc);
            txtPhongHoc.Text = lich.Phong;
            txtGioBD.Text = lich.GioBatDau;
            txtGioKT.Text = lich.GioKetThuc;
            cmbxNgayTrongTuan.SelectedItem = lich.NgayTrongTuan;
            int indexCombobox = _lstIdLopHoc.FindIndex(g => g == lich.IdLopHoc);
            cmbxLop.SelectedIndex = indexCombobox;
        }
        public bool CheckRegexText()
        {
            err.SetError(cmbxLop, "");
            err.SetError(cmbxNgayTrongTuan, "");
            err.SetError(txtPhongHoc, "");
            err.SetError(txtGioBD, "");
            err.SetError(txtGioKT, "");

            if (txtPhongHoc.Text.Length == 0)
            {
                err.SetError(txtPhongHoc, "Không được bỏ trống");
                return false;
            }
            if (txtGioBD.Text.Length == 0)
            {
                err.SetError(txtGioBD, "Không được bỏ trống");
                return false;
            }
            if (txtGioKT.Text.Length == 0)
            {
                err.SetError(txtGioKT, "Không được bỏ trống");
                return false;
            }
            return true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                LichHoc lich = new LichHoc();
                lich.Phong = txtPhongHoc.Text;
                lich.GioBatDau = txtGioBD.Text;
                lich.GioKetThuc = txtGioKT.Text;
                lich.NgayTrongTuan = cmbxNgayTrongTuan.SelectedItem.ToString();
                lich.IdLopHoc = _lstIdLopHoc[cmbxLop.SelectedIndex];
                _service.AddLichHoc(lich);
            }
            LoadGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                LichHoc lich = new LichHoc();
                lich.Phong = txtPhongHoc.Text;
                lich.GioBatDau = txtGioBD.Text;
                lich.GioKetThuc = txtGioKT.Text;
                lich.NgayTrongTuan = cmbxNgayTrongTuan.SelectedItem.ToString();
                lich.IdLopHoc = _lstIdLopHoc[cmbxLop.SelectedIndex];
                _service.UpdateLichHoc(_idwc, lich);
            }
            LoadGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.DeleteLichHoc(_idwc);
            LoadGrid();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbxLop.SelectedIndex = 0;
            cmbxNgayTrongTuan.SelectedIndex = 0;
            txtPhongHoc.Text = string.Empty;
            txtGioBD.Text = string.Empty;
            txtGioKT.Text = string.Empty;
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQuanTriVien fQTV = new FormQuanTriVien();
            fQTV.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit = true)
            {
                Application.Exit();
            }
        }
        private void FormQLLichHoc_FormClosing(object sender, FormClosingEventArgs e)
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
