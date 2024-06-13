using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SosuPower.Entities;

namespace SosuPower.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareCenterController(IRepository<CareCenter> repository) : ControllerBase
    {
        private readonly IRepository<CareCenter> repository;

        /// <summary>
        /// Get all care centers.
        /// </summary>
        /// <returns>An enumerable collection of care centers.</returns>
        [HttpGet]
        public IEnumerable<CareCenter> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Get a care center by ID.
        /// </summary>
        /// <param name="id">The ID of the care center.</param>
        /// <returns>The care center with the specified ID.</returns>
        [HttpGet("{id}")]
        public ActionResult<CareCenter> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Add a new care center.
        /// </summary>
        /// <param name="careCenter">The care center to add.</param>
        [HttpPost]
        public void AddNew([FromBody] CareCenter careCenter)
        {
            repository.Add(careCenter);
        }

        /// <summary>
        /// Update a care center.
        /// </summary>
        /// <param name="careCenter">The care center to update.</param>
        [HttpPut]
        public void Update(CareCenter careCenter)
        {
            repository.Update(careCenter);
        }

        /// <summary>
        /// Delete a care center by ID.
        /// </summary>
        /// <param name="id">The ID of the care center to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        /// <summary>
        /// Delete a care center.
        /// </summary>
        /// <param name="careCenter">The care center to delete.</param>
        [HttpDelete]
        public void Delete(CareCenter careCenter)
        {
            repository.Delete(careCenter);
        }
    }
}
