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
        public void RegistrarBatalla(int usuarioId, int pokemonId, string faseLograda)
        {
            string query = @"INSERT INTO HistorialTorneos (UsuarioId, PokemonID, FaseLograda) 
                    VALUES (@usuarioId, @pokemonId, @faseLograda)";
            conn.ExecuteNonQuery(query,
                ("@usuarioId", usuarioId),
                ("@pokemonId", pokemonId),
                ("@faseLograda", faseLograda));
        }


        public PokeDaVI PokemonAleatorio(int nivelElegidoTorneo)
        {
            int idRandom = 1;

            string queryPKAleatorio = "SELECT Id FROM Pokemones ORDER BY RANDOM() LIMIT 1";

            var rs = conn.ExecuteReader(queryPKAleatorio);
            if (rs.Read())
            {
                idRandom = Convert.ToInt32(rs["Id"]);
            }
            rs.Close();

            return PokemonRivalCombate(idRandom, nivelElegidoTorneo);
        }
        public bool ExisteUsuario(string nombreUsuario)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario";
            var rs = conn.ExecuteReader(query, ("@usuario", nombreUsuario));

            int conteo = 0;
            if (rs.Read())
            {
                conteo = rs.GetInt32(0);
            }
            rs.Close();

            return conteo > 0;
        }
        public void RegistrarVictorias(int idRegistro)
        {
            string queryRegistro = "UPDATE PokemonUsuario SET BatallasGanadasPK = BatallasGanadasPK +1 WHERE Id = @idRegistro";

            conn.ExecuteNonQuery(queryRegistro, ("@idRegistro", idRegistro));
        }
        public Ataque[] AtaquedePokemones(int idPokemon)
        {
            Ataque[] ataques = new Ataque[4];

            string queryAtaques = @"
                SELECT a.Id, a.Nombre, a.Tipo, a.Poder, a.Presicion
                FROM Pokemones p
                JOIN Ataques a ON a.Id IN (p.Ataque1Id, p.Ataque2Id, p.Ataque3Id, p.Ataque4Id)
                WHERE p.Id = $Id";

            var rs = conn.ExecuteReader(queryAtaques, ("$Id", idPokemon));

            int i = 0;
            while(rs.Read() && i < 4)
            {
                ataques[i] = new Ataque(
                    rs.GetInt("Id"),
                    rs.GetString("Nombre"),
                    rs.GetString("Tipo"),
                    rs.GetInt("Poder"),
                    rs.GetInt("Presicion")
                    );
                i++;
            }
            rs.Close();
            return ataques;
        }
        public PokeDaVI PokemonRivalCombate(int idPokemon, int nivelElegido)
        {
            PokeDaVI rivalpokemon = null;

            string queryPokemonR = @"
               SELECT Id, Nombre, Tipo, HPBase, AtaqueBase, DefensaBase
                FROM Pokemones
                WHERE Id = @idPokemon";

            var rs = conn.ExecuteReader(queryPokemonR, ("@idPokemon", idPokemon));
            if(rs.Read())
            {
                int hpBase = rs.GetInt("HPBase");
                int ataqueBase = rs.GetInt("AtaqueBase");
                int defensaBase = rs.GetInt("DefensaBase");

                int hpReal = hpBase + ((nivelElegido - 1) * 10);
                int ataqueReal = ataqueBase + ((nivelElegido - 1) * 5);
                int defensaReal = defensaBase + ((nivelElegido - 1) * 5);

                rivalpokemon = new PokeDaVI(
                    rs.GetInt("Id"),
                    rs.GetString("Nombre"),
                    rs.GetString("Tipo"),
                    nivelElegido,
                    hpReal,
                    ataqueReal,
                    defensaReal
                );

                rivalpokemon.MisAtaques = AtaquedePokemones(rs.GetInt("Id"));
            }
            rs.Close();
            return rivalpokemon;
        }
        public PokeDaVI PokemonUsuarioCombate(int idRegistro)
        {
            PokeDaVI miPokemon = null;

            string queryPokemonU = @"
               SELECT p.Id, p.Nombre, p.Tipo, pu.Nivel, pu.HP, pu.Ataque, pu.Defensa
                FROM PokemonUsuario pu
                INNER JOIN Pokemones p ON pu.PokemonId = p.Id
                WHERE pu.Id = @idRegistro";

            var rs = conn.ExecuteReader(queryPokemonU, ("@idRegistro", idRegistro));
            if (rs.Read())
            {
                miPokemon = new PokeDaVI(
                    rs.GetInt("Id"),
                    rs.GetString("Nombre"),
                    rs.GetString("Tipo"),
                    rs.GetInt("Nivel"),
                    rs.GetInt("HP"),
                    rs.GetInt("Ataque"),
                    rs.GetInt("Defensa")
                );

                miPokemon.MisAtaques = AtaquedePokemones(rs.GetInt("Id"));
            }
            rs.Close();
            return miPokemon;
        }
        public DataTable PokemonUsuarioConNivel(int idUsuario)
        {
            DataTable listaconnivel = new DataTable();

            string queryListaConNivel = @"
               SELECT pu.Id AS RegistroId,
                      p.Nombre || ' (Nivel ' || pu.Nivel || ')' AS PokemonConNivel
                FROM PokemonUsuario pu
                INNER JOIN Pokemones p ON pu.PokemonId = p.Id
                WHERE pu.UsuarioId = @idUsuario";

            var rs = conn.ExecuteReader(queryListaConNivel, ("@idUsuario", idUsuario));
            listaconnivel.Load(rs);
                
            return listaconnivel;
        }
        public DataTable RendimientoPokemon(int idUsuario)
        {
            DataTable listarendimiento = new DataTable();

            string queryRendimiento = @"
        SELECT p.Nombre AS [Mi Pokémon],
               pu.Nivel AS [Nivel]
               ht.FaseLograda As [Fase Lograda]
        FROM HistorialTorneos ht
        INNER JOIN Pokemones p ON ht.PokemonID = p.Id
        INNER JOIN PokemonUsuario pu ON pu.PokemonId = p.Id AND pu.UsuarioId = ht.UsuarioId
        WHERE ht.UsuarioId = @idUsuario
        ORDER BY ht.rowid DESC";

            var rs = conn.ExecuteReader(queryRendimiento, ("@idUsuario", idUsuario));

            listarendimiento.Load(rs);
            rs.Close();

            return listarendimiento;
        }
        public bool MejorarPk(int idRegistro, int idUsuario)
        {
            int PuntosAct = PuntosMejora(idUsuario);
            if(PuntosAct <= 0)
            {
                return false;
            }

            string queryMejorar = @"
               UPDATE PokemonUsuario
                SET Nivel = Nivel + 1,
                    HP = HP + 10,
                    Ataque = Ataque + 5,
                    Defensa = Defensa + 5
                WHERE Id = @idRegistro";

            conn.ExecuteNonQuery(queryMejorar, ("@idRegistro", idRegistro));

            string queryCobrar = "UPDATE Usuarios SET PuntosMejora = PuntosMejora - 1 WHERE Id = @idUsuario";
            conn.ExecuteNonQuery(queryCobrar, ("@idUsuario", idUsuario));

            return true;
        }
        public int PuntosMejora(int idUsuario)
        {
            int Puntos = 0;
            string queryPuntos = "SELECT PuntosMejora FROM Usuarios WHERE Id = @idUsuario";

            var rs = conn.ExecuteReader(queryPuntos, ("@idUsuario", idUsuario));
            if(rs.Read())
            {
                Puntos = rs.GetInt("PuntosMejora");
            }
            rs.Close();

            return Puntos;
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

            rs.Close();

            string queryAgregar = "INSERT INTO PokemonUsuario (UsuarioId, PokemonId, HP, Ataque, Defensa) VALUES (@idUsuario, @idPokemon, @hp, @ataque, @defensa)";
            conn.ExecuteNonQuery(queryAgregar, ("@idUsuario", idUsuario), ("@idPokemon", idPokemon), ("@hp", hp), ("@ataque", ataque), ("@defensa", defensa));
        }
        public DataTable PokemonesPorUsuario (int idUsuario)
        {
            DataTable tabla = new DataTable();

            string queryLista = @"
                SELECT pu.Id AS IdRegistro,
                       p.Nombre AS Nombre,
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
