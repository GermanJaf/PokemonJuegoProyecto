using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonJuegoProyecto
{
    public class PokeTipos
    {
        public static double Efectividad(string tipoAtaque, string tipoDefensor)
        { 
        switch (tipoAtaque)
            {
                case "Normal": if (tipoDefensor == "Fantasma") return 0.0; break;
                case "Fuego":
                    if (tipoDefensor == "Planta" || tipoDefensor == "Hielo" || tipoDefensor == "Bicho") return 2.0;
                    if (tipoDefensor == "Fuego" || tipoDefensor == "Agua" || tipoDefensor == "Dragón") return 0.5;
                    break;
                case "Agua":
                    if (tipoDefensor == "Fuego" || tipoDefensor == "Tierra") return 2.0;
                    if (tipoDefensor == "Agua" || tipoDefensor == "Planta" || tipoDefensor == "Dragón") return 0.5;
                    break;
                case "Planta":
                    if (tipoDefensor == "Agua" || tipoDefensor == "Tierra") return 2.0;
                    if (tipoDefensor == "Fuego" || tipoDefensor == "Planta" || tipoDefensor == "Veneno" || tipoDefensor == "Volador" || tipoDefensor == "Bicho" || tipoDefensor == "Dragón") return 0.5;
                    break;
                case "Eléctrico":
                    if (tipoDefensor == "Agua" || tipoDefensor == "Volador") return 2.0;
                    if (tipoDefensor == "Eléctrico" || tipoDefensor == "Planta" || tipoDefensor == "Dragón") return 0.5;
                    if (tipoDefensor == "Tierra") return 0.0;
                    break;
                case "Hielo":
                    if (tipoDefensor == "Planta" || tipoDefensor == "Tierra" || tipoDefensor == "Volador" || tipoDefensor == "Dragón") return 2.0;
                    if (tipoDefensor == "Fuego" || tipoDefensor == "Agua" || tipoDefensor == "Hielo") return 0.5;
                    break;
                case "Lucha":
                    if (tipoDefensor == "Normal" || tipoDefensor == "Hielo") return 2.0;
                    if (tipoDefensor == "Veneno" || tipoDefensor == "Volador" || tipoDefensor == "Psíquico" || tipoDefensor == "Bicho") return 0.5;
                    if (tipoDefensor == "Fantasma") return 0.0;
                    break;
                case "Veneno":
                    if (tipoDefensor == "Planta") return 2.0;
                    if (tipoDefensor == "Veneno" || tipoDefensor == "Tierra" || tipoDefensor == "Fantasma") return 0.5;
                    break;
                case "Tierra":
                    if (tipoDefensor == "Fuego" || tipoDefensor == "Eléctrico" || tipoDefensor == "Veneno") return 2.0;
                    if (tipoDefensor == "Planta" || tipoDefensor == "Bicho") return 0.5;
                    if (tipoDefensor == "Volador") return 0.0;
                    break;
                case "Volador":
                    if (tipoDefensor == "Planta" || tipoDefensor == "Lucha" || tipoDefensor == "Bicho") return 2.0;
                    if (tipoDefensor == "Eléctrico") return 0.5;
                    break;
                case "Psíquico":
                    if (tipoDefensor == "Lucha" || tipoDefensor == "Veneno") return 2.0;
                    if (tipoDefensor == "Psíquico") return 0.5;
                    if (tipoDefensor == "Siniestro") return 0.0;
                    break;
                case "Bicho":
                    if (tipoDefensor == "Planta" || tipoDefensor == "Psíquico" || tipoDefensor == "Siniestro") return 2.0;
                    if (tipoDefensor == "Fuego" || tipoDefensor == "Lucha" || tipoDefensor == "Veneno" || tipoDefensor == "Volador" || tipoDefensor == "Fantasma") return 0.5;
                    break;
                case "Fantasma":
                    if (tipoDefensor == "Psíquico" || tipoDefensor == "Fantasma") return 2.0;
                    if (tipoDefensor == "Siniestro") return 0.5;
                    if (tipoDefensor == "Normal") return 0.0;
                    break;
                case "Dragón": if (tipoDefensor == "Dragón") return 2.0; break;
                case "Siniestro":
                    if (tipoDefensor == "Psíquico" || tipoDefensor == "Fantasma") return 2.0;
                    if (tipoDefensor == "Lucha" || tipoDefensor == "Siniestro") return 0.5;
                    break;
            }
            return 1.0;
        }
    }
}
