using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Program
    {
        static void Main(string [] args)
        {
            Controlador.Inicializar();
            Console.WriteLine("Seleccione cuenta: ");
            Console.WriteLine("1- Cuenta Corriente");
            Console.WriteLine("2- Caja Ahorro");
            string opcion = Console.ReadLine();
            switch (opcion)
                {
                case "1":
                    MenuCuentaCorriente();
                    break;
                case "2":
                    MenuCajaAhorro();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
                }
        }

        static void MenuCuentaCorriente()
        {
            Console.Clear();
            Console.WriteLine("1- Consultar saldo.");
            Console.WriteLine("2- Acreditar saldo.");
            Console.WriteLine("3- Debitar saldo.");
            string opcion = Console.ReadLine();
            Console.Clear();
            switch(opcion)
                {
                case "1":
                    Console.WriteLine("Saldo disponible: {0}", Controlador.ConsultarSaldoCC());
                break;
                case "2":
                    Console.WriteLine("Ingrese saldo a acreditar: ");
                    Controlador.AcreditarSaldoCC(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine();
                    Console.WriteLine("Saldo Acreditado");
                break;
                case "3":
                    //COMPLETAR EL DEBITAR Y LUEGO HACER EL MENU CAJA AHORRO

                default:
                    Console.WriteLine("Opcion invalida");
                break;
            }
        }
    }
}