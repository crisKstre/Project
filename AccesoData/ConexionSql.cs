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
        public ConexionSql()
        {
            connectionString = "Server=CRIS\\SQLEXPRESS;DataBase= FeriaDB; integrated security= true; TrustServerCertificate=true;";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
