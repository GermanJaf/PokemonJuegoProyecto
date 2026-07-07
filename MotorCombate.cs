using PokemonJuegoProyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PokemonJuegoProyecto
{
    public class MotorCombate
    {
        public void EscribirEnLog(ListBox log, string mensaje)
        {
            log.Items.Add(mensaje);
            log.TopIndex = log.Items.Count - 1; // Para que el scroll baje solo
        }

        public string ObtenerNombreImagenBoton(string tipo, bool iluminado)
        {
            string estado = iluminado ? "_iluminado" : "_normal";
            return $"btn_{tipo.ToLower()}{estado}";
        }

        public void EscribirSeparador(ListBox log)
        {
            log.Items.Add("-----------------------------");
        }

        public int CalcularAnchoBarra(int hpActual, int hpMax, int anchoMaximo)
        {
            if (hpActual < 0) hpActual = 0;
            return (int)((double)hpActual / hpMax * anchoMaximo);
        }

        public void AgregarAlLog(ListBox log, string mensaje)
        {
            log.Items.Add(mensaje);
            log.TopIndex = log.Items.Count - 1;
        }

        public Image ObtenerSprite(string nombrePokemon, bool esEspalda)
        {
            string nombreImagen = nombrePokemon.ToLower();
            if (!esEspalda) nombreImagen += "_frente";
            return (Image)Properties.Resources.ResourceManager.GetObject(nombreImagen);
        }
        public Color ObtenerColorVida(int hpActual, int hpMax)
        {
            double porcentaje = (double)hpActual / hpMax;

            if (porcentaje > 0.5)
                return Color.FromArgb(0, 200, 0); // Verde (más de 50%)
            else if (porcentaje > 0.2)
                return Color.Yellow;              // Amarillo (entre 20% y 50%)
            else
                return Color.Red;                 // Rojo (crítico, menos de 20%)
        }
    }
}
