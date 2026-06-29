using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonJuegoProyecto
{
    public class Ataque
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Tipo { get; }
        public int Poder { get; }
        public int Precision { get; }

        public Ataque(int id, string nombre, string tipo, int poder, int precision)
        {
           Id = id;
           Nombre = nombre;
           Tipo = tipo;
           Poder = poder;
           Precision = precision;
        }
    }
}