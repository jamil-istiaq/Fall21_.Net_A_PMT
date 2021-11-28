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
    public class SupService
    {
        public static List<Supervisor> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SupLogin, Supervisor>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<Supervisor>>(SupLoginRepo.GetAll());

            return data;
        }

        public static Supervisor GetLogin(string userId, string password)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SupLogin, Supervisor>();
            });
            var mapper = new Mapper(config);
            
            var data = mapper.Map<Supervisor>(SupLoginRepo.GetLogin(userId, password));
            return data;
        }
    }
}
