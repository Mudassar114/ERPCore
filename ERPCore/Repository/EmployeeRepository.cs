using ERPCore.Interfaces;
using ERPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ERPCore.Repository
{
    public class EmployeeRepository : IEmployeeInterface
    {
        //public Task<Employee> AddEmployee(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteEmployee(int employeeId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Employee> GetEmployee(int employeeId)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Employee> GetEmployees()
        {
            EmployeeModel model = new EmployeeModel();
            List<Employee> employees = model.SelectEmployeeRecord();
            return employees;
        }

        //public Task<Employee> UpdateEmployee(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}
    }
}