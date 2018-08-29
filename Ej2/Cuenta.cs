using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        //Propiedades
        public double Saldo
        {
            get { return this.iSaldo; }
            private set { this.iSaldo = value; }
        }
        public double Acuerdo
        {
            get { return this.iAcuerdo; }
            private set { this.iAcuerdo = value; }
        }

        //Constructores
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.Saldo = pSaldoInicial;
            this.Acuerdo = pAcuerdo;
        }

        public Cuenta(double pAcuerdo)
        {
            this.Acuerdo = pAcuerdo;
        }
        //Metodos
        public void AcreditarSaldo(double pSaldo)
        {
            this.Saldo += pSaldo;
        }

        public Boolean DebitarSaldo(double pSaldo)
        {
            if (this.Saldo + this.Acuerdo >= pSaldo)
            {
                this.Saldo -= pSaldo;
                return true;
            }
            else
                return false;

        }




    }
}
