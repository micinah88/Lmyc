using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
