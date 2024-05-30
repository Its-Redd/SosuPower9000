using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SosuPower.Entities;
using Task = SosuPower.Entities.Task;

namespace SosuPower.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController(ITaskRepository repository) : Controller
    {
        private readonly ITaskRepository repository = repository;

        [HttpGet("GetAll")]
        public IEnumerable<Entities.Task> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetAssignmentsForEmployeeByDate))]
        public IEnumerable<Entities.Task> GetAssignmentsForEmployeeByDate(Employee employee, DateTime date = default)
        {
            return repository.GetTasksforEmployeeOnDate(employee, date);
        }

        [HttpGet(nameof(GetTasksFor))]
        public IEnumerable<Entities.Task> GetTasksFor(Employee employee)
        {
            return repository.GetTasksFor(employee);
        }
        [HttpPost]
        public void AddNew([FromQuery] Entities.Task task)
        {
            repository.Add(task);
        }

        [HttpPut]
        public void Update(Entities.Task task)
        {
            repository.Update(task);
        }

        [HttpDelete("DeleteById")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete]
        public void Delete(Entities.Task task)
        {
            repository.Delete(task); ;
        }
    }
}