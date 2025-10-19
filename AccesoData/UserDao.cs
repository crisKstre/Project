using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Entidades.Cache;

namespace AccesoData
{
   
        public class UserDao : ConexionSql
        {
            public bool Register(string nombre, string loginNombre, string email, string pass, int telefono,string posicion)
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"
                    INSERT INTO Usuarios (Nombre, LoginNombre, Email, Pass, Telefono,Posicion)
                    VALUES (@nombre, @loginNombre, @email, @pass, @telefono,@posicion)";

                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@loginNombre", loginNombre);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@posicion", posicion);

                    int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
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
