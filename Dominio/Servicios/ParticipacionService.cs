using AccesoData.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicios
{
    public class ParticipacionService
    {
        private ParticipacionDao participacionDao = new ParticipacionDao();

        public DataTable ObtenerPostulacionesPorUsuario(int idUsuario)
        {
            return participacionDao.ObtenerPostulacionesPorUsuario(idUsuario);
        }

        public bool CambiarEstadoPostulacion(int idParticipacion, string nuevoEstado)
        {
            return participacionDao.ActualizarEstadoParticipacion(idParticipacion, nuevoEstado);
        }

        public DataTable ObtenerPostulacionesDeAgrupacionPorUsuario(int idUsuario)
        {
            return participacionDao.ObtenerPostulacionesPorAgrupacion(idUsuario);
        }



    }
}
