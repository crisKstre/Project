using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AccesoData
{
    public abstract class ConexionSql
    {
        private readonly String connectionString;
        private readonly String connectionStringLocal;
        public ConexionSql()
        {
            connectionStringLocal = "Server=CRIS\\SQLEXPRESS;DataBase= FeriaDB; integrated security= true; TrustServerCertificate=true;";
            connectionString = "Server=tcp:feriaserver.database.windows.net,1433;Initial Catalog=FeriaDB;Persist Security Info=False;User ID=useradmin;Password=admin123.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
