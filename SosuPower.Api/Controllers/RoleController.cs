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

        [HttpGet]
        public IEnumerable<Role> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Role> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpPost]
        public void AddNew([FromBody] Role role)
        {
            repository.Add(role);
        }

        [HttpPut]
        public void Update(Role role)
        {
            repository.Update(role);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete]
        public void Delete(Role role)
        {
            repository.Delete(role);
        }
    }
}
