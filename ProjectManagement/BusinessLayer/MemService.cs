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
    public class MemService
    {
        public static List<Member> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MemLogin, Member>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<Member>>(MemRepo.GetAll());
            
            return data;
        }
        public static Member GetLogin(string username, string password)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MemLogin, Member>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.MemberDataAcess();
            var data = mapper.Map<Member>(MemRepo.GetLogin(username, password));
            return data;
        }
    }
}
