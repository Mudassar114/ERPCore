using ERPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCore.Interfaces
{
    public interface IEmployeeInterface
    {
        IEnumerable<Employee> GetEmployees();
        //Task<Employee> GetEmployee(int employeeId);
        //Task<Employee> AddEmployee(Employee employee);
        //Task<Employee> UpdateEmployee(Employee employee);
        //void DeleteEmployee(int employeeId);
    }
}
