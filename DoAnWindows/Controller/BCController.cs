using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWindows.Controller
{
    public class BCController
    {
        public static int getIDfromDB(string madt)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var id = (from t in _context.BAOCAOs
                          where t.MaDeTai == madt
                          select t.STT).ToList();
                if (id.Count <= 0)
                    return 0;
                else
                {

                    return id.Max();
                }

            }
        }
        public static bool AddBC(BAOCAO bc)
        {
            using (var _context = new QUANLYDOANEntities7())
            {

                _context.BAOCAOs.AddOrUpdate(bc);
                _context.SaveChanges();
                return true;
            }

        }
        public static BAOCAO getBC(int id, string madt)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var bc = (from u in _context.BAOCAOs where u.STT == id && u.MaDeTai == madt select u).ToList();

                if (bc.Count == 1)
                {

                    return bc[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<BAOCAO> getListBC(string madt)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var bc = (from u in _context.BAOCAOs.AsEnumerable()
                          where u.MaDeTai == madt
                          select u)
                           .Select(x => new BAOCAO
                           {
                               STT = x.STT,
                               NhanXet = x.NhanXet,
                               TaiLieu = x.TaiLieu,
                               MaDeTai = x.MaDeTai

                           }).ToList();

                return bc;
            }
        }
        public static bool UpdateBC(string madt, int id, BAOCAO bc)
        {
            try
            {

                using (var _context = new QUANLYDOANEntities7())
                {
                    var BC = (from t in _context.BAOCAOs where t.MaDeTai == madt && t.STT == id select t).FirstOrDefault();
                    BC.NhanXet = bc.NhanXet;
                    BC.TaiLieu = bc.TaiLieu;

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
