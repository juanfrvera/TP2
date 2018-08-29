using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Cuentas
    {
        //Atributos
        private Cliente iCliente;
        private Cuenta iCuentaCorriente, iCajaAhorro;
       
        //Propiedades
        public Cuenta CuentaCorriente
        {
            get { return iCuentaCorriente; }
            private set { iCuentaCorriente = value; }

        }

        public Cuenta CajaAhorro
        {
            get { return iCajaAhorro; }
            private set { iCajaAhorro = value; }

        }

        //Constructor
        public Cuentas(Cliente pCliente)
        {
            this.iCliente = pCliente;
            this.iCuentaCorriente = new Cuenta(0f, 2000f);
            this.iCajaAhorro = new Cuenta(0f, 3000f);
        }

    }
}
