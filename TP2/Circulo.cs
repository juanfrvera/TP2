using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Circulo
    {
        //Atributos
        private Punto iCentro;
        private double iRadio;
        //Propiedades
        public Punto Centro
        {
            get { return this.iCentro; }
            private set { this.iCentro = value; }
        }
        public double Radio
        {
            get { return this.iRadio; }
            private set { this.iRadio = value; }
        }
        public double Perimetro
        {
            get { return 2 * Math.PI * Radio; }
        }
        public double Area
        {
            get { return Math.PI * Math.Pow(Radio, 2); }
        }
        //Constructores
        public Circulo(Punto pCentro, double pRadio)
        {
            this.Centro = pCentro;
            this.Radio = pRadio;
        }
        public Circulo(double pX, double pY, double pRadio) : this(new Punto(pX, pY), pRadio) {}
        //Metodos
    }
}
