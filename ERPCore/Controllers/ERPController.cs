using ERPCore.Interfaces;
using ERPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERPCore.Repository;

namespace ERPCore.Controllers
{
    public class ERPController : ApiController
    {
        //private EmployeeRepository _employeeRepository;
        private IEmployeeInterface _employeeRepository;
        public ERPController()
        {
            _employeeRepository = new EmployeeRepository();
        }

        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            //IEmployeeInterface _employeeInterface = null;
            return _employeeRepository.GetEmployees(); 
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}