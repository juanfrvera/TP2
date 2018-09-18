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
        double iReal;
        double iImaginario;

        //Constructor
        public  Complejo(double pReal, double pImaginario)
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
                double tita = 0;
                double r=Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginario, 2));
                if (Real==0)
                {
                     tita = Math.Sign(Imaginario) * (Math.PI / 2);
                }
                if (Real<0)
                {
                     tita = Math.Atan(Imaginario / Real) + (Math.PI / 2);
                }
                if (Real>0)
                {
                     tita = Math.Atan(Imaginario / Real);
                }
                if (Imaginario == 0)
                {
                    tita = Math.Sign(Real) * Math.PI;
                }
                return r * (Math.Cos(tita) + Math.Sin(tita));
               
            }
        }
    }
}
