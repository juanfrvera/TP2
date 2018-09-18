using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej3
{
    class Juego
    {
        private static Juego cInstancia;  //Para aplicar Singleton

        private  Partida iPartidaActual;

        public Partida IPartidaActual { get { return iPartidaActual; } private set { iPartidaActual = value; } }

        private  Partida[] iMejoresPuntajes;

        private static string[] cPalabras = {
            "UNO", "COMETA", "TANQUE",//3
            "TERMO","ANTEOJOS","ESTRELLA",//6
            "PALABRA", "PIEDRA", "INTENTO",//9
            "RAVIOLES", "ALEMANIA", "NACIMIENTO",//12
            "ESCOBA", "BLANCO", "NEGRO",//15
            "CONTROLADOR","PIZARRA","CONGRESO",//18
            "NEUTRONES", "NEBULOSA", "PECADO",//21
            "OBSIDIANA", "DIAMANTE", "MONO",//24
            "MURCIELAGO","PANTERA","CALAVERA",//27
            "MALETA","ZAPATILLA","TREINTA"//30
        };

        private byte iFallosMaximos;

        private Juego()
        {
            iMejoresPuntajes = new Partida[5];
            iMejoresPuntajes[0] = new Partida("KITU", new DateTime(2018, 8, 7, 20, 15, 13), new DateTime(2018, 8, 7, 20, 20, 13));
            iMejoresPuntajes[1] = new Partida("KOSME FULANITO", new DateTime(1980, 8, 8, 17, 20, 00), new DateTime(1980, 8, 8, 17, 27, 13));
            iMejoresPuntajes[2] = new Partida("PINGUINO ATOMICO", new DateTime(1871, 8, 8, 12, 30, 13), new DateTime(1871, 8, 8, 12, 45, 49));
            iMejoresPuntajes[3] = new Partida("KAISER", new DateTime(2018, 8, 9, 12, 00, 00), new DateTime(2018, 8, 9, 12, 30, 26));
            iMejoresPuntajes[4] = new Partida("BUNNYPANTS", new DateTime(2018, 8, 13, 23, 15, 13), new DateTime(2018, 8, 14, 00, 12, 15));
            iFallosMaximos = 10;
        }

        //Propiedad

        public static Juego Instancia
        {
            get
            {
                if (cInstancia == null) cInstancia = new Juego();
                return cInstancia;                
            }
            private set { }
        }

        public byte IFallosMaximos
        {
            get
            {
                return iFallosMaximos;
            }
            set
            {
                iFallosMaximos = value;
            }
        }

        //Mensajes
        public string IniciarPartida(string pNombre)
        {
            Random rnd = new Random();
            IPartidaActual = new Partida(pNombre, cPalabras[rnd.Next(0, cPalabras.Length)], iFallosMaximos);
            return IPartidaActual.EstadoActual();
        } 

        public void ActualizarPuntajes(Partida pPartida)
        {

            int i = iMejoresPuntajes.Length-2;
            while  ((i>=0) && (pPartida.Duracion < iMejoresPuntajes[i].Duracion))
            {
                iMejoresPuntajes[i + 1] = iMejoresPuntajes[i];
                i--;
            }
            iMejoresPuntajes[i+1] = pPartida;
        }


        public PuntajePartida FinalizarPartida()
        {
            PuntajePartida puntaje;
            puntaje = iPartidaActual.Finalizar();
            if (puntaje.resultado == "Ganada")
            {
                if(iPartidaActual.Duracion < iMejoresPuntajes[iMejoresPuntajes.Length-1].Duracion)
                    ActualizarPuntajes(iPartidaActual);
            }
            return puntaje;
        }

        public PuntajePartida[] MejoresPuntajes()
        {
            PuntajePartida[] mejores = new PuntajePartida[cInstancia.iMejoresPuntajes.Length];

            for (int i = 0; i < iMejoresPuntajes.Length; i++)
            {
                mejores[i] = iMejoresPuntajes[i].PuntajeFinal();
            }

            return mejores;
        }

    }
}
