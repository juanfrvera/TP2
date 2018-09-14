using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej3
{
    class Controlador
    {
        public static string IniciarPartida(string pNombre)
        {
            return Juego.IniciarPartida(pNombre);
        }

        public static ResultadoIntento Intento(char pLetra)
        {
            return Juego.CPartidaActual.Intento(pLetra);
        }

        public static PuntajePartida FinalizarPartida()
        {
            return Juego.FinalizarPartida();
        }
        public static PuntajePartida[] MejoresPuntajes()
        {
            return Juego.MejoresPuntajes();
        }
    }
}
