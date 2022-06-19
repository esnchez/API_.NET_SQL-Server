using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API___test.Core.Entities
{
    public partial class Team : BaseEntity
    {

        public Team()
        {
            this.Employees = new HashSet<Employee>();
        }
        public string Name { get; set; }

        public string Type { get; set; }

        public int CompanyId { get; set;  }

        public virtual Company Company { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}
