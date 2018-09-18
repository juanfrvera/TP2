using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej3
{
    class Controlador
    {
        private static Juego cJuego;


        public static Juego CJuego
        {
            get
            {
                if (cJuego == null) cJuego = Juego.Instancia;
                return cJuego;
            }
            private set {}
        }   


        //Mensajes
        public static string IniciarPartida(string pNombre)
        {
            return CJuego.IniciarPartida(pNombre);
        }

        public static ResultadoIntento Intento(char pLetra)
        {
            return CJuego.IPartidaActual.Intento(pLetra);
        }

        public static PuntajePartida FinalizarPartida()
        {
            return CJuego.FinalizarPartida();
        }
        public static PuntajePartida[] MejoresPuntajes()
        {
            return CJuego.MejoresPuntajes();

        }

        public static void ModificarFallosMaximos(byte pFallos)
        {
            CJuego.IFallosMaximos = pFallos;
        }
    }
}
