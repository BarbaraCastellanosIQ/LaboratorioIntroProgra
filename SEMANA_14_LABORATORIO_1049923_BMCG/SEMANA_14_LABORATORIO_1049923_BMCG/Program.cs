//Bárbara Castellanos - 1049923
using System;

class Program
{
    static void Main()
    {
        do
        {
            int[] numeros = new int[7];
            int numeroMayor = int.MinValue;
            int numeroMenor = int.MaxValue;
            int numerosNegativos = 0;
            int numerosPositivos = 0;

            Console.WriteLine("Ingrese 7 números enteros:");

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    if (numeros[i] < numeroMenor)
                        numeroMenor = numeros[i];
                    if (numeros[i] > numeroMayor)
                        numeroMayor = numeros[i];
                    if (numeros[i] < 0)
                        numerosNegativos++;
                    else if (numeros[i] > 0)
                        numerosPositivos++;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                    i--; // Restar uno para reintentar la entrada del número inválido.
                }
            }

            Console.WriteLine($"Número mayor: {numeroMayor}");
            Console.WriteLine($"Número menor: {numeroMenor}");
            Console.WriteLine($"Cantidad de números negativos: {numerosNegativos}");
            Console.WriteLine($"Cantidad de números positivos: {numerosPositivos}");

            Console.Write("¿Desea ingresar otra secuencia de números? (Sí/No): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta != "si")
            {
                Console.WriteLine("Los 7 números ingresados son:");
                foreach (int numero in numeros)
                {
                    Console.Write($"{numero} ");
                }
                Console.WriteLine();
                break;
            }
        } while (true);
    }
}

