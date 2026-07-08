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
            log.TopIndex = log.Items.Count - 1;
        }

        public string ObtenerNombreImagenBoton(string tipo, bool seleccionado)
        {
            string nombreBase = "btn_" + tipo.ToLower();

            if (seleccionado)
            {
                return nombreBase + "_iluminado";
            }
            else
            {
                return nombreBase + "_normal";
            }
        }

        public int CalcularAnchoBarra(int hpActual, int hpMax, int anchoMaximo)
        {
            if (hpActual < 0) hpActual = 0;
            return (int)((double)hpActual / hpMax * anchoMaximo);
        }

        public Color ObtenerColorVida(int hpActual, int hpMax)
        {
            double porcentaje = (double)hpActual / hpMax;

            if (porcentaje > 0.6)
                return Color.FromArgb(0, 200, 0); // Verde (más de 50%)
            else if (porcentaje > 0.2)
                return Color.Yellow;              // Amarillo (entre 20% y 50%)
            else
                return Color.Red;                 // Rojo (crítico, menos de 20%)
        }
    }
}
