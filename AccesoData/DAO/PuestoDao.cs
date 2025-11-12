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
    public class PuestoDao : ConexionSql
    {
        public int InsertarPuesto(Puesto puesto)
        {
            int idGenerado = 0;

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();

                string sql = @"
            INSERT INTO Puestos (IdFeriante, NombrePuesto, Categoria, Descripcion, Estado, Encargado)
            VALUES (@IdFeriante, @NombrePuesto, @Categoria, @Descripcion, @Estado, @Encargado);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // IdFeriante debe venir del registro del feriante asociado al usuario
                    cmd.Parameters.AddWithValue("@IdFeriante", UserLoginCache.idUsuario);

                    cmd.Parameters.AddWithValue("@NombrePuesto", puesto.NombrePuesto);
                    cmd.Parameters.AddWithValue("@Categoria", (object)puesto.Categoria ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)puesto.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Estado", puesto.Estado ?? "Activo");

                    // Encargado es el nombre del usuario que creó el puesto
                    cmd.Parameters.AddWithValue("@Encargado", puesto.Encargado);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        idGenerado = Convert.ToInt32(result);
                }
            }

            return idGenerado;
        }

        public bool EliminarPuesto(int idPuesto)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Primero eliminar postulaciones/participaciones relacionadas
                    string queryPostulaciones = "DELETE FROM Participacion WHERE IdPuesto = @IdPuesto";
                    using (SqlCommand cmd1 = new SqlCommand(queryPostulaciones, connection, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@IdPuesto", idPuesto);
                        cmd1.ExecuteNonQuery();
                    }

                    // Luego eliminar el puesto
                    string queryPuesto = "DELETE FROM Puestos WHERE IdPuesto = @IdPuesto";
                    using (SqlCommand cmd2 = new SqlCommand(queryPuesto, connection, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@IdPuesto", idPuesto);
                        cmd2.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error al eliminar puesto: " + ex.Message);
                    return false;
                }
            }
        }



        public DataTable ObtenerPuestosPorFeriante(int idFeriante)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = "SELECT idPuesto, NombrePuesto, Categoria, Descripcion, Estado, Encargado FROM Puestos WHERE IdFeriante = @IdFeriante";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdFeriante", idFeriante);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            return tabla;
        }


        public List<Puesto> ObtenerPuestosPorUsuario(int idUsuario)
        {
            List<Puesto> lista = new List<Puesto>();

            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Puestos WHERE IdFeriante = @IdFeriante";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdFeriante", idUsuario);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Puesto
                            {
                                IdPuesto = reader.GetInt32(reader.GetOrdinal("IdPuesto")),
                                NombrePuesto = reader["NombrePuesto"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Estado = reader["Estado"].ToString(),
                                Encargado = reader["Encargado"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

    }
}
