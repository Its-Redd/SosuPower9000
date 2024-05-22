using Microsoft.AspNetCore.Mvc;

namespace SosuPower.Api.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
