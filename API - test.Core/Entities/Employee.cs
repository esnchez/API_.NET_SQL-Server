using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API___test.Core.Entities
{
    public partial class Employee : BaseEntity
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string DNI { get; set; }

        public int Salary { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

    }
}
