using DEMO_APP_LICH_HOC.Model.Context;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Repository
{
    internal class LichHocRepository
    {
        DBContext _db;
        public LichHocRepository()
        {
            _db = new DBContext();  
        }
        public List<LopHoc> GetLopHoc()
        {
            return _db.LopHocs.ToList();
        } 
        public List<LichHoc> GetLichHoc()
        {
            return _db.LichHocs.ToList();
        }
        public bool AddLichHoc(LichHoc lich)
        {
            if (lich == null)
            {
                return false;
            }
            lich.Id = Guid.NewGuid();
            _db.Add(lich);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateLichHoc(Guid? id, LichHoc lich)
        {
            if (lich == null)
            {
                return false;
            }
            var temp = _db.LichHocs.FirstOrDefault(g => g.Id == id);
            temp.IdLopHoc = lich.IdLopHoc;
            temp.NgayTrongTuan = lich.NgayTrongTuan;
            temp.Phong = lich.Phong;
            temp.GioBatDau = lich.GioBatDau;
            temp.GioKetThuc = lich.GioKetThuc;

            _db.Update(temp);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteLichHoc(Guid? id)
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
