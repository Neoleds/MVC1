using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Fever()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Fever(int temp)
        {

            ViewBag.msg = DoctorClass.checkTemp(temp);
            return View();
        }
    }
}