using System;
using System.Collections.Generic;

namespace report1
{
    public partial class IncidentReport
    {
        public IncidentReport()
        {
            IrdeptsRelated = new HashSet<IrdeptsRelated>();
        }

        public int Irid { get; set; }
        public int IrcreaterId { get; set; }
        public bool IsComplete { get; set; }
        public int? IrrelatedDept { get; set; }
        public DateTime? IrstartDate { get; set; }
        public DateTime? IrcompleteDate { get; set; }
        public int? IrformId { get; set; }

        public virtual Users Ircreater { get; set; }
        public virtual Irform Irform { get; set; }
        public virtual ICollection<IrdeptsRelated> IrdeptsRelated { get; set; }
    }
}
