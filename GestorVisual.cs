using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonJuegoProyecto
{
    public class GestorVisual
    {
        public static void CargarImagenPokemon(PictureBox picBox, string nombrePokemon, bool esFrente)
        {
            string nombreRecurso = nombrePokemon.ToLower().Replace(" ", "");

            if (esFrente)
            {
                nombreRecurso += "_frente";
            }

            try
            {
                object obj = PokemonJuegoProyecto.Properties.Resources.ResourceManager.GetObject(nombreRecurso);
                if (obj != null)
                {
                    picBox.Image = (Image)obj;
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { }
        }
        public static void CargarIconoTipo(PictureBox pb, string tipo)
        {
            var imagen = Properties.Resources.ResourceManager.GetObject(tipo);

            if (imagen != null)
            {
                pb.Image = (Image)imagen;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pb.BackColor = Color.Magenta;
            }
        }
    }
}
   