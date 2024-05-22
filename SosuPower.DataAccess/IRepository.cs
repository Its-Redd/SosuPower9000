namespace SosuPower.DataAccess;

public interface IRepository<T>
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    IEnumerable<T> GetAll();
    T GetBy(int id);

}

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DataContext context;

    public Repository(DataContext context)
    {
        this.context = context;
    }

    public void Add(T entity)
    {
        context.Set<T>().Add(entity);
        context.SaveChanges();
    }

    public void Update(T entity)
    {
        context.Set<T>().Update(entity);
        context.SaveChanges();
    }

    public void Delete(T entity)
    {
        context.Set<T>().Remove(entity);
        context.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return context.Set<T>().ToList();
    }

    public T GetBy(int id)
    {
        return context.Set<T>().Find(id);
    }
}