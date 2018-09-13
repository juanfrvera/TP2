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
            bool salir = false;
            while (!salir) {
                Console.Clear();
                Console.WriteLine("Seleccione cuenta: ");
                Console.WriteLine("1- Cuenta Corriente");
                Console.WriteLine("2- Caja Ahorro");
                Console.WriteLine("3- Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        MenuCuentaCorriente();
                        break;
                    case "2":
                        MenuCajaAhorro();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }

        static void MenuCuentaCorriente()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("1- Consultar saldo.");
                Console.WriteLine("2- Acreditar saldo.");
                Console.WriteLine("3- Debitar saldo.");
                Console.WriteLine("4- Transferir a caja de ahorro.");
                Console.WriteLine("5- Salir.");
                string opcion = Console.ReadLine();
                Console.Clear();
                //Lo definimos aca porque sino tenemos un problema al definirlo dos veces en el caso 3 y el 4
                bool resultado;
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Saldo disponible: {0}", Controlador.ConsultarSaldoCC());
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese saldo a acreditar: ");
                        Controlador.AcreditarSaldoCC(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine();
                        Console.WriteLine("Saldo acreditado");

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese saldo a debitar: ");
                        resultado = Controlador.DebitarSaldoCC(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine();
                        if (resultado)
                            Console.WriteLine("Saldo debitado");
                        else
                            Console.WriteLine("Saldo insuficiente");

                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese saldo a transferir: ");
                        resultado = Controlador.TransferenciaCorrienteACaja(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine();
                        if (resultado)
                            Console.WriteLine("Transferencia exitosa");
                        else
                            Console.WriteLine("Saldo insuficiente en la cuenta corriente");

                        Console.ReadKey();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                }
            } 
        }

        static void MenuCajaAhorro()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("1- Consultar saldo.");
                Console.WriteLine("2- Acreditar saldo.");
                Console.WriteLine("3- Debitar saldo.");
                Console.WriteLine("4- Transferir a cuenta corriente.");
                Console.WriteLine("5- Salir.");
                string opcion = Console.ReadLine();
                Console.Clear();
                //Lo definimos aca porque sino tenemos un problema al definirlo dos veces en el caso 3 y el 4
                bool resultado;
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Saldo disponible: {0}", Controlador.ConsultarSaldoCA());
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese saldo a acreditar: ");
                        Controlador.AcreditarSaldoCA(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine();
                        Console.WriteLine("Saldo acreditado");

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese saldo a debitar: ");
                        resultado = Controlador.DebitarSaldoCA(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine();
                        if (resultado)
                            Console.WriteLine("Saldo debitado");
                        else
                            Console.WriteLine("Saldo insuficiente");

                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese saldo a transferir: ");
                        resultado = Controlador.TransferenciaCajaACorriente(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine();
                        if (resultado)
                            Console.WriteLine("Transferencia exitosa");
                        else
                            Console.WriteLine("Saldo insuficiente en la caja de ahorro");

                        Console.ReadKey();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}