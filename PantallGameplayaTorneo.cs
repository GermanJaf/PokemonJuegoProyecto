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
        private MotorCombate motor = new MotorCombate();
        private int contadorTurnos = 1;
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
            int porcentajeRival = (rivalPokemon.HPMax > 0) ? (rivalPokemon.HPActual * 100 / rivalPokemon.HPMax) : 0;

            labelvidaRival.Text = $"{porcentajeRival}%";

            panelFondoUsuario.Width = motor.CalcularAnchoBarra(miPokemon.HPActual, miPokemon.HPMax, 96);
            panelBarraUsuario.BackColor = motor.ObtenerColorVida(miPokemon.HPActual, miPokemon.HPMax);

            panelFondoRival.Width = motor.CalcularAnchoBarra(rivalPokemon.HPActual, rivalPokemon.HPMax, 110);
            panelBarraRival.BackColor = motor.ObtenerColorVida(rivalPokemon.HPActual, rivalPokemon.HPMax);
        }
        private void EjecutarDaño(int AtaqueSeleccion)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            motor.EscribirEnLog(listBoxLog, $"-------------  TURNO {contadorTurnos}  --------------");
            motor.EscribirEnLog(listBoxLog, $"------------- (Tu turno) --------------");

            if (miPokemon.MisAtaques[AtaqueSeleccion] == null)
            {
                return;
            }

            Ataque ataqueUsado = miPokemon.MisAtaques[AtaqueSeleccion];

            string mensajeInGame;

            int dañoRealizado = miPokemon.Atacar(rivalPokemon, ataqueUsado, out mensajeInGame);
            rivalPokemon.RecibirDaño(dañoRealizado);

            motor.EscribirEnLog(listBoxLog, $"mi {miPokemon.Nombre} usó {ataqueUsado.Nombre}!");

            if (!string.IsNullOrEmpty(mensajeInGame))
                motor.EscribirEnLog(listBoxLog, mensajeInGame);

            motor.EscribirEnLog(listBoxLog, $" El {rivalPokemon.Nombre} rival perdió {dañoRealizado} HP.");

            ActualizarVida();

            if (rivalPokemon.Debilitado())
            {
                GestorDatos gestorDatos = new GestorDatos();
                gestorDatos.RegistrarVictorias(IdRegistroUsuario);

                rivalesRestantes--;

                if (rivalesRestantes > 0)
                {
                    MessageBox.Show("¡Felicidades, superaste al rival! ¡Ahora va el siguiente!");
                    GeneradorRival();
                }
                else
                {
                    MessageBox.Show("¡Felicidades! ¡Has ganado el torneo!");
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
            motor.EscribirEnLog(listBoxLog, "------------- Turno Rival -------------");
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
            motor.EscribirEnLog(listBoxLog, $"El {rivalPokemon.Nombre} rival usó {ataqueUsadoR.Nombre}!");
            if (!string.IsNullOrEmpty(mensajeInGameRival))
                motor.EscribirEnLog(listBoxLog, mensajeInGameRival);
            motor.EscribirEnLog(listBoxLog, $"Mi {miPokemon.Nombre} perdió {dañoRealizadoR} HP.");

            ActualizarVida();

            if (miPokemon.Debilitado())
            {
                MessageBox.Show("Tu Pokéemon se ha debilitado, perdiste la batalla");

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

            contadorTurnos++;
            motor.EscribirEnLog(listBoxLog, "");

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
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
            motor.EscribirEnLog(listBoxLog, $"-------------  TURNO {contadorTurnos}  --------------");
            motor.EscribirEnLog(listBoxLog, $"------------- (Tu turno) --------------");

            int vidaRecuperada = miPokemon.HPMax - miPokemon.HPActual;
            miPokemon.RecibirDaño(-vidaRecuperada);

            pocionesRestantes--;

            if (pocionesRestantes == 0)
            {
                btnSanar.Enabled = false;
                btnSanar.BackgroundImage = Properties.Resources.btn_sanar_apagado;
            }

            lblCantidadHP.Text = $"Pociones restantes = {pocionesRestantes}";

            motor.EscribirEnLog(listBoxLog, $" ¡Has curado a  {miPokemon.Nombre}! Recupero {vidaRecuperada}HP.");

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
            DialogResult confirmar = MessageBox.Show("¿Realmente quieres salir?", "Abandonar torneo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            if (miPokemon.MisAtaques[1] != null)
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

            AsignarImagenInicial(button1, miPokemon.MisAtaques[0]);
            AsignarImagenInicial(button2, miPokemon.MisAtaques[1]);
            AsignarImagenInicial(button3, miPokemon.MisAtaques[2]);
            AsignarImagenInicial(button4, miPokemon.MisAtaques[3]);

            GestorVisual.CargarImagenPokemon(pictureBoxJugador, miPokemon.Nombre, false);
            GestorVisual.CargarImagenPokemon(pictureBoxRival, rivalPokemon.Nombre, true);
            GestorVisual.CargarIconoTipo(pictureBoxTipoJugador, miPokemon.Tipo);
            GestorVisual.CargarIconoTipo(pictureBoxTipoRival, rivalPokemon.Tipo);

            btnAbandonar.BackgroundImage = Properties.Resources.btn_huir_normal;
            btnAbandonar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAbandonar.MouseEnter += btnAbandonar_MouseEnter;
            btnAbandonar.MouseLeave += btnAbandonar_MouseLeave;

            btnSanar.BackgroundImage = Properties.Resources.btn_sanar_normal;
            btnSanar.BackgroundImageLayout = ImageLayout.Stretch;

            btnSanar.MouseEnter += btnSanar_MouseEnter;
            btnSanar.MouseLeave += btnSanar_MouseLeave;

        }

        private void labelvidaRival_Click(object sender, EventArgs e)
        {

        }

        private void labelvidaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSanar_MouseEnter(object sender, EventArgs e)
        {
            btnSanar.BackgroundImage = Properties.Resources.btn_sanar_select;
        }

        private void btnSanar_MouseLeave(object sender, EventArgs e)
        {

            btnSanar.BackgroundImage = Properties.Resources.btn_sanar_normal;
        }
        private void btnAbandonar_MouseEnter(object sender, EventArgs e)
        {
            btnAbandonar.BackgroundImage = Properties.Resources.btn_huir_select;
        }

        private void btnAbandonar_MouseLeave(object sender, EventArgs e)
        {

            btnAbandonar.BackgroundImage = Properties.Resources.btn_huir_normal;
        }

        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Ataque atk = (Ataque)btn.Tag;

            string nombreImg = motor.ObtenerNombreImagenBoton(atk.Tipo, true);
            btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(nombreImg);
        }

        private void Boton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Ataque atk = (Ataque)btn.Tag;

            string nombreImg = motor.ObtenerNombreImagenBoton(atk.Tipo, false);
            btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(nombreImg);
        }
        private void AsignarImagenInicial(Button btn, Ataque atk)
        {
            if (atk != null)
            {
                btn.Visible = true;
                btn.Tag = atk;
                btn.Text = atk.Nombre;

                string nombre = motor.ObtenerNombreImagenBoton(atk.Tipo, false);
                btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(nombre);

                btn.MouseEnter -= Boton_MouseEnter;
                btn.MouseEnter += Boton_MouseEnter;
                btn.MouseLeave -= Boton_MouseLeave;
                btn.MouseLeave += Boton_MouseLeave;
            }
            else
            {
                btn.Visible = false;
            }
        }
    }
}
