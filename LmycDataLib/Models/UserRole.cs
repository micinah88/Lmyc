using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.Models
{
    public class UserRole
    {
        [Key]
        [Display(Name ="Username")]
        public string UserName { get; set; }
        [Display(Name = "Role name")]
        public string RoleName { get; set; }
    }
}
