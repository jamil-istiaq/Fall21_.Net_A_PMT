using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
     public class ApplyRepo
    {
        static ProjectManagementEntities db;
        static ApplyRepo()
        {
            db = new ProjectManagementEntities();
        }

        public static void Add(Apply_pro c)
        {
            db.Apply_pro.Add(c);
            db.SaveChanges();
        }

      /*  public static void Change(Apply_pro c)
        {
            //db.Apply_pro.Change(c);
            db.SaveChanges();
        }*/

        public void Add(int pId, string mId)
        {
            var e = new Apply_pro();
            e.Proj_Id = pId;
            e.MemId = mId;
            e.State = "Applied";

            db.Apply_pro.Add(e);
            db.SaveChanges();
        }

        public void Confirm(int eId)
        {
            var enrollment = db.Apply_pro.FirstOrDefault(enr => enr.App_Id == eId);

            var project = db.Apply_pro.FirstOrDefault(pr => pr.Proj_Id == enrollment.Proj_Id);
            if (project.State == "Open")
            {
                
                enrollment.State = "Confirmed";
                db.SaveChanges();
            }
            else
            {
                
                enrollment.State = "Declined";
                db.SaveChanges();
            }
        }

        public void Decline(int eId)
        {
            var enrollment = db.Apply_pro.FirstOrDefault(enr => enr.App_Id == eId);
            enrollment.State = "Declined";
            db.SaveChanges();
        }

        public static List<Apply_pro> GetApply()
        {
            return db.Apply_pro.ToList();
        }
    }
}
