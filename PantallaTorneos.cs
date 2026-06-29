using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonJuegoProyecto
{
    public partial class PantallaTorneos : Form
    {
        private int idUsuario;
        public PantallaTorneos (int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }
        public PantallaTorneos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BottonPRendimiento_Click(object sender, EventArgs e)
        {
            PantallaRendimientoPK pantallaRendimientoPK = new PantallaRendimientoPK(idUsuario);
            pantallaRendimientoPK.Show();
            this.Hide();
        }

        private void BottonVolverPT_Click(object sender, EventArgs e)
        {
            PantallaInicio pantallaInicio = new PantallaInicio(idUsuario);
            pantallaInicio.Show();
            this.Hide();
        }

        private void buttonPractica_Click(object sender, EventArgs e)
        {
            VentanaPractica ventanaPractica = new VentanaPractica(idUsuario);
            ventanaPractica.Show();
            this.Hide();
        }
    }
}
