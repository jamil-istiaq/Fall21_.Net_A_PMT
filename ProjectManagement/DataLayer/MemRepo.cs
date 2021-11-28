using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MemRepo
    {
        static ProjectManagementEntities db;
        static MemRepo()
        {
            db = new ProjectManagementEntities();
        }
        public static List<MemLogin> GetAll()
        {
            return db.MemLogins.ToList();
        }
        public static MemLogin GetLogin(string userid, string password)
        {
            return db.MemLogins.FirstOrDefault(e => e.User_Id == userid && e.Password == password);
        }
    }
}
