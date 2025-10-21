using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoData
{
    public class EventoDao : ConexionSql
    {

        // Devuelve el Id generado (o 0 si no se creó)
        public int InsertarEvento(Evento evento)
        {
            int idGenerado = 0;

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();

                string sql = @"
                    INSERT INTO Evento (Nombre, FechaInicio, FechaFin, Lugar, Descripcion, Cupos, PrecioEntrada, Tipo)
                    VALUES (@Nombre, @FechaInicio, @FechaFin, @Lugar, @Descripcion, @Cupos, @PrecioEntrada, @Tipo);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", evento.Nombre);
                    cmd.Parameters.AddWithValue("@FechaInicio", evento.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", evento.FechaFin);
                    cmd.Parameters.AddWithValue("@Lugar", evento.Lugar);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)evento.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cupos", evento.Cupos);
                    cmd.Parameters.AddWithValue("@PrecioEntrada", evento.PrecioEntrada);
                    cmd.Parameters.AddWithValue("@Tipo", evento.Tipo);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        idGenerado = Convert.ToInt32(result);
                }
            }

            return idGenerado;
        }

        public DataTable ObtenerEventos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();

                string sql = "SELECT IdEvento, Nombre, Tipo, FechaInicio, FechaFin, Lugar, Cupos, PrecioEntrada, Descripcion FROM Evento";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            return tabla;
        }



    }
}
