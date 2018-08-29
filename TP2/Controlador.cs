using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    public class Controlador
    {
        public static double CalcularPerimetro(double pX,double pY,double pRadio)
        {
            return (new Circulo(pX, pY, pRadio)).Perimetro;
        }
        public static double CalcularArea(double pX, double pY, double pRadio)
        {
            return (new Circulo(pX, pY, pRadio)).Area;
        }
        public static double CalcularPerimetro(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
        {
            return (new Triangulo(p1X, p1Y, p2X,  p2Y,  p3X,  p3Y)).Perimetro;
        }
        public static double CalcularArea(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
        {
            return (new Triangulo(p1X, p1Y, p2X, p2Y, p3X, p3Y)).Area;
        }
    }
}
