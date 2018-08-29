using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Program
    {
        static int Sumatoria(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sumatoria(4, 5, 3, 7, 8).ToString());
            Console.ReadKey();
        }
        //{0:0.00} -> Le da formato al parametro cero   
    }
}