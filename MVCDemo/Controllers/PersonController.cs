using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PersonController : Controller // controller
    {
        // GET: Person
        public ActionResult Index() // action
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Liv", LastName = "Sheeran", Age = 23}); // IsAlive defeaults to true, don't need to specify
            people.Add(new PersonModel { FirstName = "Jane", LastName = "Alane", Age = 18 });
            people.Add(new PersonModel { FirstName = "Phil", LastName = "Mitchell", Age = 63 });
            people.Add(new PersonModel { FirstName = "M", LastName = "J", Age = 33, IsAlive=false});

            return View(people);
        }
    }
}