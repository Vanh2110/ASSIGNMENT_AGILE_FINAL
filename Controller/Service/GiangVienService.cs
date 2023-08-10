using DEMO_APP_LICH_HOC.Controller.Repository;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Service
{
    internal class GiangVienService
    {
        GiangVienRepository _repos;
        public GiangVienService()
        {
            _repos = new GiangVienRepository();
        }
        public List<GiangVien> GetGiangVien()
        {
            return _repos.GetGiangVien();
        }
        public void AddGiangVien(GiangVien gv)
        {
            if (_repos.AddGiangVien(gv))
            {
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateGiangVien(Guid? id, GiangVien gv)
        {
            if (_repos.UpdateGiangVien(id, gv))
            {
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Sửa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteGiangVien(Guid? id)
        {
            if (_repos.DeleteGiangVien(id))
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
