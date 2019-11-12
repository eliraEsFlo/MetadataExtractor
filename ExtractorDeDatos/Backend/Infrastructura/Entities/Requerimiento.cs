using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Infrastructura.Entities
{
    public class Requerimiento
    {
    
        public Requerimiento()
        {
          
        }
        public string idRequerimiento { get; set; }


        public string NombreRequerimiento { get; set; }

        public string RutaRequerimiento { get; set; }

        public string NombreArea { get; set; }

        public string NombreTipoRequerimiento { get; set; }

        public DateTime FechaAsignacion { get; set; }
        public string NombreEstado { get; set; }

  
        public string Prioridad { get; set; }

        public string NombreLider { get; set; }


    }
}