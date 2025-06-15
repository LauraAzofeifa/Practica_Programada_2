using ProgramacionAvanzada.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class CarController : Controller
    {
        // Lista estática en memoria
        private static List<Car> cars = new List<Car>
        {
            new Car { Id = "1", brand = "Toyota", Description = "Sprinter Trueno AE86", DateCreated = DateTime.Now },
            new Car { Id = "2", brand = "Mazda", Description = "RX-7 FD3S", DateCreated = DateTime.Now },
            new Car { Id = "3", brand = "Mazda", Description = "RX-7 FC3S", DateCreated = DateTime.Now },
            new Car { Id = "4", brand = "Nissan", Description = "Silvia S13", DateCreated = DateTime.Now },
            new Car { Id = "5", brand = "Nissan", Description = "Skyline GT-R R32", DateCreated = DateTime.Now },
            new Car { Id = "6", brand = "Subaru", Description = "Impreza WRX STi", DateCreated = DateTime.Now },
            new Car { Id = "7", brand = "Honda", Description = "Civic EG6", DateCreated = DateTime.Now },
            new Car { Id = "8", brand = "Toyota", Description = "MR2 SW20", DateCreated = DateTime.Now },
            new Car { Id = "9", brand = "Mitsubishi", Description = "Lancer Evolution III", DateCreated = DateTime.Now },
            new Car { Id = "10", brand = "Nissan", Description = "180SX", DateCreated = DateTime.Now },

        };

        // Metodo GET - Listar vehiculos
        public ActionResult Index()
        {
            return View(cars);
        }

        // Metodo GET - Crear un vehiculo
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Metodo POST - Crear un vehiculo
        [HttpPost]
        public ActionResult Create(Car car)
        {
            car.Id = (cars.Count + 1).ToString();
            car.DateCreated = DateTime.Now;
            cars.Add(car);
            return View("Index", cars);
        }

        // Metodo POST - Eliminar un vehiculo
        [HttpPost]
        public ActionResult Delete(string id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                cars.Remove(car);
            }
            return RedirectToAction("Index");
        }
    }
}