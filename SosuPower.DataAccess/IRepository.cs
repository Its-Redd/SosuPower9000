using SosuPower.Entities;
namespace SosuPower.DataAccess
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetBy(int id);
    }

    public interface ITaskRepository : IRepository<Entities.Task>
    {
        IEnumerable<Entities.Task> GetTasksForEmployeeOnDate(Employee employee, DateTime date);
        IEnumerable<Entities.Task> GetTasksFor(Employee employee);
    }

    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Entities.Task> GetEmployeesAt(CareCenter careCenter);
        IEnumerable<Entities.Task> GetEmployeesWith(Role role);
    }


}