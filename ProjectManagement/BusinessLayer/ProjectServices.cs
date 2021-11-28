using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.BEntaty;
using DataLayer;

namespace BusinessLayer
{
    public class ProjectServices
    {
        public static List<ProjectModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<C_Project, ProjectModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProjectModel>>(ProjectRepo.GetAll());

            return data;
        }

        public static List<ProjectModel> GetOpen()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<C_Project, ProjectModel>();
            });
            
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProjectModel>>(ProjectRepo.GetOpen());
            var data1 = (from v in data where v.State=="Open" select v ).ToList();
            
            return data1;
        }

        public static List<ProjectModel> GetComplete()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<C_Project, ProjectModel>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProjectModel>>(ProjectRepo.GetComplete());
            var data1 = (from v in data where v.State == "Complete" select v).ToList();

            return data1;
        }
        public static List<ProjectModel> GetInpro()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<C_Project, ProjectModel>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProjectModel>>(ProjectRepo.GetInpro());
            var data1 = (from v in data where v.State == "In process" select v).ToList();

            return data1;
        }
        public static void Add(ProjectModel e)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProjectModel, C_Project>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<C_Project>(e);
            ProjectRepo.Add(data);
        }
    }
}
