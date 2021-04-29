using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace report1
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        public int RoleId { get; set; }
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
