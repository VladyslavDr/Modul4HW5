using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class Client
    {
        public virtual int ClientId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime DataOfBirth { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual List<Project> Projects { get; set; } = new List<Project>();
    }
}
