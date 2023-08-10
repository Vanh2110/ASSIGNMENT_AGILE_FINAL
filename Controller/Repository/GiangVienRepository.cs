using DEMO_APP_LICH_HOC.Model.Context;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Repository
{
    internal class GiangVienRepository
    {
        DBContext _db;
        public GiangVienRepository()
        {
            _db = new DBContext();  
        }
        public List<GiangVien> GetGiangVien()
        {
            return _db.GiangViens.ToList();
        }
        public bool AddGiangVien(GiangVien gv)
        {
            if (gv == null)
            {
                return false;
            }
            gv.Id = Guid.NewGuid(); 
            _db.Add(gv);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateGiangVien(Guid? id, GiangVien gv)
        {
            if (gv == null)
            {
                return false;
            }
            var temp = _db.GiangViens.FirstOrDefault(g => g.Id == id);
            temp.MaGiangVien = gv.MaGiangVien;
            temp.Ten = gv.Ten;
            temp.Email = gv.Email;
            temp.Sdt = gv.Sdt;
            temp.GioiTinh = gv.GioiTinh;
            temp.DiaChi = gv.DiaChi;
            _db.Update(temp);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteGiangVien(Guid? id)
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
