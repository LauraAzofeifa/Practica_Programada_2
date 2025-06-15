using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramacionAvanzada.Web.Models
{
    public class Car
    {
        // Id del vehuculo
        public string Id { get; set; }

        // Marca del vehiculo
        public string brand { get; set; }

        // Descripción del vehiculo
        public string Description { get; set; }

        // Fecha de creación del vehiculo
        public DateTime DateCreated { get; set; }
    }
}