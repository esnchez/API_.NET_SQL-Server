using API___test.Core.DTOs;
using API___test.Core.Entities;
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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper __mapper;


        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            __mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _employeeService.GetAll();
            var employeesDTO = __mapper.Map<IEnumerable<EmployeeDTO>>(employees);
            var response = new ApiResponse<IEnumerable<EmployeeDTO>>(employeesDTO);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetWhere(int id)
        {
            List<Employee> employees = _employeeService.GetWhere(id);
            var employeesDTO = __mapper.Map<IEnumerable<EmployeeDTO>>(employees);
            var response = new ApiResponse<IEnumerable<EmployeeDTO>>(employeesDTO);
            return Ok(response);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var employee = await _employeeService.GetById(id);
        //    var employeeDTO = __mapper.Map<EmployeeDTO>(employee);
        //    var response = new ApiResponse<EmployeeDTO>(employeeDTO);
        //    return Ok(response);
        //}

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeDTO employeeDTO)
        {
            var newEmployee = __mapper.Map<Employee>(employeeDTO);

            await _employeeService.CreateEmployee(newEmployee);

            employeeDTO = __mapper.Map<EmployeeDTO>(newEmployee);

            var response = new ApiResponse<EmployeeDTO>(employeeDTO);

            return Ok(response);
        }



        [HttpPut]
        public async Task<IActionResult> Put(int id, EmployeeDTO employeeDTO)
        {
            var employee = __mapper.Map<Employee>(employeeDTO);
            employee.Id = id;
            var result = await _employeeService.EditEmployee(employee);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
