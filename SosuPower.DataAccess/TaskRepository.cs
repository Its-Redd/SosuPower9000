using Microsoft.EntityFrameworkCore;
using Task = SosuPower.Entities.Task;

namespace SosuPower.DataAccess
{
    /// <summary>
    /// Represents a repository for managing tasks.
    /// </summary>
    public class TaskRepository(DataContext dataContext) :
        Repository<Entities.Task>(dataContext), ITaskRepository
    {
        /// <summary>
        /// Retrieves the tasks for a specific employee on a given date.
        /// </summary>
        /// <param name="employeeId">The ID of the employee.</param>
        /// <param name="date">The date to filter the tasks.</param>
        /// <returns>The tasks for the employee on the specified date.</returns>
        public IEnumerable<Task> GetTasksForEmployeeOnDate(int employeeId, DateTime date)
        {
            return dataContext.Tasks
                .Where(t => t.Employees
                .Any(e => e.EmployeeId == employeeId) && t.TimeStart.Date == date)
                .Include(t => t.Resident)
                .ToList();
        }
    }
}