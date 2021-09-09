using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class Employee
    {
        public virtual int EmployeeId { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual DateTime HiredData { get; set; }

        public virtual DateTime DataOfBirth { get; set; }

        public virtual int OfficeId { get; set; }
        public virtual Office Office { get; set; }

        public virtual int TitleId { get; set; }
        public virtual Title Title { get; set; }

        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
