using System;
using Recursividad.Logica; // Importamos la clase Recursivos del proyecto de lógica

namespace Recursividad.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursivos oRecursivos = new Recursivos();

            int opcion;
            do
            {
                Console.WriteLine("\n--- PROGRAMAS RECURSIVOS ---");
                Console.WriteLine("1) Contar vocales en una cadena");
                Console.WriteLine("2) Entero con mayor suma de dígitos");
                Console.WriteLine("3) Sumar primeros n números");
                Console.WriteLine("4) Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce una cadena: ");
                        string texto = Console.ReadLine();
                        Console.WriteLine($"Número de vocales: {oRecursivos.Vocales(texto)}");
                        break;

                    case 2:
                        Console.Write("¿Cuántos enteros quieres ingresar?: ");
                        int cantidad = int.Parse(Console.ReadLine());
                        int mayorNumero = 0, mayorSuma = -1;

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.Write($"Ingresa el entero #{i + 1}: ");
                            int num = int.Parse(Console.ReadLine());
                            int suma = oRecursivos.SumaDigitos(num);
                            Console.WriteLine($"→ Suma de dígitos de {num} = {suma}");

                            if (suma > mayorSuma)
                            {
                                mayorSuma = suma;
                                mayorNumero = num;
                            }
                        }

                        Console.WriteLine($"El entero con mayor suma de dígitos es {mayorNumero} con suma {mayorSuma}");
                        break;

                    case 3:
                        Console.Write("Introduce n: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La suma de los primeros {n} números es: {oRecursivos.SumaN(n)}");
                        break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}