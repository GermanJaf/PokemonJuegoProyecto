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

        private void dgvPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mispokemons_Load(object sender, EventArgs e)
        {
            GestorDatos gestorDatos = new GestorDatos();
            DataTable pokemones = gestorDatos.PokemonPorUsuario(idUsuario);

            dgvPokemon.DataSource = pokemones;
            dgvPokemon.AllowUserToAddRows = false;

            comboBox1.DataSource = gestorDatos.CatalagoPokemon();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";

            int PuntosDisponibles = gestorDatos.ObtenerPtsMejora(idUsuario);
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
                // Actualizar el DataGridView después de agregar el Pokémon
                DataTable pokemonesActualizados = gestorDatos.PokemonPorUsuario(idUsuario);
                dgvPokemon.DataSource = pokemonesActualizados;
                MessageBox.Show("¡Pokémon agregado exitosamente!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bottonSN_Click(object sender, EventArgs e)
        {
            GestorDatos gestorDatos = new GestorDatos();
            int PuntosDisponibles = gestorDatos.ObtenerPtsMejora(idUsuario);

            if(PuntosDisponibles > 0)
            {
                if(comboBox1.SelectedValue != null)
                {
                    int idPokemon = Convert.ToInt32(comboBox1.SelectedValue);
                    gestorDatos.SubirNivelPK(idUsuario, idPokemon);
                    dgvPokemon.DataSource = gestorDatos.PokemonPorUsuario(idUsuario) ;

                    PuntosDisponibles = gestorDatos.ObtenerPtsMejora(idUsuario);
                    LabelPtsNivel.Text = $"Puntos de mejora: {PuntosDisponibles}";

                    MessageBox.Show("Haz mejora tu pokemon con exito");

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un Pokémon para subir de nivel.");
                }
            }
            else
            {
                MessageBox.Show("No tienes puntos de mejora disponibles.");
            }
        }

        private void LabelPtsNivel_Click(object sender, EventArgs e)
        {

        }
    }
}
