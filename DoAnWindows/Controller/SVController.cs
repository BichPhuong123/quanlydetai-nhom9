using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWindows.Controller
{
    public class SVController
    {
        public static bool AddSV(SINHVIEN sv)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    _context.SINHVIENs.Add(sv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }
        public static SINHVIEN getSV(string maSV)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var sv = (from u in _context.SINHVIENs where u.MaSV == maSV select u).ToList();
                
                if (sv.Count == 1)
                {

                    return sv[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static SINHVIEN getsv(string maSV)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var sv = (from u in _context.SINHVIENs where u.MaSV == maSV select u).FirstOrDefault();
        
                if (sv != null)
                {
                    sv.DETAIs = sv.DETAIs;
                    sv.GIAOVIENs = sv.GIAOVIENs;
                    

                    // _context.SaveChanges();
                }

                return sv;
            }
        }
        public static List<SINHVIEN> getListSV()
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var sv = (from u in _context.SINHVIENs.AsEnumerable()
                            select u)
                           .Select(x => new SINHVIEN
                           {
                               MaSV = x.MaSV,
                               HoTen = x.HoTen,
                               Gioitinh = x.Gioitinh,
                               Ngaysinh = x.Ngaysinh,
                               SDT=x.SDT,
                               Email=x.Email,
                               Picture = x.Picture,
                               DETAIs = x.DETAIs,
                               GIAOVIENs=x.GIAOVIENs
                           }).ToList();

                return sv;
            }
        }
        public static List<SINHVIEN> getListSV(string SVsearch)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var sv = (from u in _context.SINHVIENs.AsEnumerable()
                          where u.MaSV.Contains(SVsearch)
                          select u)
                           .Select(x => new SINHVIEN
                           {
                               MaSV = x.MaSV,
                               HoTen = x.HoTen,
                               Ngaysinh = x.Ngaysinh,
                               Gioitinh = x.Gioitinh,
                               Email = x.Email,
                               SDT = x.SDT
                           }).ToList();

                return sv;
            }
        }
        public static bool UpdateSV(SINHVIEN sv)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    _context.SINHVIENs.AddOrUpdate(sv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }
        public static bool DeleteSV(SINHVIEN sv)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    var dbSV = (from u in _context.SINHVIENs
                                where u.MaSV == sv.MaSV
                                select u).SingleOrDefault();
                    foreach (var detai in dbSV.DETAIs)
                    {
                        foreach (var u in detai.SINHVIENs)
                        {
                            if (u.MaSV == dbSV.MaSV)
                            {
                                detai.SINHVIENs.Remove(u);
                                break;
                            }
                        }
                    }
                    _context.SINHVIENs.Remove(dbSV);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}
