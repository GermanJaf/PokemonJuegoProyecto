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
            DataTable pokemones = gestorDatos.PokemonPorUsuario(idUsuario);

            ListaPokemon.DataSource = pokemones;
            ListaPokemon.AllowUserToAddRows = false;

            comboBox1.DataSource = gestorDatos.CatalagoPokemon();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";

            int PuntosDisponibles = gestorDatos.PtsMejorDisponible(idUsuario);
            LabelPtsNivel.Text = $"Puntos de mejora {PuntosDisponibles}";
        }

        private void buttonVolverPI_Click(object sender, EventArgs e)
        {
            PantallaInicio pantallaInicio = new PantallaInicio(idUsuario);
            pantallaInicio.Show();
            this.Hide();
        }

        private void buttonAgregarPK_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue != null)
            {
                int idPokemon = Convert.ToInt32(comboBox1.SelectedValue);
                GestorDatos gestorDatos = new GestorDatos();
                gestorDatos.AgregarPokemonUsuario(idUsuario, idPokemon);

                DataTable pokemonesActualizados = gestorDatos.PokemonPorUsuario(idUsuario);
                ListaPokemon.DataSource = pokemonesActualizados;
                MessageBox.Show("¡Pokémon agregado exitosamente!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bottonSN_Click(object sender, EventArgs e)
        {
            GestorDatos gestorDatos = new GestorDatos();
            int PuntosDisponibles = gestorDatos.PtsMejorDisponible(idUsuario);

            if(PuntosDisponibles > 0)
            {
                if(comboBox1.SelectedValue != null)
                {
                    int idPokemon = Convert.ToInt32(comboBox1.SelectedValue);
                    gestorDatos.SubirNivelPK(idUsuario, idPokemon);

                    ListaPokemon.DataSource = gestorDatos.PokemonPorUsuario(idUsuario);
                    PuntosDisponibles = gestorDatos.PtsMejorDisponible(idUsuario);

                    LabelPtsNivel.Text = $"Puntos de mejora {PuntosDisponibles}";
                }
            }
        }
        private void LabelPtsNivel_Click(object sender, EventArgs e)
        {

        }
    }
}
