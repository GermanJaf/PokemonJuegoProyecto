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
    public partial class PantallGameplayaTorneo : Form
    {

        private PokeDaVI miPokemon;
        private PokeDaVI rivalPokemon;
        private int IdRegistroUsuario;
        private int pocionesRestantes;
        private int rivalesRestantes;
        private int nivelTorneo;
        private int rivalesTotales;
        public PantallGameplayaTorneo(PokeDaVI pokemonTorneo, int idPokemonSlc, int cantidadRivales, int nivel)
        {
            InitializeComponent();
            miPokemon = pokemonTorneo;
            miPokemon.CuraMaxima();
            IdRegistroUsuario = idPokemonSlc;
            rivalesTotales = cantidadRivales;
            rivalesRestantes = cantidadRivales;
            nivelTorneo = nivel;

            if (cantidadRivales == 3)
            {
                pocionesRestantes = 1;
            } else if (cantidadRivales == 6)
            {
                pocionesRestantes = 2;
            } else if (cantidadRivales == 9)
            {
                pocionesRestantes = 3;
            }
        }
        private void GeneradorRival()
        {
            GestorDatos gestorDatos = new GestorDatos();

            rivalPokemon = gestorDatos.PokemonAleatorio(nivelTorneo);
            rivalPokemon.CuraMaxima();

            labelPokemonUsuario.Text = miPokemon.Nombre;
            labelPokemonRival.Text = rivalPokemon.Nombre;

            ActualizarVida();
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

            MessageBox.Show($"{miPokemon.Nombre} uso {ataqueUsado.Nombre} y causo {dañoRealizado} puntos de daño");

            ActualizarVida();

            if (rivalPokemon.Debilitado())
            {
                GestorDatos gestorDatos = new GestorDatos();
                gestorDatos.RegistrarVictorias(IdRegistroUsuario);

                rivalesRestantes--;

                if (rivalesRestantes > 0)
                {
                    MessageBox.Show("Felicidades haz superado al rival. AHORA VA EL SIGUIENTE");
                    GeneradorRival();
                }
                else
                {
                    MessageBox.Show("FELICIDADES HAZ GANADO EL TORNEO");
                    GestorDatos gestor = new GestorDatos();
                    gestor.RegistrarBatalla(

                        IdRegistroUsuario,
                        miPokemon.Id,
                        miPokemon.Nivel,
                        rivalPokemon.Nombre,
                        rivalPokemon.Nivel,
                        "Ganada");
                    this.Close();
                }
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

            miPokemon.RecibirDaño(dañoRealizadoR);
            MessageBox.Show($"{rivalPokemon.Nombre} rival uso {ataqueUsadoR.Nombre} y te ha hecho {dañoRealizadoR} puntos de daño");

            ActualizarVida();

            if (miPokemon.Debilitado())
            {
                MessageBox.Show("Tu pokemon se ha debilitado, haz perdido la batalla");
                GestorDatos gestor = new GestorDatos();
                gestor.RegistrarBatalla(

                    IdRegistroUsuario,
                    miPokemon.Id,
                    miPokemon.Nivel,
                    rivalPokemon.Nombre,
                    rivalPokemon.Nivel,
                    "Perdido");

                this.Close();
            }
        }

        private void btnSanar_Click(object sender, EventArgs e)
        {
            if (pocionesRestantes <= 0)
            {
                return;
            }
            if (miPokemon.HPActual >= miPokemon.HPMax)
            {
                MessageBox.Show("Tu pokémon ya tiene la vida al máximo.");
                return;
            }

            int cantidadCurar = 50;
            miPokemon.RecibirDaño(-cantidadCurar);

            pocionesRestantes--;

            if (pocionesRestantes == 0)
            {
                btnSanar.Enabled = false;
            }

            lblCantidadHP.Text = $"Pociones restantes = {pocionesRestantes}";

            MessageBox.Show($"¡Has curado a {miPokemon.Nombre}! Recupero {cantidadCurar}HP.");
            ActualizarVida();
            TurnoRival();
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

        private void btnAbandonar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Realmente quieres salir?", "Abandonar torneo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                GestorDatos gestor = new GestorDatos();
                gestor.RegistrarBatalla(

                    IdRegistroUsuario,
                    miPokemon.Id,
                    miPokemon.Nivel,
                    rivalPokemon.Nombre,
                    rivalPokemon.Nivel,
                    "Abandonada");
                this.Close();
            }
        }

        private void PantallaTorneo_Load(object sender, EventArgs e)
        {
            if (miPokemon.MisAtaques[0] != null)
            {
                button1.Text = miPokemon.MisAtaques[0].Nombre;
            }
            if(miPokemon.MisAtaques[1] != null)
            {
                button2.Text = miPokemon.MisAtaques[1].Nombre;
            }
            if (miPokemon.MisAtaques[2] != null)
            {
                button3.Text = miPokemon.MisAtaques[2].Nombre;
            }
            if (miPokemon.MisAtaques[3] != null)
            {
                button4.Text = miPokemon.MisAtaques[3].Nombre;
            }

            lblCantidadHP.Text = $"Pociones restantes = {pocionesRestantes}";

            GeneradorRival();
        }

        private void labelvidaRival_Click(object sender, EventArgs e)
        {

        }

        private void labelvidaUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
