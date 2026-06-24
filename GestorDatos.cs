using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using SQLiteUtil;
using System.Windows.Forms;
using System.Data;

namespace PokemonJuegoProyecto
{
    public class GestorDatos
    {
        private SqliteConnection conn;
        public GestorDatos()
        {
            conn = new SqliteConnection("Data Source=Pokedex.db");
            conn.Open();
        }

        public DataTable PokemonesPorUsuario (int idUsuario)
        {
            DataTable tabla = new DataTable();

            string queryLista = @"
                SELECT p.Nombre AS Nombre,
                       pu.Nivel AS Nivel,
                       p.Tipo AS Tipo,
                       pu.HP AS Vida,
                       pu.Ataque AS Ataque,
                       pu.Defensa AS Defensa
                FROM PokemonUsuario pu
                INNER JOIN Pokemones p ON pu.PokemonId = p.Id
                WHERE pu.UsuarioId = @idUsuario";

            var rs = conn.ExecuteReader(queryLista, ("@idUsuario", idUsuario));

            tabla.Load(rs);
            return tabla;
        }
        public bool RegistrarUsuario(string Nombreusuario, string contraseña)
        {
            string queryRegistro = "INSERT INTO Usuarios (NombreUsuario, Contraseña, BatallasGanadas) VALUES (@Nombreusuario, @contraseña, 0)";

            int Registro = conn.ExecuteNonQuery(queryRegistro, ("@Nombreusuario", Nombreusuario), ("@contraseña", contraseña));

            return Registro > 0;
        }
        public Usuarios IniciarSesion(string Nombreusuario, string contraseña)
        {
            Usuarios usuarioiniciado = null;

            string queryIniciador = "SELECT Id, NombreUsuario, BatallasGanadas FROM Usuarios WHERE NombreUsuario = @Nombreusuario AND Contraseña = @contraseña";

            var rs = conn.ExecuteReader(queryIniciador, ("@Nombreusuario", Nombreusuario), ("@contraseña", contraseña));

            while (rs.Read())
            {
                usuarioiniciado = new Usuarios
                {
                    Id = rs.GetInt("Id"),
                    NombreUsuarios = rs.GetString("NombreUsuario"),
                    BatallasGanadas = rs.GetInt("BatallasGanadas")
                };
            }
            return usuarioiniciado;
        }
    }
}   
