using AccesoData.DAO;
using Dominio.PatronFactory;
using Entidades.Cache;
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

        public int CrearEvento(EventoFactory factory, string nombre,int idAgrupacion, string lugar, DateTime fechaInicio,DateTime fechaFin, string descripcion, int cupos, decimal precio)
        {
            EventoCache nuevoEvento = factory.CrearEvento(nombre, idAgrupacion, lugar, fechaInicio, fechaFin, descripcion);
            nuevoEvento.Cupos = cupos;
            nuevoEvento.PrecioEntrada = precio;

            return eventoDao.InsertarEvento(nuevoEvento);
        }

        public int ObtenerIdAgrupacionPorEncargado(int idUsuario)
        {
            return eventoDao.ObtenerIdAgrupacionPorEncargado(idUsuario);
        }

        public DataTable ObtenerEventos()
        {
            return eventoDao.ObtenerEventos();
        }

        public DataTable ObtenerEventosConAgrupacion()
        {
            return eventoDao.ObtenerEventosConAgrupacion();
        }

    }
}
