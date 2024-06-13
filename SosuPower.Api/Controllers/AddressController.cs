using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SosuPower.Entities;

namespace SosuPower.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController(IRepository<Address> repository) : ControllerBase
    {
        private readonly IRepository<Address> repository;

        /// <summary>
        /// Retrieves all addresses.
        /// </summary>
        /// <returns>An enumerable collection of addresses.</returns>
        [HttpGet]
        public IEnumerable<Address> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Retrieves an address by its ID.
        /// </summary>
        /// <param name="id">The ID of the address.</param>
        /// <returns>The address with the specified ID.</returns>
        [HttpGet("{id}")]
        public ActionResult<Address> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Adds a new address.
        /// </summary>
        /// <param name="address">The address to add.</param>
        [HttpPost]
        public void AddNew([FromBody] Address address)
        {
            repository.Add(address);
        }

        /// <summary>
        /// Updates an existing address.
        /// </summary>
        /// <param name="address">The address to update.</param>
        [HttpPut]
        public void Update(Address address)
        {
            repository.Update(address);
        }

        /// <summary>
        /// Deletes an address by its ID.
        /// </summary>
        /// <param name="id">The ID of the address to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        /// <summary>
        /// Deletes an address.
        /// </summary>
        /// <param name="address">The address to delete.</param>
        [HttpDelete]
        public void Delete(Address address)
        {
            repository.Delete(address);
        }
    }
}
