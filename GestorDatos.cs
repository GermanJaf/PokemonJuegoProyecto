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
        private SqliteConnection conn;

        public GestorDatos()
        {
            conn = new SqliteConnection("Data Source=PokemonJuego.db");
            conn.Open();
        }
    }
}
