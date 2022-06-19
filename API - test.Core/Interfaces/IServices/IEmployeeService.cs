using API___test.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace API___test.Core.Interfaces.IServices
{
    public interface IEmployeeService
    {

        Task<IEnumerable<Employee>> GetAll();

        List<Employee> GetWhere(int id);

        Task<Employee> GetById(int id);

        Task CreateEmployee(Employee employee);

        Task<bool> EditEmployee(Employee employee);

        Task<bool> DeleteEmployee(int id);
    }
}