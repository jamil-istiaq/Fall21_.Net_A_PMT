using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SupLoginRepo
    {
        static ProjectManagementEntities db;
        static SupLoginRepo()
        {
            db = new ProjectManagementEntities();
        }
        public static List<SupLogin> GetAll()
        {
            return db.SupLogins.ToList();
        }

        public static object GetLogin(string userId, string password)
        {
            return db.SupLogins.FirstOrDefault(e => e.User_ID == userId && e.Password == password);
        }
    }
}
