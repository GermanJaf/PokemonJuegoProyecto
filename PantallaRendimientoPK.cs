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
    public partial class PantallaRendimientoPK : Form
    {
        private int idUsuario;
        public PantallaRendimientoPK(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }
        public PantallaRendimientoPK()
        {
            InitializeComponent();
        }

        private void PantallaRendimientoPK_Load(object sender, EventArgs e)
        {
            GestorDatos gestorDatos = new GestorDatos();
            ListaGanadasPokemon.DataSource = gestorDatos.RendimientoPokemon(idUsuario);
            ListaGanadasPokemon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ListaGanadasPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonVolverPT_Click(object sender, EventArgs e)
        {
            PantallaTorneos pantallaTorneos = new PantallaTorneos(idUsuario);
            pantallaTorneos.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
