using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class Role
    {

        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        public bool isDeleted { get; set; }
    }
}
