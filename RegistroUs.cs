using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteUtil;
using Microsoft.Data.Sqlite;
namespace PokemonJuegoProyecto
{
    public partial class RegistroUs : Form
    {
        private GestorDatos datos;
        public RegistroUs()
        {
            InitializeComponent();
            datos = new GestorDatos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text) || string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios y no pueden quedar vacíos o con espacios.");
                    return;
                }
                if (txtContrasena.Text != txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las contraseñas NO coinciden");
                    return;
                }
                string UsuariosLimpio = txtUsuario.Text.Trim();
                if (datos.ExisteUsuario(UsuariosLimpio))
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro.");
                    return;
                }
                bool exito = datos.RegistrarUsuario(UsuariosLimpio, txtContrasena.Text);
                if (exito)
                {
                    MessageBox.Show("¡Usuario creado con éxito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar el usuario en la base de datos.");
                }
            }

        }
    }
}