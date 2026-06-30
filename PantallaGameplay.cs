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
    public partial class PantallaGameplay : Form
    {
        private PokeDaVI miPokemon;
        private PokeDaVI rivalPokemon;
        private int IdRegistroUsuario;
        public PantallaGameplay(PokeDaVI usuario, PokeDaVI rival, int idPokemonRegistro)
        {
            InitializeComponent();
            miPokemon = usuario;
            rivalPokemon = rival;
            IdRegistroUsuario = idPokemonRegistro;
        }
        private void ActualizarVida()
        {
            labelvidaUsuario.Text = $"{miPokemon.HPActual}/{miPokemon.HPMax}";
            labelvidaRival.Text = $"{rivalPokemon.HPActual}/{rivalPokemon.HPMax}";
        }
        private void EjecutarDaño(int AtaqueSeleccion)
        {
            if (miPokemon.MisAtaques[AtaqueSeleccion] == null)
            {
                return;
            }

            Ataque ataqueUsado = miPokemon.MisAtaques[AtaqueSeleccion];

            string mensajeInGame;

            int dañoRealizado = miPokemon.Atacar(rivalPokemon, ataqueUsado, out mensajeInGame);
            rivalPokemon.RecibirDaño(dañoRealizado);

            labelComentarios.Text = mensajeInGame;

            MessageBox.Show($"{miPokemon.Nombre} uso {ataqueUsado.Nombre} y causo {dañoRealizado} puntos de daño");

            ActualizarVida();

            if (rivalPokemon.Debilitado())
            {
                GestorDatos gestorDatos = new GestorDatos();
                gestorDatos.RegistrarVictorias(IdRegistroUsuario);

                MessageBox.Show("Felicidades haz ganado");
                this.Close();
                return;
            }

            TurnoRival();
        }
        private void TurnoRival()
        {
            Random rnd = new Random();
            int AtaqueAleatorio = rnd.Next(0, 4);

            while (rivalPokemon.MisAtaques[AtaqueAleatorio] == null)
            {
                AtaqueAleatorio = rnd.Next(0, 4);
            }

            Ataque ataqueUsadoR = rivalPokemon.MisAtaques[AtaqueAleatorio];

            string mensajeInGameRival;

            int dañoRealizadoR = rivalPokemon.Atacar(miPokemon, ataqueUsadoR, out mensajeInGameRival);

            labelComentarios.Text = mensajeInGameRival;

            miPokemon.RecibirDaño(dañoRealizadoR);
            MessageBox.Show($"{rivalPokemon.Nombre} rival uso {ataqueUsadoR.Nombre} y te ha hecho {dañoRealizadoR} puntos de daño");

            ActualizarVida();

            if (miPokemon.Debilitado())
            {
                MessageBox.Show("Tu pokemon se ha debilitado, haz perdido la batalla");
                this.Close();
            }
        }

        private void labelPokemonRival_Click(object sender, EventArgs e)
        {

        }

        private void labelPokemonUsuario_Click(object sender, EventArgs e)
        {

        }

        private void labelvidaRival_Click(object sender, EventArgs e)
        {

        }

        private void labelvidaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void PantallaGameplay_Load(object sender, EventArgs e)
        {
            labelPokemonUsuario.Text = miPokemon.Nombre;
            labelPokemonRival.Text = rivalPokemon.Nombre;

            if (miPokemon.MisAtaques[0] != null)
            {
                button1.Text = miPokemon.MisAtaques[0].Nombre;
            }
            if(miPokemon.MisAtaques[1] != null)
            {
                button2.Text = miPokemon.MisAtaques[1].Nombre;
            }
            if(miPokemon.MisAtaques[2] != null)
            {
                button3.Text = miPokemon.MisAtaques[2].Nombre;
            }
            if(miPokemon.MisAtaques[3] != null)
            {
                button4.Text = miPokemon.MisAtaques[3].Nombre;
            }

            ActualizarVida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EjecutarDaño(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EjecutarDaño(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EjecutarDaño(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EjecutarDaño(3);
        }

        private void labelComentarios_Click(object sender, EventArgs e)
        {

        }

        private void button5Retirarse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
