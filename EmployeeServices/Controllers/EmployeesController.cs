using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EmployeeDataAccess;

namespace EmployeeServices.Controllers
{
    public class EmployeesController : ApiController
    {
        // GET
        public IEnumerable<Employee> Get() 
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}