using System;
using System.Collections.Generic;

namespace report1
{
    public partial class Departments
    {
        public Departments()
        {
            IrdeptsRelated = new HashSet<IrdeptsRelated>();
            Users = new HashSet<Users>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int? DeptMngId { get; set; }

        public virtual Users DeptMng { get; set; }
        public virtual ICollection<IrdeptsRelated> IrdeptsRelated { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
