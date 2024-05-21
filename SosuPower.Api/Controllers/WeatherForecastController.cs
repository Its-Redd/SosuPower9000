using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SoUs.Entities;

namespace SosuPower.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        [HttpGet(Name = "GetAllEmployees")]
        public IEnumerable<Employee> Get()
        {
            DataContext context = new DataContext();
            return context.Employees.ToList();
        }
    }
}
