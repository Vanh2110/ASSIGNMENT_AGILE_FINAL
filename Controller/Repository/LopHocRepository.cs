using DEMO_APP_LICH_HOC.Model.Context;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Repository
{
    internal class LopHocRepository
    {
        DBContext _db;
        public LopHocRepository()
        {
            _db = new DBContext();  
        }
        public List<GiangVien> GetGiangVien()
        {
            return _db.GiangViens.ToList();
        }
        public List<LopHoc> GetLopHoc()
        {
            return _db.LopHocs.ToList();
        }
        public bool AddLopHoc(LopHoc lop)
        {
            if (lop == null)
            {
                return false;
            }
            lop.Id = Guid.NewGuid();
            _db.Add(lop);
            _db.SaveChanges();
            return true;
        }
    }
}
