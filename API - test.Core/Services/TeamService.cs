using API___test.Core.Entities;
using API___test.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API___test.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public List<Team> GetWhere(int id)
        {
            List<Team> selectedTeams = (_teamRepository.FindAsync(x => x.CompanyId == id)).ToList();
            return selectedTeams;
        }

    }
}
