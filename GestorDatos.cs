using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using SQLiteUtil;

namespace PokemonJuegoProyecto
{
    public class GestorDatos
    {
        private string cadenaConexion = "Data Source=PokemonJuego.db";

        public bool RegistrarUsuario(string Nombreusuario, string contraseña)
        {
            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();

                string queryVerificar = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuarios = @Nombreusuario";

                using (SqliteCommand command = new SqliteCommand(queryVerificar, connection))
                {
                    command.Parameters.AddWithValue("@Nombreusuario", Nombreusuario);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        return false; // El usuario ya existe
                    }
                }

                string queryAgregar = "INSERT INTO Usuarios (NombreUsuarios, ContraseUsuarios, BatallasGanadas) VALUES (@Nombreusuario, @contraseña, 0)";
                using (SqliteCommand command = new SqliteCommand(queryAgregar, connection))
                {
                    command.Parameters.AddWithValue("@Nombreusuario", Nombreusuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.ExecuteNonQuery();
                }
            }
            return true; // Usuario registrado exitosamente
        }

        public Usuarios IniciarSesion(string Nombreusuario, string contraseña)
        {
            Usuarios usuarioiniciado = null;

            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();

                string query = "SELECT Id, NombreUsuario, BatallasGanadas FROM Usuarios WHERE NombreUsuarios = @Nombreusuario AND ContraseUsuarios = @contraseña";
                
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombreusuario", Nombreusuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioiniciado = new Usuarios
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NombreUsuarios = reader["NombreUsuario"].ToString(),
                                BatallasGanadas = Convert.ToInt32(reader["BatallasGanadas"])
                            };
                        }
                    }
                }
            }
            return usuarioiniciado;
        }
    }
}   
