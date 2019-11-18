using SGI_Connect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGI_Connect.Controllers
{
    public class PeopleController : Controller
    {
        List<PersonModel> people = new List<PersonModel>();
        
        // GET: People
        public ActionResult Index()
        {
            people.Add(new PersonModel { FirstName = "Alain", LastName = "Moussa", Age = 38 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 56 });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = "Connor", Age = 25 });
            return View();
        }

        public ActionResult ListPeople()
        {
            
            

            return View(people);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonModel person)
        {
            if(ModelState.IsValid)
            {
                people.Add(person);
                return RedirectToAction("ListPeople");
            }
            else
            {
                return View(person);
            }
            
        }
    }
}