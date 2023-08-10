﻿using DEMO_APP_LICH_HOC.Controller.Service;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_APP_LICH_HOC.View
{
    public partial class FormQLGiangVien : Form
    {
        GiangVienService _service = new GiangVienService();
        Guid? _idwc;
        bool isExit = true;
        public FormQLGiangVien()
        {
            InitializeComponent();
        }

        private void FormQLGiangVien_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            int stt = 1;
            dtgDSGV.ColumnCount = 8;
            dtgDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDSGV.Columns[0].Visible = false;
            dtgDSGV.Columns[1].Name = "STT";
            dtgDSGV.Columns[2].Name = "Mã GV";
            dtgDSGV.Columns[3].Name = "Họ tên";
            dtgDSGV.Columns[4].Name = "Email";
            dtgDSGV.Columns[5].Name = "SĐT";
            dtgDSGV.Columns[6].Name = "Giới tính";
            dtgDSGV.Columns[7].Name = "Địa chỉ";
            dtgDSGV.Rows.Clear();
            foreach (var item in _service.GetGiangVien())
            {
                dtgDSGV.Rows.Add(item.Id, stt++, item.MaGiangVien, item.Ten,
                    item.Email, item.Sdt, (item.GioiTinh == true ? "Nam" : "Nữ"),
                    item.DiaChi);
            }
        }
        private void dtgDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            _idwc = Guid.Parse(dtgDSGV.Rows[index].Cells[0].Value.ToString());
            var sv = _service.GetGiangVien().FirstOrDefault(g => g.Id == _idwc);
            txtMaGV.Text = sv.MaGiangVien;
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
                GiangVien gv = new GiangVien();
                gv.MaGiangVien = txtMaGV.Text;
                gv.Ten = txtTen.Text;
                gv.Email = txtEmail.Text;
                gv.Sdt = txtSDT.Text;
                if (radNam.Checked)
                {
                    gv.GioiTinh = true;
                }
                else
                {
                    gv.GioiTinh = false;
                }
                gv.DiaChi = rtbDiaChi.Text;

                _service.AddGiangVien(gv);
            }
            LoadGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                GiangVien gv = new GiangVien();
                gv.MaGiangVien = txtMaGV.Text;
                gv.Ten = txtTen.Text;
                gv.Email = txtEmail.Text;
                gv.Sdt = txtSDT.Text;
                if (radNam.Checked)
                {
                    gv.GioiTinh = true;
                }
                else
                {
                    gv.GioiTinh = false;
                }
                gv.DiaChi = rtbDiaChi.Text;

                _service.UpdateGiangVien(_idwc, gv);
            }
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.DeleteGiangVien(_idwc);
            LoadGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            radNam.Checked = true;
            rtbDiaChi.Text = string.Empty;
        }
        public bool CheckRegexText()
        {
            err.SetError(txtMaGV, "");
            err.SetError(txtTen, "");
            err.SetError(txtSDT, "");
            err.SetError(txtEmail, "");

            if (txtMaGV.Text.Length == 0)
            {
                err.SetError(txtMaGV, "Mã GV không được bỏ trống !");
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
            fDN.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void FormQLGiangVien_FormClosing(object sender, FormClosingEventArgs e)
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
