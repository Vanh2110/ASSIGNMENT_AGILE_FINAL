using DEMO_APP_LICH_HOC.Model.Context;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_APP_LICH_HOC.Controller.Repository
{
    internal class SinhVienRepository
    {
        DBContext _db;
        public SinhVienRepository()
        {
            _db = new DBContext();
        }
        public List<SinhVien> GetSinhVien()
        {
            return _db.SinhViens.ToList();
        }
        public bool AddSinhVien(SinhVien sv)
        {
            if (sv == null)
            {
                return false;
            }
            sv.Id = Guid.NewGuid();
            _db.Add(sv);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateSinhVien(Guid? id, SinhVien sv)
        {
            if (sv == null)
            {
                return false;
            }
            var temp = _db.SinhViens.FirstOrDefault(g => g.Id == id);
            temp.MaSv = sv.MaSv;
            temp.Ten = sv.Ten;
            temp.Email = sv.Email;
            temp.Sdt = sv.Sdt;
            temp.GioiTinh = sv.GioiTinh;
            temp.DiaChi = sv.DiaChi;

            _db.Update(temp);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteSinhVien(Guid? id)
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
