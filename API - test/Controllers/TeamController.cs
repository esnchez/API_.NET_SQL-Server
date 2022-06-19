using API___test.Core.DTOs;
using API___test.Core.Entities;
using API___test.Core.Services;
using API___test.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API___test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;

        public TeamController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }


        [HttpGet("{id}")]
        public IActionResult GetWhere(int id)
        {
            List<Team> teams =  _teamService.GetWhere(id);
            IEnumerable<TeamDTO> teamsDTO = _mapper.Map<IEnumerable<TeamDTO>>(teams);
            ApiResponse<IEnumerable<TeamDTO>> response = new ApiResponse<IEnumerable<TeamDTO>>(teamsDTO);
            return Ok(response);
        }
    }
}
