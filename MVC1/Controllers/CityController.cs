using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
