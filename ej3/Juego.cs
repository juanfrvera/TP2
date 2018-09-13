using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej3
{
    class Juego
    {
        private static Partida cPartidaActual;
        public static Partida CPartidaActual { get { return cPartidaActual; } private set { cPartidaActual = value; } }

        private static Partida[] cMejoresPuntajes;

        private static string[] cPalabras = { "HOLA", "COMETA", "ESTERNOCLEIDOMASTOIDEO", "TANQUE" };

        static Juego()
        {
            cMejoresPuntajes = new Partida[5];
            cMejoresPuntajes[0] = new Partida("KITU", new DateTime(2018, 8, 7, 20, 15, 13), new DateTime(2018, 8, 7, 20, 20, 13));
            cMejoresPuntajes[1] = new Partida("KOSME FULANITO", new DateTime(1980, 8, 8, 17, 20, 00), new DateTime(1980, 8, 8, 17, 27, 13));
            cMejoresPuntajes[2] = new Partida("PINGUINO ATOMICO", new DateTime(1871, 8, 8, 12, 30, 13), new DateTime(1871, 8, 8, 12, 45, 49));
            cMejoresPuntajes[3] = new Partida("KAISER", new DateTime(2018, 8, 9, 12, 00, 00), new DateTime(2018, 8, 9, 12, 30, 26));
            cMejoresPuntajes[4] = new Partida("BUNNYPANTS", new DateTime(2018, 8, 13, 23, 15, 13), new DateTime(2018, 8, 14, 00, 12, 15));
        }


        public static string IniciarPartida(string pNombre)
        {
            Random rnd = new Random();
            CPartidaActual = new Partida(pNombre, cPalabras[rnd.Next(0, cPalabras.Length)]);
            return CPartidaActual.EstadoActual();
        }

        public static void ActualizarPuntajes(Partida pPartida)
        {

            int i = cMejoresPuntajes.Length-2;
            while  ((i>=0) && (pPartida.Duracion < cMejoresPuntajes[i].Duracion))
            {
                cMejoresPuntajes[i + 1] = cMejoresPuntajes[i];
                i--;
            }
            cMejoresPuntajes[i] = pPartida;
        }


        public static PuntajePartida FinalizarPartida()
        {
            PuntajePartida puntaje;
            puntaje = cPartidaActual.Finalizar();
            if (puntaje.resultado == "Ganada")
            {
                ActualizarPuntajes(cPartidaActual);
            }
            return puntaje;



        }
    }
}
