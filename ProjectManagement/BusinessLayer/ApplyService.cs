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
    public class ApplyService
    {
        public static void Add(ApplyModel e)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ApplyModel, Apply_pro>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Apply_pro>(e);
            ApplyRepo.Add(data);
        }

        /* public static List<ApplyModel> GetOpen()
         {
             var config = new MapperConfiguration(c =>
             {
                 c.CreateMap<Apply_pro, ApplyModel>();
             });

             var mapper = new Mapper(config);
             var data = mapper.Map<List<ApplyModel>>(ApplyRepo.GetOpen());
             var data = (from v in data where v.State == "Open" select v).ToList();

             return data;
         }*/
        public static List<ApplyModel>GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Apply_pro, ApplyModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ApplyModel>>(ApplyRepo.GetApply());
            var data1= (from num in data
                        where num.Proj_Id== 1
                        select num.Proj_Id).Count();
            if (data1 <= 3)
            {

            }

            return data;
        }
    }
}
