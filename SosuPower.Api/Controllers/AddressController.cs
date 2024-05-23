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

        [HttpGet]
        public IEnumerable<Address> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Address> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpPost]
        public void AddNew([FromBody] Address address)
        {
            repository.Add(address);
        }

        [HttpPut]
        public void Update(Address address)
        {
            repository.Update(address);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete]
        public void Delete(Address address)
        {
            repository.Delete(address);
        }
    }
}
