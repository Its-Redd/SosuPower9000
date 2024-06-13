using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SosuPower.Entities;

namespace SosuPower.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController(IRepository<Resident> repository) : ControllerBase
    {
        private readonly IRepository<Resident> repository;

        /// <summary>
        /// Retrieves all residents.
        /// </summary>
        /// <returns>An enumerable collection of Resident objects.</returns>
        [HttpGet]
        public IEnumerable<Resident> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Retrieves a resident by ID.
        /// </summary>
        /// <param name="id">The ID of the resident.</param>
        /// <returns>An ActionResult containing the Resident object.</returns>
        [HttpGet("{id}")]
        public ActionResult<Resident> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Adds a new resident.
        /// </summary>
        /// <param name="resident">The Resident object to add.</param>
        [HttpPost]
        public void AddNew([FromBody] Resident resident)
        {
            repository.Add(resident);
        }

        /// <summary>
        /// Updates a resident.
        /// </summary>
        /// <param name="resident">The Resident object to update.</param>
        [HttpPut]
        public void Update(Resident resident)
        {
            repository.Update(resident);
        }

        /// <summary>
        /// Deletes a resident by ID.
        /// </summary>
        /// <param name="id">The ID of the resident to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        /// <summary>
        /// Deletes a resident.
        /// </summary>
        /// <param name="resident">The Resident object to delete.</param>
        [HttpDelete]
        public void Delete(Resident resident)
        {
            repository.Delete(resident);
        }
    }
}
