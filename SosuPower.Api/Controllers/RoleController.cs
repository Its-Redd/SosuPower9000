using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SosuPower.Entities;

namespace SosuPower.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController(IRepository<Role> repository) : ControllerBase
    {
        private readonly IRepository<Role> repository;

        /// <summary>
        /// Retrieves all roles.
        /// </summary>
        /// <returns>An enumerable collection of roles.</returns>
        [HttpGet]
        public IEnumerable<Role> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Retrieves a role by its ID.
        /// </summary>
        /// <param name="id">The ID of the role.</param>
        /// <returns>The role with the specified ID.</returns>
        [HttpGet("{id}")]
        public ActionResult<Role> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Adds a new role.
        /// </summary>
        /// <param name="role">The role to add.</param>
        [HttpPost]
        public void AddNew([FromBody] Role role)
        {
            repository.Add(role);
        }

        /// <summary>
        /// Updates a role.
        /// </summary>
        /// <param name="role">The role to update.</param>
        [HttpPut]
        public void Update(Role role)
        {
            repository.Update(role);
        }

        /// <summary>
        /// Deletes a role by its ID.
        /// </summary>
        /// <param name="id">The ID of the role to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        /// <summary>
        /// Deletes a role.
        /// </summary>
        /// <param name="role">The role to delete.</param>
        [HttpDelete]
        public void Delete(Role role)
        {
            repository.Delete(role);
        }
    }
}
