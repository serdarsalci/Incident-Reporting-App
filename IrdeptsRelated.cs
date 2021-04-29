using System;
using System.Collections.Generic;

namespace report1
{
    public partial class IrdeptsRelated
    {
        public int IrdeptsRelated1 { get; set; }
        public int Irdetails { get; set; }
        public int DeptRelated { get; set; }

        public virtual Departments DeptRelatedNavigation { get; set; }
        public virtual IncidentReport IrdetailsNavigation { get; set; }
    }
}
