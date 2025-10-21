using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento
    {

        public int IdEvento { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }
        public int Cupos { get; set; }
        public decimal PrecioEntrada { get; set; }
        public string Tipo { get; set; }

        // Quedará guardado para cuando sea necesario relacionar (por ejemplo al listar eventos creados)
        public int IdAgrupacionCreadora { get; set; }

    }
}
