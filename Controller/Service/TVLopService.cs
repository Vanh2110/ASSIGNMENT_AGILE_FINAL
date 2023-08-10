using DEMO_APP_LICH_HOC.Controller.Repository;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Service
{
    internal class TVLopService
    {
        TVLopRepository _repos;
        public TVLopService()
        {
            _repos = new TVLopRepository(); 
        }
        public List<LopHoc> GetLopHoc()
        {
            return _repos.GetLopHoc();
        }
        public List<SinhVien> GetSinhVien()
        {
            return _repos.GetSinhVien();
        }
        public List<ThanhVienLop> GetTVLop()
        {
            return _repos.GetTVLop();
        }
        public void AddTVLop(ThanhVienLop tvl)
        {
            if (_repos.AddTVLop(tvl))
            {
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateTVLop(Guid? id, ThanhVienLop tvl)
        {
            if(_repos.UpdateTVLop(id, tvl))
            {
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Sửa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteTVLop(Guid? id)
        {
            if (_repos.DeleteTVLop(id))
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
