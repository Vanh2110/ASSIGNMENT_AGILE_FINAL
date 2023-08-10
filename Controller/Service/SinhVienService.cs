using DEMO_APP_LICH_HOC.Controller.Repository;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Service
{
    internal class SinhVienService
    {
        SinhVienRepository _repos;
        public SinhVienService()
        {
            _repos = new SinhVienRepository();
        }
        public List<SinhVien> GetSinhVien()
        {
            return _repos.GetSinhVien();
        }
        public void AddSinhVien(SinhVien sv)
        {
            if (_repos.AddSinhVien(sv))
            {
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateSinhVien(Guid? id, SinhVien sv)
        {
            if (_repos.UpdateSinhVien(id, sv))
            {
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Sửa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteSinhVien(Guid? id)
        {
            if (_repos.DeleteSinhVien(id))
            {
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
