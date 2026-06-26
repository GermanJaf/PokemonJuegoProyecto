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
            GestorDatos gestorDatos = new GestorDatos();
            ListaPokemon.DataSource = gestorDatos.PokemonesPorUsuario(idUsuario);

            DataTable table = gestorDatos.ListaPokemon();
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
        }

        private void buttonVolverPI_Click(object sender, EventArgs e)
        {
            PantallaInicio pantallaInicio = new PantallaInicio(idUsuario);
            pantallaInicio.Show();
            this.Hide();
        }

        private void buttonAgregarPK_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un Pokémon para agregar.");
                return;
            }

            int idPokemonSelected = Convert.ToInt32(comboBox1.SelectedValue);

            GestorDatos gestorDatos = new GestorDatos();
            gestorDatos.AgregarPokemon(idUsuario, idPokemonSelected);

            ListaPokemon.DataSource = gestorDatos.PokemonesPorUsuario(idUsuario);
            MessageBox.Show("Pokémon agregado correctamente.");
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
