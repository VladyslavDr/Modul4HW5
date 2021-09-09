using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiredData { get; set; }

        public DateTime DataOfBirth { get; set; }

        public int OfficeId { get; set; }
        public Office Office { get; set; }

        public int TitleId { get; set; }
        public Title Title { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
