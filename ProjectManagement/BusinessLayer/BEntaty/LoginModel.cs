using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BEntaty
{
    public class LoginModel
    {
      
        public int Id { get; set; }
        public string User_ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Work_domain { get; set; }
        public string Position { get; set; }
    }
}
