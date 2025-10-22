using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Entidades.Cache;

namespace AccesoData.DAO
{
   
        public class UserDao : ConexionSql
        {
        public bool Register(string nombre, string loginNombre, string email, string pass, int telefono, string posicion)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                // Primero insertamos en Usuarios
                string insertUsuario = @"
            INSERT INTO Usuarios (Nombre, LoginNombre, Email, Pass, Telefono, Posicion)
            VALUES (@nombre, @loginNombre, @email, @pass, @telefono, @posicion);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (var command = new SqlCommand(insertUsuario, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@loginNombre", loginNombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@posicion", posicion);

                    object result = command.ExecuteScalar();
                    if (result == null)
                        return false;

                    int idUsuario = Convert.ToInt32(result);

                    // Si el usuario es feriante
                    if (posicion == "Feriante")
                    {
                        string insertFeriante = @"
                    INSERT INTO Feriantes (IdFeriante)
                    VALUES (@IdFeriante);";

                        using (var commandFeriante = new SqlCommand(insertFeriante, connection))
                        {
                            commandFeriante.Parameters.AddWithValue("@IdFeriante", idUsuario);
                            int rowsAffected = commandFeriante.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }

                    // Si el usuario es agrupación
                    else if (posicion == "Agrupacion")
                    {
                        string insertAgrupacion = @"
                    INSERT INTO Agrupacion (IdAgrupacion, NombreAgrupacion, Encargado)
                    VALUES (@IdAgrupacion, @NombreAgrupacion, @Encargado);";

                        using (var commandAgrupacion = new SqlCommand(insertAgrupacion, connection))
                        {
                            commandAgrupacion.Parameters.AddWithValue("@IdAgrupacion", idUsuario);
                            commandAgrupacion.Parameters.AddWithValue("@NombreAgrupacion", loginNombre);
                            commandAgrupacion.Parameters.AddWithValue("@Encargado", nombre);
                            int rowsAffected = commandAgrupacion.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }

                    // Si es otro tipo de usuario (ej. administrador)
                    return true;
                }
            }
        }



        public bool UserExists(string loginNombre, string email)
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"
                    SELECT COUNT(*) FROM Usuarios 
                    WHERE LoginNombre = @loginNombre OR Email = @email";

                        command.Parameters.AddWithValue("@loginNombre", loginNombre);
                        command.Parameters.AddWithValue("@email", email);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }

            public bool Login(string user, string pass)
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM Usuarios WHERE LoginNombre = @user AND Pass = @pass";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                        while (reader.Read())
                        {
                            UserLoginCache.idUsuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.LoginNombre = reader.GetString(2);
                            UserLoginCache.Email = reader.GetString(3);
                            UserLoginCache.Pass = reader.GetString(4);
                            UserLoginCache.Telefono = reader.GetInt32(5);
                            UserLoginCache.Posicion = reader.GetString(6);

                        }    
                        return true;
                        }else { 
                                return false;
                            }
                    }
                }
            }


        }
    
}
