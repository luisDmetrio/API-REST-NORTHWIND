using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capaServiciosBackend.Backend;
using capaServiciosBackend.modelos;
using capaServiciosBackend.claseModelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRestNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        [HttpGet]
        public List<Employee> Get()
        {
            var empleado = new EmployeesSC().GetEmployees().ToList();
            return empleado;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return new EmployeesSC().getEmployeeByID(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] EmployeeModel newEmployee)
        {
            new EmployeesSC().agregarEmpleado(newEmployee);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeModel newEmployee)
        {
            new EmployeesSC().updateEmployeeByID(id, newEmployee);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            new EmployeesSC().EliminarByID(id);
        }
    }
}
