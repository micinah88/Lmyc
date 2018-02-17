using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LmycWebSite.Models
{
    public class GroupedUserViewModel
    {
        public List<UserViewModel> Members { get; set; }
        public List<UserViewModel> Admins { get; set; }
    }

    public class UserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}