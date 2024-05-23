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

        [HttpGet]
        public IEnumerable<Resident> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Resident> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpPost]
        public void AddNew([FromBody] Resident resident)
        {
            repository.Add(resident);
        }

        [HttpPut]
        public void Update(Resident resident)
        {
            repository.Update(resident);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete]
        public void Delete(Resident resident)
        {
            repository.Delete(resident);
        }
    }
}
