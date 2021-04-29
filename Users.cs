using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace report1
{
    public partial class Users
    {
        public Users()
        {
            Departments = new HashSet<Departments>();
            IncidentReport = new HashSet<IncidentReport>();
        }

        public int UserId { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Department { get; set; }
        public int Role { get; set; }

        public virtual Departments DepartmentNavigation { get; set; }
        public virtual Roles RoleNavigation { get; set; }
        public virtual ICollection<Departments> Departments { get; set; }
        public virtual ICollection<IncidentReport> IncidentReport { get; set; }
    }
}
