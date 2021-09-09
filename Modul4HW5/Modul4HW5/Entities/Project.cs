using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class Project
    {
        public virtual int ProjectId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal BudGet { get; set; }
        public virtual DateTime StartedDate { get; set; }
        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();

        public virtual int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
