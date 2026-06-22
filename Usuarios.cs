using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonJuegoProyecto
{
    public class Usuarios
    {

        public int Id { get; set; }
        public string NombreUsuarios { get; set; }
        public string ContraseUsuarios { get; set; }
        public int BatallasGanadas { get; set; }

        public Usuarios()
        {
        }
        public Usuarios(int id, string nombreUsuarios, string contraseUsuarios, int batallasGanadas)
        {
            Id = id;    
            NombreUsuarios = nombreUsuarios;
            ContraseUsuarios = contraseUsuarios;
            BatallasGanadas = batallasGanadas;
        }
    }
}
