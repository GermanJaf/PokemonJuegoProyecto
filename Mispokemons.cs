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
    public partial class Mispokemons : Form
    {
        private int idUsuario;
        public Mispokemons()
        {
            InitializeComponent();
        }
        public Mispokemons(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void ListaPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mispokemons_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolverPI_Click(object sender, EventArgs e)
        {
            PantallaInicio pantallaInicio = new PantallaInicio(idUsuario);
            pantallaInicio.Show();
            this.Hide();
        }

        private void buttonAgregarPK_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bottonSN_Click(object sender, EventArgs e)
        {

        }
        private void LabelPtsNivel_Click(object sender, EventArgs e)
        {

        }
    }
}
