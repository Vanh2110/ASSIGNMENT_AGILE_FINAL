using DEMO_APP_LICH_HOC.Controller.Repository;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Service
{
    internal class LichHocService
    {
        LichHocRepository _repos;
        public LichHocService()
        {
            _repos = new LichHocRepository();
        }
        public List<LopHoc> GetLopHoc()
        {
            return _repos.GetLopHoc();
        }
        public List<LichHoc> GetLichHoc()
        {
            return _repos.GetLichHoc();
        }
        public void AddLichHoc(LichHoc lich)
        {
            if (_repos.AddLichHoc(lich))
            {
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateLichHoc(Guid? id, LichHoc lich)
        {
            if (_repos.UpdateLichHoc(id, lich))
            {
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Sửa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteLichHoc(Guid? id)
        {
            if (_repos.DeleteLichHoc(id))
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
