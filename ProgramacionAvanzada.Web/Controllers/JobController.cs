using ProgramacionAvanzada.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class JobController : Controller
    {

        private static List<Job> jobs = new List<Job>
        {
           new Job { Id = "1", Name = "Vendedor de Autos", Description = "Encargado de vender vehículos a los clientes",DateCreated = DateTime.Now },
           new Job { Id = "2", Name = "Gerente de Ventas", Description = "Supervisa al equipo de ventas y establece metas",DateCreated = DateTime.Now },
           new Job { Id = "3", Name = "Técnico de Servicio", Description = "Realiza mantenimiento y reparaciones a los vehículos",DateCreated = DateTime.Now },
           new Job { Id = "4", Name = "Asesor de Finanzas", Description = "Ayuda a los clientes con opciones de financiamiento",DateCreated = DateTime.Now },
           new Job { Id = "5", Name = "Recepcionista", Description = "Atiende a los clientes y coordina citas de servicio",DateCreated = DateTime.Now },
           new Job { Id = "6", Name = "Gerente de Servicio", Description = "Supervisa el departamento de servicio y reparaciones",DateCreated = DateTime.Now },
           new Job { Id = "7", Name = "Especialista en Repuestos", Description = "Gestiona el inventario de piezas y repuestos",DateCreated = DateTime.Now },
           new Job { Id = "8", Name = "Coordinador de Marketing", Description = "Desarrolla estrategias de marketing para el concesionario",DateCreated = DateTime.Now },
           new Job { Id = "9", Name = "Analista de Ventas", Description = "Analiza datos de ventas y tendencias del mercado",DateCreated = DateTime.Now },
           new Job { Id = "10", Name = "Gerente General", Description = "Responsable de la operación general del concesionario",DateCreated = DateTime.Now },
        };

        //Método GET - Listar Trabajos
        public ActionResult Index()
        {
            return View(jobs);
        }


        //Método GET - Crear un trabajo
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //Método POST - Crear un trabajo
        [HttpPost]
        public ActionResult Create(Job job)
        {
            job.Id = (jobs.Count + 1).ToString();
            job.DateCreated = DateTime.Now;
            jobs.Add(job);
            return View("Index", jobs);
        }

        //Método POST - Eliminar un trabajo
        [HttpPost]
        public ActionResult Delete(string id)
        {
            var job = jobs.FirstOrDefault(p => p.Id == id);
            if (job != null)
            {
                jobs.Remove(job);
            }
            return RedirectToAction("Index");
        }

    }
}