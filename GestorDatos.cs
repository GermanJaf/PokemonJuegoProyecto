using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using SQLiteUtil;
using System.Windows.Forms;

namespace PokemonJuegoProyecto
{
    public class GestorDatos
    {
        private string cadenaConexion = "Data Source=PokemonJuego.db";
        public int PtsMejorDisponible(int idUsuario)
        {
            int puntosMejora = 0;
            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();
                string queryPuntosMejora = "SELECT PuntosMejora FROM Usuarios WHERE Id = @Id";
                using (SqliteCommand command = new SqliteCommand(queryPuntosMejora, connection))
                {
                    command.Parameters.AddWithValue("@Id", idUsuario);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        puntosMejora = Convert.ToInt32(result);
                    }
                }   
            }
            return puntosMejora;
        }
        public void SubirNivelPK(int idUsuario, int idPokemon)
        {
            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();
                string queryRestarPuntos = @"
                    UPDATE Usuarios
                    SET PuntosMejora = PuntosMejora - 1
                    WHERE Id = @Id";
                using (SqliteCommand command = new SqliteCommand(queryRestarPuntos, connection))
                {
                    command.Parameters.AddWithValue("@Id", idUsuario);
                    command.ExecuteNonQuery();
                }
                string querySubirNivel = @"
                    UPDATE PokemonUsuario
                    SET Nivel = Nivel + 1,
                        HP = HP + 10,
                        Ataque = Ataque + 5,
                        Defensa = Defensa + 5
                    WHERE UsuarioId = @UsuarioId AND PokemonId = @PokemonId";
                using (SqliteCommand command = new SqliteCommand(querySubirNivel, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", idUsuario);
                    command.Parameters.AddWithValue("@PokemonId", idPokemon);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AgregarPokemonUsuario(int idUsuario, int idPokemon)
        {
            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();
                string queryAgregar = @"
                    INSERT INTO PokemonUsuario (UsuarioId, PokemonId, HP, Ataque, Defensa)
                    SELECT @UsuarioId, Id, HPBase, AtaqueBase, DefensaBase
                    FROM Pokemones
                    WHERE Id = @PokemonId";
                using (SqliteCommand command = new SqliteCommand(queryAgregar, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", idUsuario);
                    command.Parameters.AddWithValue("@PokemonId", idPokemon);
                    command.ExecuteNonQuery();          
                }
            }
        }
        public System.Data.DataTable CatalagoPokemon()
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();
                string queryTablaPokemon = "SELECT Id, Nombre FROM Pokemones";
                using (SqliteCommand command = new SqliteCommand(queryTablaPokemon, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
        public System.Data.DataTable PokemonPorUsuario(int idUsuario)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();

            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();

                string queryTablaPokemon = @"
                        SELECT 
                            p.Nombre AS 'Pokemon',
                            p.Tipo AS 'Tipo',
                            pu.Nivel AS 'Nivel',
                            pu.HP AS 'HP',
                            pu.Ataque AS 'Ataque',
                            pu.Defensa AS 'Defensa',
                            pu.BatallasGanadasPK AS 'Victorias'
                        FROM PokemonUsuario pu
                        INNER JOIN Pokemones p ON pu.PokemonId = p.Id
                        WHERE pu.UsuarioId = @Id";

                using (SqliteCommand command = new SqliteCommand(queryTablaPokemon, connection))
                {
                    command.Parameters.AddWithValue("@Id", idUsuario);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        public bool RegistrarUsuario(string Nombreusuario, string contraseña)
        {
            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                connection.Open();

                string queryVerificar = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @Nombreusuario";

                using (SqliteCommand command = new SqliteCommand(queryVerificar, connection))
                {
                    command.Parameters.AddWithValue("@Nombreusuario", Nombreusuario);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        return false; // El usuario ya existe
                    }
                }

                string queryAgregar = "INSERT INTO Usuarios (NombreUsuario, Contraseña, BatallasGanadas) VALUES (@Nombreusuario, @Contraseña, 0)";
                using (SqliteCommand command = new SqliteCommand(queryAgregar, connection))
                {
                    command.Parameters.AddWithValue("@Nombreusuario", Nombreusuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
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
