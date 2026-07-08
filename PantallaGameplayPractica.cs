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
    public partial class PantallaGameplayPractica : Form
    {
        private PokeDaVI miPokemon;
        private PokeDaVI rivalPokemon;
        private int IdRegistroUsuario;
        private MotorCombate motor = new MotorCombate();
        private int contadorTurnos = 1;
        public PantallaGameplayPractica(PokeDaVI usuario, PokeDaVI rival, int idPokemonRegistro)
        {
            InitializeComponent();
            miPokemon = usuario;
            rivalPokemon = rival;
            IdRegistroUsuario = idPokemonRegistro;
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

            labelComentarios.Text = mensajeInGame;

            motor.EscribirEnLog(listBoxLog, $"mi {miPokemon.Nombre} usó {ataqueUsado.Nombre}!");

            if (!string.IsNullOrEmpty(mensajeInGame))
                motor.EscribirEnLog(listBoxLog, mensajeInGame);

            motor.EscribirEnLog(listBoxLog, $" El {rivalPokemon.Nombre} rival perdió {dañoRealizado} HP.");

            ActualizarVida();

            if (rivalPokemon.Debilitado())
            {
                GestorDatos gestorDatos = new GestorDatos();
                gestorDatos.RegistrarVictorias(IdRegistroUsuario);

                MessageBox.Show("¡Felicidades! ¡Ganaste!");
                this.Close();
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

            labelComentarios.Text = mensajeInGameRival;

            miPokemon.RecibirDaño(dañoRealizadoR);
            motor.EscribirEnLog(listBoxLog, $"El {rivalPokemon.Nombre} rival usó {ataqueUsadoR.Nombre}!");
            if (!string.IsNullOrEmpty(mensajeInGameRival))
                motor.EscribirEnLog(listBoxLog, mensajeInGameRival);
            motor.EscribirEnLog(listBoxLog, $"Mi {miPokemon.Nombre} perdió {dañoRealizadoR} HP.");
            ActualizarVida();

            if (miPokemon.Debilitado())
            {
                MessageBox.Show("Tu Pokémon se ha debilitado, perdiste la batalla");
                this.Close();
            }
            contadorTurnos++;
            motor.EscribirEnLog(listBoxLog, "");

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
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

            ActualizarVida();

            AsignarImagenInicial(button1, miPokemon.MisAtaques[0]);
            AsignarImagenInicial(button2, miPokemon.MisAtaques[1]);
            AsignarImagenInicial(button3, miPokemon.MisAtaques[2]);
            AsignarImagenInicial(button4, miPokemon.MisAtaques[3]);

            GestorVisual.CargarImagenPokemon(pictureBoxJugador, miPokemon.Nombre, false);
            GestorVisual.CargarImagenPokemon(pictureBoxRival, rivalPokemon.Nombre, true);
            GestorVisual.CargarIconoTipo(pictureBoxTipoJugador, miPokemon.Tipo);
            GestorVisual.CargarIconoTipo(pictureBoxTipoRival, rivalPokemon.Tipo);

            button5Retirarse.BackgroundImage = Properties.Resources.btn_huir_normal;
            button5Retirarse.BackgroundImageLayout = ImageLayout.Stretch;
            button5Retirarse.MouseEnter += button5_MouseEnter;
            button5Retirarse.MouseLeave += button5_MouseLeave;

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
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5Retirarse.BackgroundImage = Properties.Resources.btn_huir_select;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
  
            button5Retirarse.BackgroundImage = Properties.Resources.btn_huir_normal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraRival_Paint(object sender, PaintEventArgs e)
        {

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

        private void panelBarraUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarraRival_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
