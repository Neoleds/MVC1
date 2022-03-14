using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVC1.Models;
using MVC1.ViewModels;
using System.Linq;

namespace MVC1.Controllers
{
    public class PersonController : Controller
    {
        private static List<PeopleData> _people = new List<PeopleData>();
        private static List<PeopleData> _searchPeople = new List<PeopleData>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AddPeople(CreatePersonViewModel createPersonViewModel)
        {
            _searchPeople.Clear();
            _people.Add(new PeopleData(id++, createPersonViewModel.Name, createPersonViewModel.Number, createPersonViewModel.City));
            return RedirectToAction("People");
        }

        [HttpGet]
        public ViewResult People()
        {
            PersonViewModel PeopleViewModel = new PersonViewModel(_people);

            PersonViewModel SearchViewModel = new PersonViewModel(_searchPeople);

            if (_searchPeople.Count == 0)
            {
                return View(PeopleViewModel);
            }
            else
            {
                return View(SearchViewModel);
            }
            
        } 

        public IActionResult DeletePerson(int id)
        {
            PeopleData peopleData = _people.Find(x => x.Id == id);
            _people.Remove(peopleData);
            return RedirectToAction("People");
        }
        
        public IActionResult Search(string search)
        {
            _searchPeople.Clear();
            if (search == null)
            {
                return RedirectToAction("People");
            }
            for (var i = 0; i < _people.Count; i++)
            {
                if (_people[i].Name.ToLower().Equals(search.ToLower()))
                {
                    _searchPeople.Add(_people[i]);
                }
                else if (_people[i].City.ToLower().Equals(search.ToLower()))
                {
                    _searchPeople.Add(_people[i]);
                }

            }
            return RedirectToAction("People");
        }

        public IActionResult LoadList() 
        {
            PersonViewModel personViewModel = new PersonViewModel(_people);
            return PartialView("PeopleDataListPartialView", personViewModel);
        }
        public IActionResult FindPersonAjax(int id)
        {
            PeopleData foundPerson = _people.Find(x => x.Id == id);
            if (foundPerson == null)
            {
                return StatusCode(404);
            }
            return PartialView("PeopleDataPartialView", foundPerson);
        }
        public IActionResult DeletePersonAjax(int id)
        {
            PeopleData deletedPerson = _people.Find(x => x.Id == id);
            if (deletedPerson == null)
            {
                return StatusCode(404);
            }
            _people.Remove(deletedPerson);
            return PartialView("PeopleDataPartialView", deletedPerson);
     
        }

    }
}
