using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Controlador
    {
        private static Cuentas cCuentas;

        // M

        private static void Inicializar(Cliente.TipoDocumento pTipoDocumento, string pNumeroDoc, string pNombre)
        {
            cCuentas = new Cuentas(new Cliente(pTipoDocumento, pNumeroDoc, pNombre));
        }
        public static void Inicializar()
        {
            Inicializar(Cliente.TipoDocumento.DNI, "38456932", "Traita");
        }

        public static double ConsultarSaldoCC()
        {
            return cCuentas.CuentaCorriente.Saldo;
        }
        public static double ConsultarSaldoCA()
        {
            return cCuentas.CajaAhorro.Saldo;
        }

        public static void AcreditarSaldoCC(double pSaldo)
        {
            cCuentas.CuentaCorriente.AcreditarSaldo(pSaldo);
        }
        public static bool DebitarSaldoCC(double pSaldo)
        {
            return cCuentas.CuentaCorriente.DebitarSaldo(pSaldo);
        }
        public static void AcreditarSaldoCA(double pSaldo)
        {
            cCuentas.CajaAhorro.AcreditarSaldo(pSaldo);
        }
        public static bool DebitarSaldoCA(double pSaldo)
        {
           return cCuentas.CajaAhorro.DebitarSaldo(pSaldo);
        }
        

        private static bool Transferencia(Cuenta pCuentaOrigen, Cuenta pCuentaDestino, double pSaldo)
        {
            bool resultado = pCuentaOrigen.DebitarSaldo(pSaldo);
            if (resultado)
            {
                pCuentaDestino.AcreditarSaldo(pSaldo);
            }
            return resultado;
        }

        public static bool TransferenciaCorrienteACaja(double pSaldo)
        {
            return Transferencia(cCuentas.CuentaCorriente, cCuentas.CajaAhorro, pSaldo);
        }

        public static bool TransferenciaCajaACorriente(double pSaldo)
        {
            return Transferencia(cCuentas.CajaAhorro, cCuentas.CuentaCorriente, pSaldo);
        }

    }
}
