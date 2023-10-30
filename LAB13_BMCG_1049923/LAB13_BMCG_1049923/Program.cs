//using System;
//using System.Diagnostics;

//namespace LAB13_BMCG_1049923
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Declaración
//            int[] vector = new int[5];
//            string [] vector2 = new string[5];

//            string[] dias = { "Lunes", "Martes", "Sábado", "Domingo" };

//            //Console.WriteLine(dias[0]);
//            for (int i = 0; i < dias.Length; i++)
//            {
//                Console.WriteLine(dias[i]);
//            }

//            Console.ReadKey();

//        }
//    }
//}

using System;
using System.Globalization;

using System;
using System.Globalization;

using System;
using System.Globalization;

namespace LAB13_BMCG_1049923
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio no. 01
            // Declarar un arreglo para almacenar las notas
            int[] notas = new int[8];
            double promedio = 0;
            int notaMasAlta = int.MinValue;

            Console.WriteLine("Ejercicio no. 01");
            Console.WriteLine("Ingrese las notas de los ÚLTIMOS 8 laboratorios:");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Lab no. " + (i + 1) + ": ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada,  out notas[i]))
                {
                    // Calcular el promedio mientras ingresamos las notas
                    promedio += notas[i];

                    // la nota más alta
                    if (notas[i] > notaMasAlta)
                    {
                        notaMasAlta = notas[i];
                    }
                }
                else
                {
                    Console.WriteLine("La entrada no es válida. Intente nuevamente.");
                    i--; 
                }
            }

            promedio = promedio / notas.Length;

            Console.WriteLine("Notas de laboratorio:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Lab no. " + (i + 2) + ": " + notas[i]);
            }

            Console.WriteLine("El promedio de notas es: " + promedio);
            Console.WriteLine("La nota más alta es: " + notaMasAlta);

            // Ejercicio no. 02
            Console.WriteLine("Ejercicio no. 02");
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(palabra))
            {
                Console.Write("Ingrese una letra: ");
                string letraInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(letraInput) && letraInput.Length == 1)
                {
                    char letra = letraInput[0];
                    int contador = 0;

                    int i = 0;
                    while (i < palabra.Length)
                    {
                        if (palabra[i] == letra)
                        {
                            contador++;
                        }
                        i++;
                    }

                    if (contador > 0)
                    {
                        Console.WriteLine("La letra " + letra + " existe en toda la palabra.");
                        Console.WriteLine("La letra " + letra + " aparece " + contador + " veces en la palabra.");
                    }
                    else
                    {
                        Console.WriteLine("La letra " + letra + " no existe en la palabra.");
                    }
                }
                else
                {
                    Console.WriteLine("La letra ingresada no es válida.");
                }
            }
            else
            {
                Console.WriteLine("La palabra ingresada no es válida.");
            }

            // Esperar a que el usuario presione una tecla para cerrar la consola
            Console.ReadKey();
        }
    }
}




