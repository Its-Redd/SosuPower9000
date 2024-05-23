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

        [HttpGet]
        public IEnumerable<CareCenter> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<CareCenter> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpPost]
        public void AddNew([FromBody] CareCenter careCenter)
        {
            repository.Add(careCenter);
        }

        [HttpPut]
        public void Update(CareCenter careCenter)
        {
            repository.Update(careCenter);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete]
        public void Delete(CareCenter careCenter)
        {
            repository.Delete(careCenter);
        }
    }
}
