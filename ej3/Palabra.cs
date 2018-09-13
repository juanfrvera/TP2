using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej3
{
    class Palabra
    {
        //Atributos 
        private string iElegida;
        private char[] iEstado;

        //Propiedades

        public string Elegida
        {
            get { return this.iElegida; }
            private set { this.iElegida = value; }
        }

        
        //Constructor

        public Palabra(string pElegida)
        {
            this.Elegida = pElegida;
            this.iEstado = new char[this.Elegida.Length];
            for (int i = 0; i< this.iEstado.Length; i++)
            { this.iEstado[i] = '_'; }
        }


        // Mensajes
        public bool ChequearLetra(char pLetra)
        {
            int indice;
            bool resultado = false;
            for (indice = 0; indice < this.Elegida.Length; indice++)
            {
                if (this.Elegida[indice] == pLetra)
                {
                    this.iEstado[indice] = pLetra;
                    resultado = true;
                }
            }
            return resultado;
        }

        public string EstadoActual()
        {
            return (new String(iEstado));
        }

        public bool Completa()
        {
            return (Elegida == EstadoActual());
        }
    }
}
