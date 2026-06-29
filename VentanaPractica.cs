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
    public partial class VentanaPractica : Form
    {
        private PokeDaVI miPokemon;
        private PokeDaVI rivalPokemon;
        private int idUsuario;
        public VentanaPractica(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }
        public VentanaPractica()
        {
            InitializeComponent();
        }

        private void VentanaPractica_Load(object sender, EventArgs e)
        {
            GestorDatos gestorDatos = new GestorDatos();

            DataTable ListasUsuario = gestorDatos.PokemonUsuarioConNivel(idUsuario);
            comboBox1.DataSource = ListasUsuario;
            comboBox1.DisplayMember = "PokemonConNivel";
            comboBox1.ValueMember = "RegistroId";

            DataTable ListaRival = gestorDatos.ListaPokemon();
            comboBox2.DataSource = ListaRival;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Id";

            comboBox3.Items.Clear();
            for(int i = 1; i <= 100; i++)
            {
                comboBox3.Items.Add(i);
            }
            comboBox3.SelectedIndex = 0;
        }

        private void buttonVolverPractica_Click(object sender, EventArgs e)
        {
            PantallaTorneos pantallaTorneos = new PantallaTorneos(idUsuario);
            pantallaTorneos.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionU_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue == null)
            {
                return;
            }

            int idRegistro = Convert.ToInt32(comboBox1.SelectedValue);

            GestorDatos gestorDatos = new GestorDatos();
            miPokemon = gestorDatos.PokemonUsuarioCombate(idRegistro);
            MessageBox.Show($"Has seleccionado a {miPokemon.Nombre} con nivel {miPokemon.Nivel}");

        }

        private void buttonSeleccionR_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedValue == null || comboBox3.SelectedItem == null)
            {
                return;
            }

            int idPokemon = Convert.ToInt32(comboBox2.SelectedValue);
            int nivelElegido = Convert.ToInt32(comboBox3.SelectedItem);

            GestorDatos gestorDatos = new GestorDatos();
            rivalPokemon = gestorDatos.PokemonRivalCombate(idPokemon, nivelElegido);
            MessageBox.Show($"Has seleccionado a {rivalPokemon.Nombre} con nivel {nivelElegido}");
        }

        private void buttonInicarPractica_Click(object sender, EventArgs e)
        {
            if(miPokemon == null || rivalPokemon == null)
            {
                MessageBox.Show("Debes seleccionar ambos Pokémon antes de iniciar la práctica.");
                return;
            }
            int IdRegistroUsuario = Convert.ToInt32(comboBox1.SelectedValue); 
            PantallaGameplay pantallaGameplay = new PantallaGameplay(miPokemon, rivalPokemon, IdRegistroUsuario);
            pantallaGameplay.ShowDialog();
        }
    }
}
