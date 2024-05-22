using SosuPower.Entities;
using Task = SosuPower.Entities.Task;

namespace SosuPower.DataAccess
{
    public class TaskRepository(DataContext dataContext) :
        Repository<Entities.Task>(dataContext), ITaskRepository
    {

        public IEnumerable<Entities.Task> GetTasksOn(DateTime date)
        {
            return dataContext.Tasks.Where(a => a.TimeStart == date.Date);
        }

        public IEnumerable<Task> GetTasksFor(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}