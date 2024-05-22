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
        IEnumerable<Entities.Task> GetTasksOn(DateTime date);
    }
}