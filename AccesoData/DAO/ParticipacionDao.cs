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
    public class ParticipacionDao : ConexionSql
    {

        public bool ExistePostulacion(int idEvento, int idUsuario)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Participacion WHERE IdEvento = @IdEvento AND IdUsuario = @IdUsuario";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdEvento", idEvento);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool RegistrarPostulacion(ParticipacionCache participacion)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = @"
                INSERT INTO Participacion 
                (IdEvento, IdUsuario, IdPuesto, NombrePuesto, CategoriaPuesto, Rol, Estado)
                VALUES (@IdEvento, @IdUsuario, @IdPuesto, @NombrePuesto, @CategoriaPuesto, @Rol, @Estado)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdEvento", participacion.IdEvento);
                    cmd.Parameters.AddWithValue("@IdUsuario", participacion.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdPuesto", participacion.IdPuesto);
                    cmd.Parameters.AddWithValue("@NombrePuesto", participacion.NombrePuesto);
                    cmd.Parameters.AddWithValue("@CategoriaPuesto", participacion.CategoriaPuesto);
                    cmd.Parameters.AddWithValue("@Rol", participacion.Rol ?? "Feriante");
                    cmd.Parameters.AddWithValue("@Estado", participacion.Estado ?? "Pendiente");

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerPostulacionesPorUsuario(int idUsuario)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string query = @"
                    SELECT 
                        E.Nombre,
                        E.FechaInicio,
                        E.FechaFin,
                        P.NombrePuesto,
                        E.Lugar,
                        A.NombreAgrupacion,
                        P.Estado
                       
                    FROM Participacion P
                    INNER JOIN Evento E ON P.IdEvento = E.IdEvento
                    INNER JOIN Agrupacion A ON E.IdAgrupacion = A.IdAgrupacion  
                    WHERE P.IdUsuario = @IdUsuario
                    ORDER BY E.FechaInicio DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    return tabla;
                }
            }
        }

        public bool ActualizarEstadoParticipacion(int idParticipacion, string nuevoEstado)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = "UPDATE Participacion SET Estado = @Estado WHERE IdParticipacion = @IdParticipacion";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@IdParticipacion", idParticipacion);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public DataTable ObtenerPostulacionesPorAgrupacion(int idUsuario)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();

                string nombreEncargado = ObtenerNombreUsuario(idUsuario);
                int idAgrupacion = ObtenerIdAgrupacionPorEncargado(nombreEncargado);

                if (idAgrupacion == 0)
                    return tabla; // no hay agrupación vinculada a este usuario

                string sql = @"
                    SELECT 
                        p.IdParticipacion,
                        u.Nombre AS Feriante,
                        u.Telefono,
                        p.NombrePuesto,
                        p.CategoriaPuesto,
                        p.Estado,
                        e.Nombre AS Evento,
                        e.Lugar,
                        e.FechaInicio,
                        e.FechaFin
                    FROM Participacion p
                    INNER JOIN Evento e ON p.IdEvento = e.IdEvento
                    INNER JOIN Usuarios u ON p.IdUsuario = u.IdUsuario
                    WHERE e.IdAgrupacion = @IdAgrupacion
                    ORDER BY e.FechaInicio DESC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdAgrupacion", idAgrupacion);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public DataTable ObtenerPostulacionesPorEvento(int idEvento)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();

                string sql = @"
                    SELECT 
                        p.IdParticipacion,
                        u.Nombre AS Feriante,
                        u.Telefono,
                        p.NombrePuesto,
                        p.CategoriaPuesto,
                        p.Estado,
                        e.Nombre AS Evento,
                        e.Lugar,
                        e.FechaInicio,
                        e.FechaFin
                    FROM Participacion p
                    INNER JOIN Evento e ON p.IdEvento = e.IdEvento
                    INNER JOIN Usuarios u ON p.IdUsuario = u.IdUsuario
                    WHERE e.IdEvento = @IdEvento
                    ORDER BY e.FechaInicio DESC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdEvento", idEvento);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        private int ObtenerIdAgrupacionPorEncargado(string nombreEncargado)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = "SELECT IdAgrupacion FROM Agrupacion WHERE Encargado = @Encargado";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Encargado", nombreEncargado);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private string ObtenerNombreUsuario(int idUsuario)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = "SELECT Nombre FROM Usuarios WHERE IdUsuario = @IdUsuario";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
            }
        }



    }
}
