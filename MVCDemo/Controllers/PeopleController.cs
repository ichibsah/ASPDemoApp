using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Tim", LastName = "Johnson", Age = 32 });
            people.Add(new PersonModel { FirstName = "Jake", LastName = "Roberts", Age = 46 });
            people.Add(new PersonModel { FirstName = "Lindsey", LastName = "Connor", Age = 25 });

            return View(people);
        }
    }
}