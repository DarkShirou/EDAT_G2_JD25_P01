using System;
using SumaNumeros.Logica;

namespace SumaNumeros.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursivos oRecursivos = new Recursivos();

            Console.Write("Introduce n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"La suma de los primeros {n} números es: {oRecursivos.SumaN(n)}");
        }
    }
}