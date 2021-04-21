using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaServiciosBackend.claseModelos;
using capaServiciosBackend.modelos;

namespace capaServiciosBackend.Backend
{
    public class EmployeesSC
    {
        public NorthwindContext dbContex = new NorthwindContext();

        public IQueryable <Employee> GetEmployees()
        {
            return dbContex.Employees.AsQueryable();
        }

        public Employee getEmployeeByID(int id)
        {
            return GetEmployees().Where(x => x.EmployeeId == id).FirstOrDefault();
        }

        public void EliminarByID(int id)
        {
            var eliminarEmpleado = getEmployeeByID(id);
            dbContex.Remove(eliminarEmpleado);
            dbContex.SaveChanges();
        }

        public void agregarEmpleado(EmployeeModel newEmployee)
        {
            var nuevoRegistro = new Employee();
            nuevoRegistro.FirstName = newEmployee.name;
            nuevoRegistro.LastName = newEmployee.lastName;

            dbContex.Employees.Add(nuevoRegistro);
            dbContex.SaveChanges();

        }

        public void updateEmployeeByID(int id, EmployeeModel newEmployee)
        {
            var updateInfo = getEmployeeByID(id);
            updateInfo.FirstName = newEmployee.name;
            updateInfo.LastName = newEmployee.lastName;
            
            dbContex.SaveChanges();
        
        }

    }
}
