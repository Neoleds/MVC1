using Microsoft.AspNetCore.Mvc;
using MVC1.Data;

namespace MVC1.Controllers
{
    public class CityController : Controller
    {
        public readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult CityList()
        {
           
            return View();
        }
    }
}
