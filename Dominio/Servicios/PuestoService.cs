using AccesoData.DAO;
using Entidades.Cache;
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
    }
}
