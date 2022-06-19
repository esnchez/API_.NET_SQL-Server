using API___test.Core.Entities;
using API___test.Core.Interfaces.IRepositories;
using API___test.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace API___test.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public async Task CreateEmployee(Employee employee)
        {
            await _employeeRepository.Add(employee);

        }

        public async Task<bool> DeleteEmployee(int id)
        {
            await _employeeRepository.Delete(id);
            return true;

        }
        
        public async Task<bool> EditEmployee(Employee employee)
        {
            await _employeeRepository.Update(employee);
            return true;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            IEnumerable<Employee> allEmployees = await _employeeRepository.GetAll();
            return allEmployees;
        }

        public List<Employee> GetWhere(int id)
        {
            List<Employee> selectedEmployees = (_employeeRepository.FindAsync(x => x.TeamId == id)).ToList();
            return selectedEmployees;
        }

        public async Task<Employee> GetById(int id)
        {
            return await _employeeRepository.GetById(id);

        }

        
    }
}
