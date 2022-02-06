using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC1.Views.Shared
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RandomNumber()
        {
            String randomNumber = HttpContext.Session.GetString("randomNumber");

            if (randomNumber == null)
            {
                Random randomID = new Random(Guid.NewGuid().GetHashCode());
                int secretNum = randomID.Next(1, 100);
                HttpContext.Session.SetString("randomNumber", secretNum.ToString());
            }

            return View();
        }
        [HttpPost]
        public IActionResult RandomNumber(int guess)
        {
            int randomNumber = Int32.Parse(HttpContext.Session.GetString("randomNumber"));
            if (guess > randomNumber)
            {
                ViewBag.msg = "Gissa lägre.";
            }
            else if (guess < randomNumber)
            {
                ViewBag.msg = "Gissa högre.";
            }
            else
            {
                ViewBag.msg = "Du gissade rätt nummer. Ett nytt nummer har nu blivit genererat.";
                Random randomID = new Random(Guid.NewGuid().GetHashCode());
                int secretNum = randomID.Next(1, 100);
                HttpContext.Session.SetString("randomNumber", secretNum.ToString());

            }
            return View();
        }
    }
}
