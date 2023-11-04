using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftEd.Models.User
{
    public class UserRegister
    {
        public int Id { get; set; } 
        public string Name { get; set; }    

        public string Nickname { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }   
    }
}
