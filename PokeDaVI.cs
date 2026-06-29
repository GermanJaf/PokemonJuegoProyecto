using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonJuegoProyecto
{
    public class PokeDaVI
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Tipo { get; }
        public int Nivel { get; }
        public int HPMax { get; }
        public int HPActual { get; private set; } 
        public int AtaqueBase { get; }
        public int DefensaBase { get; }
        public Ataque[] MisAtaques { get; }
        public PokeDaVI(int id, string nombre, string tipo, int nivel, int hpMax, int ataqueBase, int defensaBase)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Nivel = nivel;
            HPMax = hpMax;
            HPActual = hpMax; 
            AtaqueBase = ataqueBase;
            DefensaBase = defensaBase;
        }

        public void RecibirDaño(int cantidad)
        {
            HPActual -= cantidad;
            if (HPActual < 0) HPActual = 0;
        }

        // Debilitado//
        public bool Debilitado()
        {
            return HPActual <= 0;
        }
        public int Atacar(PokeDaVI rival, Ataque ataqueUsado)
        {
            double Atade = ataqueUsado.Poder * ((double)AtaqueBase / rival.DefensaBase);
            double dañoBase = (Atade / 50.0) + 2;

            //STAB//
            double stab =  1.0;
            if (ataqueUsado.Tipo == Tipo)
            {
                stab = 1.5;
            }

            // Efectividad//
            double efectividad = PokeTipos.Efectividad(ataqueUsado.Tipo, rival.Tipo);

            // Critico //
            Random rand = new Random();
            double critico = 1.0;
            int num = rand.Next(25);
            if (num == 10)
            {
                critico = 1.5;
                Console.WriteLine("¡Un golpe crítico!");
            }

            // Daño entre 85 a 100% //
            int porat = rand.Next(85, 101);
            double aleatorio = porat / 100 ;

            // Formula
            int dañoFinal = (int)(dañoBase * critico * aleatorio * stab * efectividad);

            if (efectividad == 2.0) Console.WriteLine("¡Es súper eficaz!");

            else if (efectividad == 0.5) Console.WriteLine("No es muy eficaz...");

            return dañoFinal;
        }
    }
}


