using API___test.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API___test.Core.Interfaces.IServices
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAll();

    }
}
