using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;

namespace SosuPower.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController(ITaskRepository repository) : Controller
    {
        private readonly ITaskRepository repository = repository;

        /// <summary>
        /// Retrieves the assignments for an employee on a specific date.
        /// </summary>
        /// <param name="employeeId">The ID of the employee.</param>
        /// <param name="date">The date to retrieve the assignments for. If not specified, the current date is used.</param>
        /// <returns>The list of tasks assigned to the employee on the specified date.</returns>
        [HttpGet(nameof(GetAssignmentsForEmployeeByDate))]
        public IEnumerable<Entities.Task> GetAssignmentsForEmployeeByDate(int employeeId, DateTime date = default)
        {
            if (date == default)
            {
                date = DateTime.Now;
            }

            if (employeeId == null)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            return repository.GetTasksForEmployeeOnDate(employeeId, date);
        }

        /// <summary>
        /// Adds a new task.
        /// </summary>
        /// <param name="task">The task to add.</param>
        [HttpPost]
        public void AddNew([FromQuery] Entities.Task task)
        {
            repository.Add(task);
        }

        /// <summary>
        /// Updates an existing task.
        /// </summary>
        /// <param name="task">The task to update.</param>
        [HttpPut]
        public void Update(Entities.Task task)
        {
            repository.Update(task);
        }

        /// <summary>
        /// Deletes a task by ID.
        /// </summary>
        /// <param name="id">The ID of the task to delete.</param>
        [HttpDelete("DeleteById")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        /// <summary>
        /// Deletes a task.
        /// </summary>
        /// <param name="task">The task to delete.</param>
        [HttpDelete]
        public void Delete(Entities.Task task)
        {
            repository.Delete(task);
        }
    }
}