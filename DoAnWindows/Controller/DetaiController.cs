using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWindows.Controller
{
    public class DetaiController
    {
        public static bool AddDT(DETAI dt)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
               
                foreach (var sv in dt.SINHVIENs)
                {
                    var svdb = (from s in _context.SINHVIENs
                                where s.MaSV == sv.MaSV
                                select s).Single();
                    svdb.DETAIs.Add(dt);
                }
              
                dt.SINHVIENs.Clear();
               
                _context.DETAIs.AddOrUpdate(dt);
                _context.SaveChanges();
                return true;
            }

        }

        public static DETAI getDT(string maDT)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var dt = (from u in _context.DETAIs where u.MaDeTai == maDT select u).ToList();

                if (dt.Count == 1)
                {

                    return dt[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static DETAI getdt(string maDT)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var dt = (from u in _context.DETAIs where u.MaDeTai == maDT select u).FirstOrDefault();

                if (dt != null)
                {

                    
                    dt.SINHVIENs = dt.SINHVIENs;
                    

                    // _context.SaveChanges();
                }

                return dt;

            }
        }
        public static List<DETAI> getListDT()
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var dt = (from u in _context.DETAIs.AsEnumerable()
                            select u)
                           .Select(x => new DETAI
                           {
                               MaDeTai = x.MaDeTai,
                               TenDeTai = x.TenDeTai,
                               LoaiDeTai = x.LoaiDeTai,
                               TGBD = x.TGBD,
                               TGKT = x.TGKT,
                               Solan=x.Solan,
                               MaGV=x.MaGV,
                               SINHVIENs=x.SINHVIENs
                           }).ToList();

                return dt;
            }
        }
        public static List<DETAI> getListDT(string DTSearch)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var user = (from u in _context.DETAIs.AsEnumerable()
                            where u.MaDeTai.Contains(DTSearch)
                            select u)
                           .Select(x => new DETAI
                           {
                               MaDeTai = x.MaDeTai,
                               TenDeTai = x.TenDeTai,
                               LoaiDeTai = x.LoaiDeTai,
                               TGBD = x.TGBD,
                               TGKT = x.TGKT,
                               Solan = x.Solan,
                               MaGV = x.MaGV,
                               SINHVIENs = x.SINHVIENs
                           }).ToList();

                return user;
            }
        }
        public static bool UpdateGV(DETAI dt)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    var sdt = (from t in _context.DETAIs where t.MaDeTai == dt.MaDeTai select t).FirstOrDefault();
                    sdt.MaGV = dt.MaGV;
                    _context.SaveChanges();
                    return true;
                }
                   
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateDT(string madt,DETAI dt, List<SINHVIEN> listsv)
        {
            try
            {

                using (var _context = new QUANLYDOANEntities7())
                {
                    var sdt = (from t in _context.DETAIs where t.MaDeTai == madt select t).FirstOrDefault();
                    sdt.TenDeTai = dt.TenDeTai;
                    sdt.LoaiDeTai = dt.LoaiDeTai;
                    sdt.Solan = dt.Solan;
                    sdt.TGBD = dt.TGBD;
                    sdt.TGKT = dt.TGKT;

                    foreach (var sv in listsv)
                    {
                        
                        var svs = _context.SINHVIENs.Where(x => x.MaSV.Equals(sv.MaSV)).FirstOrDefault();
                        if (svs != null)
                            svs.DETAIs.Add(sdt);
                    }


                  //  _context.DETAIs.AddOrUpdate(sdt);
                    _context.SaveChanges();
                    return true;
                }
            }

            catch (Exception e)
            {
                return false;
            }

        }
        public static bool DeleteDT(string maDT)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {

                    
                    var dt = (from t in _context.DETAIs
                               where t.MaDeTai == maDT
                               select t).SingleOrDefault();
                   
                    dt.SINHVIENs.Clear();

                    _context.DETAIs.Remove(dt);
                    _context.SaveChanges();
                    return true;


                }
            }
            catch
            {
                return false;
            }
        }
    }
}
