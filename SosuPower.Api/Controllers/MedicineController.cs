using Microsoft.AspNetCore.Mvc;

namespace SosuPower.Api.Controllers
{
    public class MedicineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
