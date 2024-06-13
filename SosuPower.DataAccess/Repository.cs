namespace SosuPower.DataAccess
{
    /// <summary>
    /// Represents a generic repository for accessing and manipulating entities of type T.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="dataContext">The data context.</param>
        public Repository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        public void Add(T entity)
        {
            dataContext.Add(entity);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Deletes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public void Delete(T entity)
        {
            dataContext.Remove(entity);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Deletes an entity from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to delete.</param>
        public void Delete(int id)
        {
            T entity = GetBy(id);
            Delete(entity);
        }

        /// <summary>
        /// Gets all entities from the repository.
        /// </summary>
        /// <returns>An enumerable collection of entities.</returns>
        public IEnumerable<T> GetAll()
        {
            return dataContext.Set<T>().ToList();
        }

        /// <summary>
        /// Gets an entity from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to get.</param>
        /// <returns>The entity with the specified ID, or null if not found.</returns>
        public T GetBy(int id)
        {
            return dataContext.Set<T>().Find(id);
        }

        /// <summary>
        /// Updates an entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public void Update(T entity)
        {
            dataContext.Update(entity);
        }
    }
}