using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Entities
{
    public class Title
    {
        public virtual int TitleId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Employee> Employes { get; set; } = new List<Employee>();
    }
}
