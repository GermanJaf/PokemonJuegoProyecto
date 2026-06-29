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
        }

        private void buttonVolverPractica_Click(object sender, EventArgs e)
        {
            PantallaTorneos pantallaTorneos = new PantallaTorneos(idUsuario);
            pantallaTorneos.Show();
            this.Hide();
        }
    }
}
