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
                object obj = Properties.Resources.ResourceManager.GetObject(nombreRecurso);
                if (obj != null)
                {
                    picBox.Image = (Image)obj;
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { }
        }
    }
}
   