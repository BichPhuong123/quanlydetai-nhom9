using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWindows.Controller
{
    public class UserController
    {
        public static int getIDfromDB()
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var id = (from t in _context.USERS
                          select t.ID).ToList();
                if (id.Count <= 0)
                    return 0;
                else
                {

                    return id.Max();
                }

            }
        }
        public static USER getuser(string maUser,string pass)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var user = (from u in _context.USERS where u.MaUser == maUser&&u.Pass==pass select u).FirstOrDefault();

                
                return user;
            }
        }
        public static USER getUser(string maUser)
        {
            using (var _context = new QUANLYDOANEntities7())
            {
                var user = (from u in _context.USERS where u.MaUser == maUser select u).FirstOrDefault();


                return user;
            }
        }
        public static bool AddUser(USER user)
        {
            try
            {
                using (var _context = new QUANLYDOANEntities7())
                {
                    _context.USERS.Add(user);
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
