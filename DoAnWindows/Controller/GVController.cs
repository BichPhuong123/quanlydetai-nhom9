using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWindows.Controller
{
    public class GVController
    {
        public static bool AddGV(GIAOVIEN gv)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    _context.GIAOVIENs.Add(gv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }
        public static GIAOVIEN getGV(string maGV)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var gv = (from u in _context.GIAOVIENs where u.MaGV == maGV select u).ToList();
                
                if (gv.Count == 1)
                {

                    return gv[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static GIAOVIEN getgv(string maGV)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var gv = (from u in _context.GIAOVIENs where u.MaGV == maGV select u).FirstOrDefault();
                if (gv != null )
                {
                    
                    gv.DETAIs = gv.DETAIs;
                    gv.SINHVIENs = gv.SINHVIENs;
                    foreach (DETAI DT in gv.DETAIs)
                    {
                        foreach (SINHVIEN s in DT.SINHVIENs)
                        {
                            DT.SINHVIENs = DT.SINHVIENs;
                        }
                    }
                    
                   // _context.SaveChanges();
                }

                return gv;
                
            }
        }
        public static List<GIAOVIEN> getListGV()
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var gv = (from u in _context.GIAOVIENs.AsEnumerable()                          
                          select u)
                           .Select(x => new GIAOVIEN
                           {
                               MaGV = x.MaGV,
                               HoTen = x.HoTen,
                               Ngaysinh = x.Ngaysinh,
                               Phai = x.Phai,
                               Email = x.Email,
                               SDT = x.SDT,
                               DETAIs=x.DETAIs
                           }).ToList();

                return gv;
            }
        }
        public static List<GIAOVIEN> getListGV(string GVsearch)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var gv = (from u in _context.GIAOVIENs.AsEnumerable()
                            where u.MaGV.Contains(GVsearch)
                            select u)
                           .Select(x => new GIAOVIEN
                           {
                               MaGV = x.MaGV,
                               HoTen = x.HoTen,
                               Ngaysinh = x.Ngaysinh,
                               Phai = x.Phai,
                               Email = x.Email,
                               SDT = x.SDT
                           }).ToList();

                return gv;
            }
        }
        public static bool UpdateGV(GIAOVIEN gv)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    _context.GIAOVIENs.AddOrUpdate(gv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }
        public static bool DeleteGV(GIAOVIEN gv)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    var dbGV = (from u in _context.GIAOVIENs
                                  where u.MaGV == gv.MaGV
                                  select u).SingleOrDefault();
                    foreach(var detai in dbGV.DETAIs)
                    {
                        if(detai.MaGV==dbGV.MaGV)
                        {
                            detai.MaGV = null;
                           
                            _context.DETAIs.AddOrUpdate(detai);
                            _context.SaveChanges();
                            break;
                        }
                    }
                    _context.GIAOVIENs.Remove(dbGV);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {

                return false;
            }
        }
    }
}
