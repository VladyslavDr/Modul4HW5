using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class EmployeeProject
    {
        public virtual int EmployeeProjectId { get; set; }

        public virtual decimal Rate { get; set; }

        public virtual DateTime StartedDate { get; set; }

        public virtual int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
