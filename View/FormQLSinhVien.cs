using DEMO_APP_LICH_HOC.Controller.Service;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using DEMO_APP_LICH_HOC.View;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DEMO_APP_LICH_HOC
{
    public partial class FormQLSinhVien : Form
    {
        SinhVienService _service = new SinhVienService();
        Guid? _idwc;
        bool isExit = true;

        public FormQLSinhVien()
        {
            InitializeComponent();
        }
        private void FormQLSinhVien_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            int stt = 1;
            dtgDSSinhVien.ColumnCount = 8;
            dtgDSSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDSSinhVien.Columns[0].Visible = false;
            dtgDSSinhVien.Columns[1].Name = "STT";
            dtgDSSinhVien.Columns[2].Name = "Mã SV";
            dtgDSSinhVien.Columns[3].Name = "Họ tên";
            dtgDSSinhVien.Columns[4].Name = "Email";
            dtgDSSinhVien.Columns[5].Name = "SĐT";
            dtgDSSinhVien.Columns[6].Name = "Giới tính";
            dtgDSSinhVien.Columns[7].Name = "Địa chỉ";
            dtgDSSinhVien.Rows.Clear();
            foreach (var item in _service.GetSinhVien())
            {
                dtgDSSinhVien.Rows.Add(item.Id, stt++, item.MaSv, item.Ten,
                    item.Email, item.Sdt, (item.GioiTinh == true ? "Nam" : "Nữ"),
                    item.DiaChi);
            }
        }
        private void dtgDSSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            _idwc = Guid.Parse(dtgDSSinhVien.Rows[index].Cells[0].Value.ToString());
            var sv = _service.GetSinhVien().FirstOrDefault(g => g.Id == _idwc);
            txtMaSV.Text = sv.MaSv;
            txtTen.Text = sv.Ten;
            txtEmail.Text = sv.Email;
            txtSDT.Text = sv.Sdt;
            if (sv.GioiTinh == true)
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            rtbDiaChi.Text = sv.DiaChi;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                SinhVien sv = new SinhVien();
                sv.MaSv = txtMaSV.Text;
                sv.Ten = txtTen.Text;
                sv.Email = txtEmail.Text;
                sv.Sdt = txtSDT.Text;
                if (radNam.Checked)
                {
                    sv.GioiTinh = true;
                }
                else
                {
                    sv.GioiTinh = false;
                }
                sv.DiaChi = rtbDiaChi.Text;

                _service.AddSinhVien(sv);
            }
            LoadGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                SinhVien sv = new SinhVien();
                sv.MaSv = txtMaSV.Text;
                sv.Ten = txtTen.Text;
                sv.Email = txtEmail.Text;
                sv.Sdt = txtSDT.Text;
                if (radNam.Checked)
                {
                    sv.GioiTinh = true;
                }
                else
                {
                    sv.GioiTinh = false;
                }
                sv.DiaChi = rtbDiaChi.Text;

                _service.UpdateSinhVien(_idwc, sv);
            }
            LoadGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.DeleteSinhVien(_idwc);
            LoadGrid();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            radNam.Checked = true;
            radNu.Checked = false;
            rtbDiaChi.Text = string.Empty;
        }
        public bool CheckRegexText()
        {
            err.SetError(txtMaSV, "");
            err.SetError(txtTen, "");
            err.SetError(txtSDT, "");
            err.SetError(txtEmail, "");

            if (txtMaSV.Text.Length == 0)
            {
                err.SetError(txtMaSV, "Mã SV không được bỏ trống !");
                return false;
            }
            if (txtTen.Text.Length == 0)
            {
                err.SetError(txtTen, "Tên không được bỏ trống !");
                return false;
            }
            if (txtSDT.Text.Length == 0)
            {
                err.SetError(txtSDT, "SĐT không được bỏ trống !");
                return false;
            }
            else if (!Regex.IsMatch(txtSDT.Text, @"^[\d]+$"))
            {
                err.SetError(txtSDT, "Chỉ được nhập số");
                return false;
            }
            if (txtEmail.Text.Length == 0)
            {
                err.SetError(txtEmail, "Email không được bỏ trống !");
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[\w\d]+@fpt\.edu\.vn$"))
            {
                err.SetError(txtEmail, "Phải có @fpt.edu.vn");
                return false;
            }
            return true;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            FormDangNhap fDN = new FormDangNhap();
            fDN.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void FormQLSinhVien_FormClosing(object sender, FormClosingEventArgs e)
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