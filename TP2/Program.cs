using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Elija una figura");
                Console.WriteLine("1-Circulo");
                Console.WriteLine("2-Triangulo");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Program.MenuCirculo();
                        break;
                    case "2":
                        Program.MenuTriangulo();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void MenuCirculo()
        {
            Console.Write("Ingrese coordenada X del centro: ");
            double centroX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese coordenada Y del centro: ");
            double centroY = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Que desea hacer con el circulo?");
                Console.WriteLine("1-Calcular perimetro");
                Console.WriteLine("2-Calcular area");
                Console.WriteLine("Cualquier tecla - Volver");
                string opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("El perimetro es {0}",Controlador.CalcularPerimetro(centroX, centroY, radio));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("El area es {0}", Controlador.CalcularArea(centroX, centroY, radio));
                        Console.ReadKey();
                        break;
                    default:
                        salir = true;
                        break;
                } 
            }
        }
        static void MenuTriangulo()
        {
            Console.Write("Ingrese coordenada X del primer punto: ");
            double unoX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese coordenada Y del primer punto: ");
            double unoY = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese coordenada X del segundo punto: ");
            double dosX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese coordenada Y del segundo punto: ");
            double dosY = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese coordenada X del tercer punto: ");
            double tresX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese coordenada Y del tercer punto: ");
            double tresY = Convert.ToDouble(Console.ReadLine());

            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Que desea hacer con el triangulo?");
                Console.WriteLine("1-Calcular perimetro");
                Console.WriteLine("2-Calcular area");
                Console.WriteLine("Cualquier tecla - Volver");
                string opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("El perimetro es {0}", Controlador.CalcularPerimetro(unoX,unoY,dosX,dosY,tresX,tresY));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("El area es {0}", Controlador.CalcularArea(unoX, unoY, dosX, dosY, tresX, tresY));
                        Console.ReadKey();
                        break;
                    default:
                        salir = true;
                        break;
                }
            }
        }
    }
}