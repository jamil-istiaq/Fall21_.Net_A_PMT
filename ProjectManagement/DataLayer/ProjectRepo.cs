using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProjectRepo
    {
        static ProjectManagementEntities db;
        static ProjectRepo()
        {
            db = new ProjectManagementEntities();
        }
        public static List<C_Project> GetAll()
        {
            return db.C_Project.ToList();
        }
        public static List<C_Project> GetOpen()
        {
            return db.C_Project.ToList();
        }
        public static List<C_Project> GetComplete()
        {
            return db.C_Project.ToList();
        }
        public static List<C_Project> GetInpro()
        {
            return db.C_Project.ToList();
        }
        public static void Add(C_Project c)
        {
            db.C_Project.Add(c);
            db.SaveChanges();
        }

        public void Delete(C_Project e)
        {
            var n = db.C_Project.FirstOrDefault(en => en.Proj_Id == e.Proj_Id);
            db.C_Project.Remove(n);
            db.SaveChanges();
        }

        public void Edit(C_Project e)
        {
            var n = db.C_Project.FirstOrDefault(en => en.Proj_Id == e.Proj_Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public void StateProgress(int pId)
        {
            var entity = (from e in db.Apply_pro
                          where e.State == "Confirmed"
                          && e.Proj_Id == pId
                          select e).ToList();

            int count = entity.Count;

            var project = db.Apply_pro.FirstOrDefault(e => e.Proj_Id == pId);
            if (project.State == "Open" && count >= 3)
            {
                project.State = "In Progress";
                db.SaveChanges();
            }
        }

        public void StateCompleted(int pId)
        {
            var project = db.Apply_pro.FirstOrDefault(e => e.Proj_Id == pId);
            if (project.State == "In Progress")
            {
                project.State = "Completed";
                db.SaveChanges();
            }
        }
    }
}
