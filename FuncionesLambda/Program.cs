using System.IO.Pipes;

internal class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ DE OPCIONES ===");
            Console.WriteLine("1. Calcular factorial de un número");
            Console.WriteLine("2. Verificar si un número es par");
            Console.WriteLine("3. Encontrar el número menor en un arreglo");
            Console.WriteLine("4. Multiplicar dos números (usando string)");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese un número entero para calcular su factorial: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("El factorial no existe para números negativos");
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= numero; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine($"El factorial de {numero} es: {factorial}");
                }
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese un número para verificar si es par: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El número {numero} es PAR");
                }
                else
                {
                    Console.WriteLine($"El número {numero} es IMPAR");
                }
            }
            else if (opcion == 3)
            {
                Console.Write("¿Cuántos números desea ingresar en el arreglo? ");
                int cantidad = int.Parse(Console.ReadLine());

                if (cantidad <= 0)
                {
                    Console.WriteLine("Debe ingresar al menos un número");
                }
                else
                {
                    int[] numeros = new int[cantidad];

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write($"Ingrese el número {i + 1}: ");
                        numeros[i] = int.Parse(Console.ReadLine());
                    }
                    int menor = numeros[0];
                    for (int i = 1; i < cantidad; i++)
                    {
                        if (numeros[i] < menor)
                        {
                            menor = numeros[i];
                        }
                    }

                    Console.Write("Los números ingresados son: ");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write(numeros[i]);
                        if (i < cantidad - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine($"\nEl número menor es: {menor}");
                }
            }
            else if (opcion == 4)
            {
                Console.Write("Ingrese el primer número: ");
                string num1String = Console.ReadLine();
                Console.Write("Ingrese el segundo número: ");
                string num2String = Console.ReadLine();

                int num1 = 0;
                int num2 = 0;
                bool esValidoNum1 = true;
                bool esValidoNum2 = true;

                for (int i = 0; i < num1String.Length; i++)
                {
                    char c = num1String[i];
                    if (c < '0' || c > '9')
                    {
                        if (i == 0 && c == '-')
                        {
                        }
                        else
                        {
                            esValidoNum1 = false;
                            break;
                        }
                    }
                }

                for (int i = 0; i < num2String.Length; i++)
                {
                    char c = num2String[i];
                    if (c < '0' || c > '9')
                    {
                        if (i == 0 && c == '-')
                        {
                        }
                        else
                        {
                            esValidoNum2 = false;
                            break;
                        }
                    }
                }

                if (esValidoNum1 && esValidoNum2)
                {
                    num1 = int.Parse(num1String);
                    num2 = int.Parse(num2String);
                    int resultado = num1 * num2;

                    Console.WriteLine($"El resultado de multiplicar {num1} x {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: Uno o ambos valores ingresados no son números válidos");
                }
            }
            else if (opcion == 5)
            {
                Console.WriteLine("¡Gracias por usar el programa!");
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor seleccione una opción del 1 al 5.");
            }

        } while (opcion != 5);
    }
}