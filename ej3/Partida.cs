using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej3
{
    class Partida
    {
        //Declaraciones
        public enum EstadoPartida { 
            EnCurso , Ganada, Perdida };

        //Atributos
        private static byte cFallosMaximos;

        private String iNombreJugador;
        private DateTime iInicio;
        private DateTime iFin;
        private EstadoPartida iEstado;
        private byte iFallosActuales;
        private Palabra iPalabra;

        //Propiedades
        public TimeSpan Duracion
        {
            get { return (iFin - iInicio).Duration(); }
        }


        //Constructores
        static Partida()//Constructor de clase
        {
            Partida.cFallosMaximos = 10;
        }
        public Partida(string pNombre, string pPalabra)
        {
            this.iNombreJugador = pNombre;
            this.iPalabra = new Palabra(pPalabra);
            this.iInicio = DateTime.Now;
            this.iEstado = EstadoPartida.EnCurso;
        }
        public Partida(String pNombre, DateTime pInicio, DateTime pFin) //Constructor para puntajes precargados
        {
            this.iNombreJugador = pNombre;
            this.iInicio = pInicio;
            this.iFin = pFin;
            this.iEstado = EstadoPartida.Ganada;

        }

        //Metodos
        public string EstadoActual()
        {
            return this.iPalabra.EstadoActual();
        }

        public ResultadoIntento Intento(char pLetra)
        {
            ResultadoIntento resultado;

            resultado.intentoValido = this.iPalabra.ChequearLetra(pLetra);
            resultado.palabra = iPalabra.EstadoActual();


            if (resultado.intentoValido)
            {
                if (iPalabra.Completa())
                    iEstado = EstadoPartida.Ganada;
            }
            else
            {
                if (++iFallosActuales > cFallosMaximos)
                    iEstado = EstadoPartida.Perdida; 

            }
            resultado.estado = iEstado.ToString();
            resultado.fallosRestantes = cFallosMaximos - iFallosActuales;
            return resultado;
        }

        public PuntajePartida Finalizar()
        {
            PuntajePartida puntaje;
            puntaje.inicio = iInicio.ToShortDateString();
            puntaje.fin = iFin.ToShortDateString();
            puntaje.duracion = (iFin - iInicio).Duration();
            puntaje.fallos = iFallosActuales.ToString();
            puntaje.resultado = iEstado.ToString();

            return puntaje;
        }

    }
}