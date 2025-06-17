using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramacionAvanzada.Web.Models
{
    public class Job
    {
        // Id del trabajo
        public string Id { get; set; }

        // Nombre del trabajo
        public string Name { get; set; }

        // Descripción del trabajo
        public string Description { get; set; }

        // Fecha de creación del trabajo
        public DateTime DateCreated { get; set; }
        public int Count { get; internal set; }
    }
}