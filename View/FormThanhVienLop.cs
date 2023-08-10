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
    public partial class FormThanhVienLop : Form
    {
        TVLopService _service = new TVLopService();
        List<Guid> _lstIdLopHoc = new List<Guid>();
        List<Guid> _lstIdSinhVien = new List<Guid>();
        Guid? _idwc;
        public FormThanhVienLop()
        {
            InitializeComponent();
        }
        private void FormThanhVienLop_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadGrid();
        }
        public void LoadCombobox()
        {
            foreach (var item in _service.GetLopHoc())
            {
                _lstIdLopHoc.Add(item.Id);
                cmbxMaLop.Items.Add(item.Ma);
            }
        }
        public void LoadGrid()
        {
            int stt = 1;
            dtgSinhVien.ColumnCount = 6;
            dtgSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgSinhVien.Columns[0].Visible = false;
            dtgSinhVien.Columns[1].Name = "STT";
            dtgSinhVien.Columns[2].Name = "Mã lớp";
            dtgSinhVien.Columns[3].Name = "Tên";
            dtgSinhVien.Columns[4].Name = "Email";
            dtgSinhVien.Columns[5].Name = "Mã SV";
            dtgSinhVien.Rows.Clear();
            foreach (var item in _service.GetTVLop())
            {
                var x = _service.GetLopHoc().First(g => g.Id == item.IdLopHoc);
                var y = _service.GetSinhVien().First(g => g.Id == item.IdSinhVien);
                dtgSinhVien.Rows.Add(item.Id, stt++, x.Ma, y.Ten, y.Email, y.MaSv);
            }
        }
        private void dtgSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            _idwc = Guid.Parse(dtgSinhVien.Rows[index].Cells[0].Value.ToString());
            var tvl = _service.GetTVLop().FirstOrDefault(g => g.Id == _idwc);

            int indexCombobox = _lstIdLopHoc.FindIndex(g => g == tvl.IdLopHoc);
            cmbxMaLop.SelectedIndex = indexCombobox;

            var a = _service.GetSinhVien().FirstOrDefault(g => g.Id == tvl.IdSinhVien);
            txtMaSV.Text = a.MaSv;
            txtTenSV.Text = a.Ten;
            txtEmail.Text = a.Email;

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                ThanhVienLop tvl = new ThanhVienLop();
                tvl.IdLopHoc = _lstIdLopHoc[cmbxMaLop.SelectedIndex];
                _service.AddTVLop(tvl);
            }
            LoadGrid();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbxMaLop.SelectedItem = 0;
            txtMaSV.Text = string.Empty;
            txtTenSV.Text = string.Empty;
            txtEmail.Text = string.Empty;
            _idwc = null;
        }
        public bool CheckRegexText()
        {
            var a = _service.GetSinhVien().FirstOrDefault(g => g.MaSv == txtMaSV.Text);
            var b = _service.GetSinhVien().FirstOrDefault(g => g.Ten == txtTenSV.Text);
            var c = _service.GetSinhVien().FirstOrDefault(g => g.Email == txtEmail.Text);

            err.SetError(txtMaSV, "");
            err.SetError(txtTenSV, "");
            err.SetError(txtEmail, "");
            err.SetError(cmbxMaLop, "");
            if (txtTenSV.Text.Length == 0)
            {
                err.SetError(txtTenSV, "Không được bỏ trống !");
                return false;
            }
            if (b == null)
            {
                err.SetError(txtTenSV, "Không tồn tại tên sinh viên");
                return false;
            }

            if (txtMaSV.Text.Length == 0)
            {
                err.SetError(txtMaSV, "Không được bỏ trống !");
                return false;
            }
            if (a == null)
            {
                err.SetError(txtTenSV, "Không tồn tại mã sinh viên");
                return false;
            }

            if (txtEmail.Text.Length == 0)
            {
                err.SetError(txtEmail, "Không được bỏ trống !");
                return false;
            }
            if (c == null)
            {
                err.SetError(txtEmail, "Không tồn tại email");
                return false;
            }
            return true;
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormLopHoc fLop = new FormLopHoc();
            fLop.Show();
            this.Hide();
        }
    }
}
