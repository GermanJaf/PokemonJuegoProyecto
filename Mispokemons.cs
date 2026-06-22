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
        public Mispokemons(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void dgvPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mispokemons_Load(object sender, EventArgs e)
        {
            GestorDatos gestorDatos = new GestorDatos();
            DataTable pokemones = gestorDatos.PokemonPorUsuario(idUsuario);

            dgvPokemon.DataSource = pokemones;
            dgvPokemon.AllowUserToAddRows = false;
        }
    }
}
