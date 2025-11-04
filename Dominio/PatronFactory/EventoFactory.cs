using Entidades.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.PatronFactory
{
    public abstract class EventoFactory
    {
        public abstract EventoCache CrearEvento(string nombre, int idAgrupacion, string lugar, DateTime fechaInicio, DateTime fechaFin, string descripcion);
    }
}
