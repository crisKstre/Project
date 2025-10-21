using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.PatronFactory
{
    public class EventoNacionalFactory : EventoFactory
    {
        public override Evento CrearEvento(string nombre, string lugar, DateTime fechaInicio, DateTime fechaFin, string descripcion)
        {
            return new Evento
            {
                Tipo = "Nacional",
                Nombre = nombre,
                Lugar = lugar,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                Descripcion = descripcion
            };
        }
    }
}
