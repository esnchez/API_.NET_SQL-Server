using API___test.Core.Entities;
using API___test.Core.Interfaces.IRepositories;
using API___test.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API___test.Infrastructure.Repositories
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationDbContext context) : base(context)
        {
                
        }
    }
}
