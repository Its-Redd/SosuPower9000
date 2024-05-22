using Microsoft.AspNetCore.Mvc;

namespace SosuPower.Api.Controllers
{
    public class CareCenterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
