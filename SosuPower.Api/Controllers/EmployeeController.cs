using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SosuPower.Entities;

namespace SosuPower.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeRepository repository) : ControllerBase
    {

        private readonly IEmployeeRepository repository;

        /// <summary>
        /// Retrieves all employees.
        /// </summary>
        /// <returns>An enumerable collection of employees.</returns>
        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Retrieves an employee by ID.
        /// </summary>
        /// <param name="id">The ID of the employee.</param>
        /// <returns>An ActionResult containing the employee.</returns>
        [HttpGet("{id}")]
        public ActionResult<Employee> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Adds a new employee.
        /// </summary>
        /// <param name="employee">The employee to add.</param>
        [HttpPost]
        public void AddNew([FromBody] Employee employee)
        {
            repository.Add(employee);
        }

        /// <summary>
        /// Updates an existing employee.
        /// </summary>
        /// <param name="employee">The updated employee.</param>
        [HttpPut]
        public void Update(Employee employee)
        {
            repository.Update(employee);
        }

        /// <summary>
        /// Deletes an employee by ID.
        /// </summary>
        /// <param name="id">The ID of the employee to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        /// <summary>
        /// Deletes an employee.
        /// </summary>
        /// <param name="employee">The employee to delete.</param>
        [HttpDelete]
        public void Delete(Employee employee)
        {
            repository.Delete(employee);
        }
    }
}
