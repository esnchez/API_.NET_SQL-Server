using API___test.Core.DTOs;
using API___test.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API___test.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile 
    {
        public AutomapperProfile()
        {

            CreateMap<Employee, EmployeeDTO>();
            CreateMap<EmployeeDTO, Employee>();

            CreateMap<Company, CompanyDTO>();

            CreateMap<Team, TeamDTO>();


        }
    }
}
