using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ONTHI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Code" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Code.svc or Code.svc.cs at the Solution Explorer and start debugging.
    public class Code : ICode
    {
        DatabaseDataContext db = new DatabaseDataContext(); 
        // hiển thị lớp
       public List<Lop> HTLop()
        {
            return db.Lops.ToList();
        }
        // hiển thị phần tử lớp
        public List<HTLop> HTLop1()
        {
            return (
                from a in db.Lops
                select new HTLop
                {
                    TenLop = a.TenLop
                }
                ).ToList();
        }
        // hiển thị sinh viên
        public List<HTSV> HTSV()
        {
            return (
                from a in db.SinhViens
                from b in db.Lops
                where a.MaLop == b.MaLop
                select new HTSV
                {
                    MaSV = a.MaSV,
                    MaLop = a.MaLop,
                    TenSV = a.TenSV,
                    TenLop = b.TenLop,
                    GioiTinh = a.GioiTinh,
                    NgaySinh = a.NgaySinh,
                    DiaChi = a.DiaChi,
                    Sdt = a.Sdt
                }
                ).ToList();
        }
        // tìm kiếm sinh viên theo mã
        public List<TKSV> TKSV(int MaSV)
        {
            return (
               from a in db.SinhViens
               from b in db.Lops
               where a.MaLop == b.MaLop
               where a.MaSV == MaSV
               select new TKSV
               {
                   MaSV = a.MaSV,
                   TenSV = a.TenSV,
                   TenLop = b.TenLop,
                   GioiTinh = a.GioiTinh,
                   NgaySinh = a.NgaySinh,
                   DiaChi = a.DiaChi,
                   Sdt = a.Sdt
               }
               ).ToList();
        }
        // tìm kiếm lớp theo tên
        public List<TKL> TKL(string TenLop)
        {
            return (
               from a in db.Lops
               where a.TenLop.Contains(TenLop)
               select new TKL
               {
                   MaLop = a.MaLop,
                   TenLop = a.TenLop
                   
               }
               ).ToList();
        }
        // thêm lớp
        public bool ThemLop(string MaLop, string TenLop)
        {
            Lop lp = new Lop();
            lp.MaLop = MaLop;
            lp.TenLop = TenLop;
            try
            {
                db.Lops.InsertOnSubmit(lp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        // thêm sinh viên
        public bool ThemSV(int MaSV, string TenSV, DateTime NgaySinh, string GioiTinh, string DiaChi, string Sdt, string MaLop)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = MaSV;
            sv.TenSV = TenSV;
            sv.NgaySinh = NgaySinh;
            sv.GioiTinh = GioiTinh;
            sv.DiaChi = DiaChi;
            sv.Sdt = Sdt;
            sv.MaLop =MaLop;
            try
            {
                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<TKSVT> TKSVT(string TenSV)
        {
            return (
              from a in db.SinhViens
              from b in db.Lops
              where a.MaLop == b.MaLop
              where a.TenSV.Contains(TenSV)
              select new TKSVT
              {
                  MaSV = a.MaSV,
                  TenSV = a.TenSV,
                  TenLop = b.TenLop,
                  GioiTinh = a.GioiTinh,
                  NgaySinh = a.NgaySinh,
                  DiaChi = a.DiaChi,
                  Sdt = a.Sdt
              }
              ).ToList();
        }
        public bool XoaLop(string MaLop)
        {
            Lop lp = new Lop();
            lp = db.Lops.Single(x => x.MaLop == MaLop );
            try
            {
                db.Lops.DeleteOnSubmit(lp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaLop(string MaLop, string TenLop)
        {
            Lop lp = new Lop();
            lp = db.Lops.Single(x => x.MaLop == MaLop);     
            lp.TenLop = TenLop;
            try
            {         
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaSV(int MaSV, string TenSV, DateTime NgaySinh, string GioiTinh, string DiaChi, string Sdt, string MaLop)
        {
            SinhVien sv = new SinhVien();
            sv = db.SinhViens.Single(x => x.MaSV == MaSV);
            sv.TenSV = TenSV;
            sv.NgaySinh = NgaySinh;
            sv.GioiTinh = GioiTinh;
            sv.DiaChi = DiaChi;
            sv.Sdt = Sdt;
            sv.MaLop = MaLop;
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
