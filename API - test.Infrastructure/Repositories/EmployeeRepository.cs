using API___test.Core.Entities;
using API___test.Core.Interfaces.IRepositories;
using API___test.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API___test.Infrastructure.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository

    {

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        //public async Task<IEnumerable<Employee>> GetAll()
        //{
        //    var employeesDB = await _context.Employees.ToListAsync();

        //    return employeesDB;
        //}

        //public async Task<Employee> GetById(int id) =>
        //    await _context.Employees.FirstOrDefaultAsync(employee => employee.Id == id);


        ////
        //public async Task CreateEmployee(Employee employee)
        //{
        //    _context.Employees.Add(employee);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<bool> EditEmployee(Employee employee)
        //{
        //    var employeeToEdit = await GetById(employee.Id);
        //    employeeToEdit.Name = employee.Name;
        //    employeeToEdit.Surname = employee.Surname;
        //    employeeToEdit.DNI = employee.DNI;
        //    employeeToEdit.Salary = employee.Salary;


        //    int rowsAffected = await _context.SaveChangesAsync();
        //    return rowsAffected > 0;
        //}

        //public async Task<bool> DeleteEmployee(int id)
        //{
        //    var employeeToDel = await GetById(id);
        //    _context.Employees.Remove(employeeToDel);

        //    int rowsAffected = await _context.SaveChangesAsync();
        //    return rowsAffected > 0;
        //}
    }
}
