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

        public DataTable ListaPokemon()
        {
            DataTable lista = new DataTable();

            string queryLista = "SELECT Id, Nombre, Tipo FROM Pokemones";

            var rs = conn.ExecuteReader(queryLista);
            lista.Load(rs);
            return lista;
        }
        public void AgregarPokemon(int idUsuario, int idPokemon)
        {
            string queryStat = "SELECT HPBase, AtaqueBase, DefensaBase FROM Pokemones WHERE Id = @idPokemon";
            var rs = conn.ExecuteReader(queryStat, ("@idPokemon", idPokemon));

            int hp = 0, ataque = 0, defensa = 0;
            if (rs.Read())
            {
                hp = rs.GetInt("HPBase");
                ataque = rs.GetInt("AtaqueBase");
                defensa = rs.GetInt("DefensaBase");
            }

            string queryAgregar = "INSERT INTO PokemonUsuario (UsuarioId, PokemonId, HP, Ataque, Defensa) VALUES (@idUsuario, @idPokemon, @hp, @ataque, @defensa)";
            conn.ExecuteNonQuery(queryAgregar, ("@idUsuario", idUsuario), ("@idPokemon", idPokemon), ("@hp", hp), ("@ataque", ataque), ("@defensa", defensa));
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
