using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DataOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
