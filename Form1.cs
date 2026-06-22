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
    public partial class Form1 : Form
    {
        public Form1()
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
                // Aquí puedes abrir la siguiente ventana o realizar otras acciones después del inicio de sesión exitoso.
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
            string NuevoNombreusuario = usuariologinbox.Text;
            string Nuevocontraseña = contraseñalogintext.Text;

            if (string.IsNullOrEmpty(NuevoNombreusuario) || string.IsNullOrEmpty(Nuevocontraseña))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y contraseña válidos.");
                return;
            }

            GestorDatos gestorDatos = new GestorDatos();
            bool registroExitoso = gestorDatos.RegistrarUsuario(NuevoNombreusuario, Nuevocontraseña);

            if (registroExitoso) { 
                MessageBox.Show("Registro exitoso. Ahora puedes iniciar sesión con tu nuevo usuario.");
            }
            else
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro nombre de usuario.");
            }
        }
    }
}
