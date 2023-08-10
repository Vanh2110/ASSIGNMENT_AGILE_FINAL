using DEMO_APP_LICH_HOC.Model.Context;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Repository
{
    internal class TVLopRepository
    {
        DBContext _db;
        public TVLopRepository()
        {
            _db = new DBContext();
        }
        public List<LopHoc> GetLopHoc()
        {
            return _db.LopHocs.ToList();
        }
        public List<SinhVien> GetSinhVien()
        {
            return _db.SinhViens.ToList();
        }
        public List<ThanhVienLop> GetTVLop()
        {
            return _db.ThanhVienLops.ToList();
        }
        public bool AddTVLop(ThanhVienLop tvl)
        {
            if (tvl == null)
            {
                return false;
            }
            tvl.Id = Guid.NewGuid();
            _db.Add(tvl);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateTVLop(Guid? id, ThanhVienLop tvl)
        {
            if (tvl == null)
            {
                return false;
            }
            var temp = _db.ThanhVienLops.FirstOrDefault(g => g.Id == id);
            temp.IdLopHoc = tvl.Id;
            temp.IdSinhVien = tvl.IdSinhVien;

            _db.Update(temp);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteTVLop(Guid? id)
        {
            if (id == null)
            {
                return false;
            }
            _db.Remove(id);
            _db.SaveChanges();
            return true;
        }
    }
}
