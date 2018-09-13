using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1.Jugar partida.");
                Console.WriteLine("2.Ver puntajes.");
                Console.WriteLine("3.Salir.");

                String opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        JugarPartida();
                        break;
                    case "2":
                        VerPuntajes();
                    case "3":
                        salir = true;
                        break;
                    default:
                        break;
                }
            }
        }
        static void JugarPartida()
        {
            List<char> letrasFallidas = new List<char>();

            bool salir = false;

            Console.Write("Nombre: ");
            string palabra = Controlador.IniciarPartida(Console.ReadLine());
            DibujarPalabra(palabra);

            while (!salir) { 
                Console.WriteLine();
                Console.Write("Ingrese un caracter: ");
                char letra = Convert.ToChar(Console.ReadLine().ToUpper());

                Console.Clear();

                ResultadoIntento intento = Controlador.Intento(letra);
                if (!intento.intentoValido)
                {
                    letrasFallidas.Add(letra);
                }


                DibujarPalabra(intento.palabra);
                Console.WriteLine();
                Console.Write("Letras fallidas: ");
                DibujarPalabra(new String(letrasFallidas.ToArray()));

                Console.WriteLine();

                if (intento.intentoValido)
                {
                    if (intento.estado == "Ganada")
                    {
                        salir = true;
                        Console.WriteLine("Ganaste! pero estaba facil.");

                        PuntajePartida puntaje = Controlador.FinalizarPartida();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("I+nicio de Partida: {0}", puntaje.inicio);
                        Console.WriteLine("Fin de Partida: {0}", puntaje.fin);
                        Console.WriteLine("Duracion de Partida en Segundos: {0}", puntaje.duracion.Seconds);
                        Console.WriteLine("Fallos Cometidos: {0}", puntaje.fallos);
                        Console.ReadKey();
                    }
                }
                else
                {
                    if(intento.estado == "Perdida")
                    {
                        salir = true;
                        Console.WriteLine("Perdiste, la vida es dura.");
                        Console.ReadKey();
                    }
                }

                if (intento.estado == "EnCurso")
                    Console.Write("Fallos restantes: {0}", intento.fallosRestantes);
            }
            Console.Clear();
        }
        
        static void VerPuntajes()
        {
            Console.WriteLine("Nombre"+new string(' ',5)+"Inicio"+new string(' ', 5)+"Fin" + new string(' ', 5) + "Puntaje");

            PuntajePartida[] puntajes = Controlador.MejoresPuntajes();
            foreach(PuntajePartida puntaje in puntajes)
            {
                Console.WriteLine();
                Console.WriteLine(puntaje.inicio);
                Console.WriteLine("Fin de Partida: {0}", puntaje.fin);
                Console.WriteLine("Duracion de Partida en Segundos: {0}", puntaje.duracion.Seconds);
                Console.WriteLine("Fallos Cometidos: {0}", puntaje.fallos);
            }
        }

        static void DibujarPalabra(string palabra)
        {
            foreach (char caracter in palabra)
            {
                Console.Write(caracter + " ");
            }
        }

        /*Escribir los mejores puntajes en pantalla*/
    }
}
