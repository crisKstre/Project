using AccesoData.DAO;
using Entidades.Cache;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicios
{
    public class PuestoService
    {
        private PuestoDao puestoDao = new PuestoDao();

        public int RegistrarPuesto(Puesto puesto)
        {
            return puestoDao.InsertarPuesto(puesto);
        }

        public DataTable ObtenerPuestosPorFeriante(int idFeriante)
        { 
            return puestoDao.ObtenerPuestosPorFeriante(idFeriante);
        }

        public List<Puesto> ObtenerPuestosPorUsuario(int idUsuario)
        {
            return puestoDao.ObtenerPuestosPorUsuario(idUsuario);
        }

        public bool EliminarPuesto(int idPuesto)
        {
            return puestoDao.EliminarPuesto(idPuesto);
        }

        public bool ActualizarPuesto(Puesto puesto)
        {
            return puestoDao.ActualizarPuesto(puesto);
        }


    }

}
