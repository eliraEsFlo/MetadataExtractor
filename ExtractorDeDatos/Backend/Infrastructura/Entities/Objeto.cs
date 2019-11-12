using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructura.Entities
{
    public class Objeto
    {
        public int idObjeto { get; set; }
        public string NombreObjeto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public string TipoObjeto { get; set; }
    }
}
