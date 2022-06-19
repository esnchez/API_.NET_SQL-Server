using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API___test.Core.Entities

{
    public partial class Company : BaseEntity
    {
        public Company()
        {
            this.Teams = new HashSet<Team>();
        }

        public string Name { get; set; }

        public string Sector { get; set; }

        public string City { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

    }
}
