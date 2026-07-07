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
        public static void CargarIconoTipo(PictureBox pb, string tipo)
        {
            object recurso = Properties.Resources.ResourceManager.GetObject(tipo);

            if (recurso == null)
            {
                MessageBox.Show("¡ERROR! No existe ninguna imagen en Resources que se llame exactamente: " + tipo);
                pb.BackColor = Color.Black;
            }
            else
            {
                pb.Image = (Image)recurso;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show("¡Imagen encontrada y cargada correctamente!");
            }
        }
    }
}
