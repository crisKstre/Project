using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Cache
{
    public class Puesto
    {
        public int IdPuesto { get; set; }
        public int IdFeriante { get; set; }
        public string NombrePuesto { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Encargado { get; set; }
    }
}
