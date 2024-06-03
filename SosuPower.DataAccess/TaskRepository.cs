using Microsoft.EntityFrameworkCore;
using Task = SosuPower.Entities.Task;

namespace SosuPower.DataAccess
{
    public class TaskRepository(DataContext dataContext) :
        Repository<Entities.Task>(dataContext), ITaskRepository
    {


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