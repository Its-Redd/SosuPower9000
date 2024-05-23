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

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpPost]
        public void AddNew([FromBody] Employee employee)
        {
            repository.Add(employee);
        }

        [HttpPut]
        public void Update(Employee employee)
        {
            repository.Update(employee);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete]
        public void Delete(Employee employee)
        {
            repository.Delete(employee);
        }
    }
}
