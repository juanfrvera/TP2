using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Punto
    {
        //Atributos
        private double iX;
        private double iY;
        
        //Propiedades
        public double X
        {
            get { return this.iX; }
            private set { this.iX = value; }
        }
        public double Y
        {
            get { return this.iY; }
            private set { this.iY = value; }
        }

        //Constructores
        public Punto(double pX, double pY)
        {
            this.X = pX;
            this.Y = pY;
        }

        //Metodos
        public double CalcularDistanciaDesde(Punto punto)
        {
            //Distancia euclidiana
            return Math.Sqrt(Math.Pow(this.X - punto.X, 2) + Math.Pow(this.Y - punto.Y, 2));
        }
    }
}