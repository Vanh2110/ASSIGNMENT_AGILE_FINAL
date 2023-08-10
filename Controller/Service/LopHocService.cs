using DEMO_APP_LICH_HOC.Controller.Repository;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Service
{
    internal class LopHocService
    {
        LopHocRepository _repos;
        public LopHocService()
        {
            _repos = new LopHocRepository();
        }
        public List<GiangVien> GetGiangVien()
        {
            return _repos.GetGiangVien();
        }
        public List<LopHoc> GetLopHoc()
        {
            return _repos.GetLopHoc();
        }
        public void AddLopHoc(LopHoc lop)
        {
            if (_repos.AddLopHoc(lop))
            {
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
