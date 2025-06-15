using ProgramacionAvanzada.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class PersonController : Controller
    {
        // Lista estática en memoria
        private static List<Person> persons = new List<Person>
        {
            new Person { Id = "1", Name = "Laura", Description = "Developer", DateCreated = DateTime.Now },
            new Person { Id = "2", Name = "Carlos", Description = "Manager", DateCreated = DateTime.Now },
            new Person { Id = "3", Name = "Ana", Description = "Tester", DateCreated = DateTime.Now },
            new Person { Id = "4", Name = "Luis", Description = "Support", DateCreated = DateTime.Now },
            new Person { Id = "5", Name = "Eva", Description = "Designer", DateCreated = DateTime.Now },
            new Person { Id = "6", Name = "Pedro", Description = "QA", DateCreated = DateTime.Now },
            new Person { Id = "7", Name = "Diana", Description = "Intern", DateCreated = DateTime.Now },
            new Person { Id = "8", Name = "Juan", Description = "CEO", DateCreated = DateTime.Now },
            new Person { Id = "9", Name = "Luisa", Description = "CFO", DateCreated = DateTime.Now },
            new Person { Id = "10", Name = "Marta", Description = "CTO", DateCreated = DateTime.Now }
        };

        public ActionResult Index()
        {
            return View(persons);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            person.Id = (persons.Count + 1).ToString();
            person.DateCreated = DateTime.Now;
            persons.Add(person);
            return View("Index", persons);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            var person = persons.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                persons.Remove(person);
            }
            return RedirectToAction("Index");
        }
    }
}