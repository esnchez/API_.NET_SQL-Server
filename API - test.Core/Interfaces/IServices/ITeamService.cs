using API___test.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace API___test.Core.Services
{
    public interface ITeamService
    {
        //Task<IEnumerable<Team>> GetAll(int id);
        List<Team> GetWhere(int id);

    }
}