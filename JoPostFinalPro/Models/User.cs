using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
    }
}
