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
            GestorDatos gestorDatos = new GestorDatos();

            int idPokemon = Convert.ToInt32(comboBox1.SelectedValue);
            string NombrePokemon = comboBox1.Text;

            gestorDatos.AgregarPokemon(idUsuario, idPokemon);
            MessageBox.Show($"{NombrePokemon} se agrego a tu equipo");
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
