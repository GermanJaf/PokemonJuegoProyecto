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
            string nombreImagen = nombrePokemon.ToLower();
            if (esFrente)
            {
                nombreImagen += "_frente";
            }

            var imagenEncontrada = Properties.Resources.ResourceManager.GetObject(nombreImagen);

            if (imagenEncontrada != null)
            {
                picBox.Image = (Image)imagenEncontrada;
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        public static void CargarIconoTipo(PictureBox pb, string tipo)
        {
            var imagen = Properties.Resources.ResourceManager.GetObject(tipo);

            if (imagen != null)
            {
                pb.Image = (Image)imagen;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
   