using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonJuegoProyecto
{
    internal class Pokemon
    {
        public class Pokemons
        {
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public int Nivel { get; set; }
            public Pokemons(string nombre, string tipo, int nivel)
            {
                Nombre = nombre;
                Tipo = tipo;
                Nivel = nivel;
            }
            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Tipo: {Tipo}");
                Console.WriteLine($"Nivel: {Nivel}");
            }


        } 
    }
}
