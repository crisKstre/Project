using Entidades.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.PatronFactory
{
    public class EventoRegionalFactory : EventoFactory
    {
        public override EventoCache CrearEvento(string nombre, int idAgrupacion, string lugar, DateTime fechaInicio, DateTime fechaFin, string descripcion)
        {
            EventoCache evento = new EventoCache

            {
                Tipo = "Regional",
                Nombre = nombre,
                IdAgrupacion = idAgrupacion,
                Lugar = lugar,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                Descripcion = descripcion
            };
            return evento;
        }
    }
}
