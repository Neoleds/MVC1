using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVC1.Models;
using MVC1.ViewModels;


namespace MVC1.Controllers
{
    public class PersonController : Controller
    {
        private static List<PeopleData> _people = new List<PeopleData>();
        
        [HttpPost]
        public IActionResult AddPeople(CreatePersonViewModel createPersonViewModel)
        {
            _people.Add(new PeopleData(createPersonViewModel.Name, createPersonViewModel.Number, createPersonViewModel.City));
            return RedirectToAction("People");
        }

        public ViewResult People()
        {

            PersonViewModel PeopleViewModel = new PersonViewModel()
            {
                PeopleDataList = _people
                
            };
            return View(PeopleViewModel);
        } 
        public IActionResult DeletePerson(int index)
        {

            _people.RemoveAt(index);
            return RedirectToAction("People");
        }
    }
}
