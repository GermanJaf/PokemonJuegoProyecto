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
            comboBox1.MaxDropDownItems = 8;

            DataTable ListaRival = gestorDatos.ListaPokemon();
            comboBox2.DataSource = ListaRival;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Id";
            comboBox2.MaxDropDownItems = 8;

            comboBox3.Items.Clear();
            for(int i = 1; i <= 100; i++)
            {
                comboBox3.Items.Add(i);
            }
            comboBox3.SelectedIndex = 0;
            comboBox3.MaxDropDownItems = 8;
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
            if (comboBox2.SelectedValue == null || comboBox3.SelectedItem == null)
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
            miPokemon.CuraMaxima();
            rivalPokemon.CuraMaxima();

            int IdRegistroUsuario = Convert.ToInt32(comboBox1.SelectedValue); 
            PantallaGameplayPractica pantallaGameplay = new PantallaGameplayPractica(miPokemon, rivalPokemon, IdRegistroUsuario);
            pantallaGameplay.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView row = (DataRowView)comboBox1.SelectedItem;
                string nombrePokemon = row["PokemonConNivel"].ToString().Split(' ')[0].Trim();

                GestorVisual.CargarImagenPokemon(pictureBoxPokemonUsuario, nombrePokemon, true);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                DataRowView row = (DataRowView)comboBox2.SelectedItem;
                string nombrePokemon = row["Nombre"].ToString();

                GestorVisual.CargarImagenPokemon(pictureBoxPokemonRival, nombrePokemon, true);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPokemonUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPokemonRival_Click(object sender, EventArgs e)
        {

        }
    }
}
