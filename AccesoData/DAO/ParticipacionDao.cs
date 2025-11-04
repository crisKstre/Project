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
                        P.IdParticipacion,
                        E.Nombre,
                        E.FechaInicio,
                        E.FechaFin,
                        P.NombrePuesto,
                        P.CategoriaPuesto,
                        P.Rol,
                        P.Estado
                    FROM Participacion P
                    INNER JOIN Evento E ON P.IdEvento = E.IdEvento
                    WHERE P.IdUsuario = @IdUsuario";

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

    }
}
