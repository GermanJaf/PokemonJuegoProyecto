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
    public partial class PantallaConfigTorneo_ : Form
    {
        private int idUsuario;
        private PokeDaVI miPokemonTorneo;

        public PantallaConfigTorneo_(int idusuario)
        {
            InitializeComponent();
            idUsuario = idusuario;
        }

        private void PantallaConfigTorneo__Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for(int i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;

            GestorDatos gestorDatos = new GestorDatos();
            DataTable ListaUsuarioT = gestorDatos.PokemonUsuarioConNivel(idUsuario);
            comboBox2.DataSource = ListaUsuarioT;
            comboBox2.DisplayMember = "PokemonConNivel";
            comboBox2.ValueMember = "RegistroId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            PantallaTorneos pantallaTorneos = new PantallaTorneos();
            pantallaTorneos.Show();
            this.Hide();
        }

        private void buttonComenzarTorneo_Click(object sender, EventArgs e)
        {
            int cantidadOponentes = 0;
            int checkseleccionados = 0;

            if (checkBoxDFacil.Checked)
            {
                checkseleccionados++;
                cantidadOponentes = 3;
            }
            if (checkBoxDMedio.Checked)
            {
                checkseleccionados++;
                cantidadOponentes = 6;
            }
            if (checkBoxDDificil.Checked)
            {
                checkseleccionados++;
                cantidadOponentes = 9;
            }

            if(checkseleccionados == 0)
            {
                MessageBox.Show("Por favor seleccione una dificultad");
                return;
            }else if(checkseleccionados == 1)
            {
                MessageBox.Show("ERROR: Solo puedes escoger uno");
                return;
            }

            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Favor de escoger un nivel");
                return;
            }
            int nivelElegidoTorneo = Convert.ToInt32(comboBox1.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionPokemonT_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedValue == null)
            {
                return;
            }

            int idRegistro = Convert.ToInt32(comboBox2.SelectedValue);

            GestorDatos gestorDatos = new GestorDatos();
            miPokemonTorneo = gestorDatos.PokemonUsuarioCombate(idRegistro);
            MessageBox.Show($"Haz seleccionado {miPokemonTorneo.Nombre} con el nivel {miPokemonTorneo.Nivel} para este torneo");
        }
    }
}
