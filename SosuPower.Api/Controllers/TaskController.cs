using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;

namespace SosuPower.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly IRepository<Entities.Task> repository;


        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            //Entities.Task task = context.Tasks
            //    .Include(t => t.Resident)
            //    .FirstOrDefault(t => t.TaskId == id);
            return default;
        }

        [HttpGet(nameof(GetTasksFor))]
        public IEnumerable<Entities.Task> GetTasksFor(DateTime date = default)
        {
            //List<Entities.Task> tasks = context.Tasks
            //    .Where(t => t.TimeStart.Date == date.Date)
            //    .ToList();
            return default;
        }

        [HttpPost]
        public void AddNew(Entities.Task task)
        {
            //context.Entry(task.Resident).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //context.Tasks.Add(task);
            //context.SaveChanges();
        }
    }
}