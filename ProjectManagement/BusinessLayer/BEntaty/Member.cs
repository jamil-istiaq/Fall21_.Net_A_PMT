using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BEntaty
{
   public  class Member
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        //public string Password { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Credit { get; set; }
    }
}
