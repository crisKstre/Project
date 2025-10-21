using AccesoData;
using Dominio.PatronFactory;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicios
{
    public class EventoService
    {
        private readonly EventoDao eventoDao = new EventoDao();

        public int CrearEvento(EventoFactory factory, string nombre, string lugar, DateTime fechaInicio,DateTime fechaFin, string descripcion, int cupos, decimal precio)
        {
            Evento nuevoEvento = factory.CrearEvento(nombre, lugar, fechaInicio, fechaFin, descripcion);
            nuevoEvento.Cupos = cupos;
            nuevoEvento.PrecioEntrada = precio;

            return eventoDao.InsertarEvento(nuevoEvento);
        }

        public DataTable ObtenerEventos()
        {
            return eventoDao.ObtenerEventos();
        }

    }
}
