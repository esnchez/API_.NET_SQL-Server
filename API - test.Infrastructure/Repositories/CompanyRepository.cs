using API___test.Core.Entities;
using API___test.Core.Interfaces.IRepositories;
using API___test.Infrastructure.Data;

namespace API___test.Infrastructure.Repositories
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {

        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
                
        }
    }
}
