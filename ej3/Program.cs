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
                Console.WriteLine("3.Modificar cantidad maxima de fallos.")
                Console.WriteLine("4.Salir.");

                String opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        JugarPartida();
                        break;
                    case "2":
                        VerPuntajes();
                        break;
                    case "3":
                        ModificarFallosMaximos();
                        break;
                    case "4":
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
            Console.Clear();
            DibujarPalabra(palabra);

            while (!salir) { 
                Console.WriteLine();
                Console.Write("Ingrese un caracter: ");
                char letra;
                try
                { 
                    letra = Convert.ToChar(Console.ReadLine().ToUpper());
                }
                catch //Si no se ingresa una letra
                {
                    continue; //Para pasar a la proxima iteracion del while
                }
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
                        Console.WriteLine("Ganaste!");

                        PuntajePartida puntaje = Controlador.FinalizarPartida();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Inicio de Partida: {0}", puntaje.inicio);
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
                        Console.WriteLine("Perdiste :(");
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
            PuntajePartida[] puntajes = Controlador.MejoresPuntajes();
            foreach(PuntajePartida puntaje in puntajes)
            {
                Console.WriteLine();
                Console.WriteLine("Nombre de jugador: {0}", puntaje.jugador);
                Console.WriteLine("Inicio de partida: {0}",puntaje.inicio);
                Console.WriteLine("Fin de partida: {0}", puntaje.fin);
                Console.WriteLine("Duracion de partida en segundos: {0}", puntaje.duracion.TotalSeconds);
                Console.WriteLine("Fallos cometidos: {0}", puntaje.fallos);
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void DibujarPalabra(string palabra)
        {
            foreach (char caracter in palabra)
            {
                Console.Write(caracter + " ");
            }
        }

        static void ModificarFallosMaximos()
        {
            Console.WriteLine("Ingrese nueva cantidad de fallos maximos: ");
            byte fallos;
            try
            {
                fallos = Convert.ToByte(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Datos erroneos, el valor debe estar entre 0 y 255");
            }

            Controlador.
        }

        /*Escribir los mejores puntajes en pantalla*/
    }
}
