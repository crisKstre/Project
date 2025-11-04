using Entidades.Cache;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoData.DAO
{
    public class EventoDao : ConexionSql
    {

        // Devuelve el Id generado (o 0 si no se creó)
        public int InsertarEvento(EventoCache evento)
        {
            int idGenerado = 0;

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();

                string sql = @"
                    INSERT INTO Evento (Nombre, IdAgrupacion, FechaInicio, FechaFin, Lugar, Descripcion, Cupos, PrecioEntrada, Tipo)
                    VALUES (@Nombre,@IdAgrupacion, @FechaInicio, @FechaFin, @Lugar, @Descripcion, @Cupos, @PrecioEntrada, @Tipo);
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

                    int idAgrupacion = ObtenerIdAgrupacionPorEncargado(UserLoginCache.idUsuario);
                    if (idAgrupacion == 0)
                        throw new InvalidOperationException("No se encontró una agrupación asociada al usuario. Crea o asigna una agrupación antes de crear eventos.");
                    // usar idAgrupacion en el INSERT del evento

                    cmd.Parameters.AddWithValue("@IdAgrupacion", idAgrupacion);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        idGenerado = Convert.ToInt32(result);
                }
            }

            return idGenerado;
        }

        public int ObtenerIdAgrupacionPorEncargado(int idUsuario)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = "SELECT IdAgrupacion FROM Agrupacion WHERE IdUsuario = @IdUsuario";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
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

        public DataTable ObtenerEventosConAgrupacion()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();

                string sql = @"
            SELECT 
                e.IdEvento,
                e.Nombre,
                e.Tipo,
                e.FechaInicio,
                e.FechaFin,
                e.Lugar,
                e.Cupos,
                e.PrecioEntrada,
                e.Descripcion,
                a.NombreAgrupacion
            FROM Evento e
            INNER JOIN Agrupacion a ON e.IdAgrupacion = a.IdAgrupacion";

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
