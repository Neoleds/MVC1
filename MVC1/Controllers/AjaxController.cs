using Microsoft.AspNetCore.Mvc;
using MVC1.Models;
using System.Collections.Generic;
using MVC1.ViewModels;
using MVC1.Views.Shared;

namespace MVC1.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult AjaxList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Load()
        {
            return RedirectToAction("LoadList", "Person");
        }
        [HttpPost]
        public IActionResult FindPerson(int id)
        {
            return RedirectToAction("FindPersonAjax", "Person", new {id = id});
        }
        [HttpPost]
        public IActionResult DeletePerson(int id)
        {
            return RedirectToAction("DeletePersonAjax", "Person", new { id = id });
        }
    }
}
