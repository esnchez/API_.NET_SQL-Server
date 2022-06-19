using API___test.Core.Entities;
using API___test.Core.Interfaces.IServices;
using API___test.Core.Interfaces.IRepositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API___test.Core.Services
{
    public class CompanyService : ICompanyService

    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            return await _companyRepository.GetAll();

        }
    }
}
