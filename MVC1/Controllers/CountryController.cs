using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
