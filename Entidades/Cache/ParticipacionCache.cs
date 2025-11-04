using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Cache
{
    public class ParticipacionCache
    {

        public int IdParticipacion { get; set; }
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public int IdPuesto { get; set; }
        public string NombrePuesto { get; set; }
        public string CategoriaPuesto { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }

    }
}
