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
    public partial class PantallaInicio : Form
    {
        private int idUsuario;
        public PantallaInicio(int id)
        {
            InitializeComponent();
            idUsuario = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPokedex_Click(object sender, EventArgs e)
        {
            Mispokemons mispokemons = new Mispokemons(idUsuario);
            mispokemons.Show();
            this.Hide();
        }

        private void buttonTorneo_Click(object sender, EventArgs e)
        {
            PantallaTorneos pantallaTorneos = new PantallaTorneos(idUsuario);
            pantallaTorneos.Show();
            this.Hide();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonVolverLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
