using SosuPower.Entities;
namespace SosuPower.DataAccess
{
    /// <summary>
    /// Represents a generic repository interface for CRUD operations.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(T entity);

        /// <summary>
        /// Updates an existing entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(T entity);

        /// <summary>
        /// Deletes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(T entity);

        /// <summary>
        /// Deletes an entity from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to delete.</param>
        void Delete(int id);

        /// <summary>
        /// Gets all entities from the repository.
        /// </summary>
        /// <returns>An enumerable collection of entities.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Gets an entity from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to get.</param>
        /// <returns>The entity with the specified ID.</returns>
        T GetBy(int id);
    }

    /// <summary>
    /// Represents a repository interface for managing tasks.
    /// </summary>
    public interface ITaskRepository : IRepository<Entities.Task>
    {
        /// <summary>
        /// Gets the tasks assigned to an employee on a specific date.
        /// </summary>
        /// <param name="employeeId">The ID of the employee.</param>
        /// <param name="date">The date.</param>
        /// <returns>An enumerable collection of tasks.</returns>
        IEnumerable<Entities.Task> GetTasksForEmployeeOnDate(int employeeId, DateTime date);
    }

    /// <summary>
    /// Represents a repository interface for managing employees.
    /// </summary>
    public interface IEmployeeRepository : IRepository<Employee>
    {
        /// <summary>
        /// Gets the tasks assigned to employees at a specific care center.
        /// </summary>
        /// <param name="careCenter">The care center.</param>
        /// <returns>An enumerable collection of tasks.</returns>
        IEnumerable<Entities.Task> GetEmployeesAt(CareCenter careCenter);

        /// <summary>
        /// Gets the tasks assigned to employees with a specific role.
        /// </summary>
        /// <param name="role">The role.</param>
        /// <returns>An enumerable collection of tasks.</returns>
        IEnumerable<Entities.Task> GetEmployeesWith(Role role);
    }


}