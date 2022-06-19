using API___test.Core.DTOs;
using API___test.Core.Interfaces.IServices;
using API___test.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API___test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
       private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        } 

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var companies = await _companyService.GetAll();
            var companiesDTO = _mapper.Map<IEnumerable<CompanyDTO>>(companies);
            var response = new ApiResponse<IEnumerable<CompanyDTO>>(companiesDTO);
            return Ok(response);
        }
    }
}
