using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Complejo
    {
        //Atributos
        private double iReal;
        private double iImaginario;

        //Constructor
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        public double Real
        {
            get { return iReal; }
        }

        public double Imaginario
        {
            get { return iImaginario; }
        }

        public double ArgumentoEnRadianes
        {
            get
            {
                return ArgumentoEnGrados * (Math.PI / 180);
            }
        }
        public double ArgumentoEnGrados{
            get
            {
                if (Real > 0)
                {
                    if (Imaginario >= 0)
                        return Math.Atan(Imaginario / Real) * (180/Math.PI);
                    else
                        return Math.Abs(Math.Atan(Imaginario / Real)) * (180 / Math.PI) + 270;
                }
                else//Real <=0
                {
                    if(Real != 0)
                    {
                        if(Imaginario > 0)
                            return Math.Abs(Math.Atan(Imaginario / Real)) * (180 / Math.PI) + 90;
                        else
                            return Math.Atan(Imaginario / Real) * (180 / Math.PI) + 180;
                    }
                    else
                    {
                        return 90 + (90 * (-Math.Sign(Imaginario) + 1));
                    }
                }
            }
        }
        public Complejo Conjugado
        {
            get
            {
                return new Complejo(iReal, -iImaginario);
            }

        }
        
        public double Magnitud
        {
            get
            {
                return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginario, 2));
            }
        }
        
        //Metodos
        public bool EsReal()
        {
            return Imaginario == 0;
        }
        public bool EsImaginario()
        {
            return Real == 0;
        }
        public bool EsIgual(Complejo pComplejo)
        {
            return (Real == pComplejo.Real && Imaginario == pComplejo.Imaginario);
        }
        public bool EsIgual(double pReal, double pImaginario)
        {
            return this.EsIgual(new Complejo(pReal, pImaginario));
        }
        public Complejo Sumar(Complejo pComplejo)
        {
            return new Complejo(Real + pComplejo.Real, Imaginario + pComplejo.Imaginario);
        }
        public Complejo Restar(Complejo pComplejo)
        {
            return new Complejo(Real - pComplejo.Real, Imaginario - pComplejo.Imaginario);
        }
        public Complejo MultiplicarPor(Complejo pComplejo)
        {
            double nuevoReal = (Real * pComplejo.Real) - Imaginario * pComplejo.Imaginario;
            double nuevoImaginario = (Real * pComplejo.Imaginario) + Imaginario * pComplejo.Real;

            return new Complejo(nuevoReal, nuevoImaginario);
        }
        public Complejo DividirPor(Complejo pComplejo)
        {
            Complejo temp = this.MultiplicarPor(pComplejo.Conjugado);
            double divisor = Math.Pow(pComplejo.Real,2) + Math.Pow(pComplejo.Imaginario,2);
            return new Complejo(temp.Real/divisor, temp.Imaginario/divisor);
        }


        public override string ToString()
        {
            return Real.ToString() + (Imaginario > 0 ? "+"+Imaginario.ToString() : Imaginario.ToString()) + "i"; 
        }

    }
}
