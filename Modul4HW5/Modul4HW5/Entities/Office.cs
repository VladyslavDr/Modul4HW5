using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class Office
    {
        public virtual int OfficeId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Location { get; set; }
        public virtual List<Employee> Employes { get; set; } = new List<Employee>();
    }
}
