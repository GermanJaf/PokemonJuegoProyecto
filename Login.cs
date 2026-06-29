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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void iniciologinbotton_Click(object sender, EventArgs e)
        {
            string Nombreusuario = usuariologinbox.Text;
            string contraseña = contraseñalogintext.Text;

            if(string.IsNullOrEmpty(Nombreusuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y contraseña válidos.");
                return;
            }

            GestorDatos gestorDatos = new GestorDatos();
            Usuarios usuario = gestorDatos.IniciarSesion(Nombreusuario, contraseña);

            if(usuario != null)
            {
                MessageBox.Show("Inicio de sesión exitoso. ¡Bienvenido, " + usuario.NombreUsuarios + "!");
                PantallaInicio menuprincipal = new PantallaInicio(usuario.Id);
                menuprincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.");
            } 
        }

        private void usuariologinbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseñalogintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoUsuarioLogin_Click(object sender, EventArgs e)
        {
            RegistroUs ventanaRegistro = new RegistroUs();
            ventanaRegistro.ShowDialog();
        }
    }
}
