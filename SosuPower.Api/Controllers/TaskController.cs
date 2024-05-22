using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SosuPower.Entities;

namespace SosuPower.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController(ITaskRepository repository) : Controller
    {
        private readonly ITaskRepository repository = repository;

        [HttpGet]
        public IEnumerable<Entities.Task> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetTasksOn))]
        public IEnumerable<Entities.Task> GetTasksOn(DateTime date = default)
        {
            return repository.GetTasksOn(date);
        }

        [HttpGet(nameof(GetTasksFor))]
        public IEnumerable<Entities.Task> GetTasksFor(Employee employee)
        {
            return repository.GetTasksFor(employee);
        }
        [HttpPost]
        public void AddNew(Entities.Task task)
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