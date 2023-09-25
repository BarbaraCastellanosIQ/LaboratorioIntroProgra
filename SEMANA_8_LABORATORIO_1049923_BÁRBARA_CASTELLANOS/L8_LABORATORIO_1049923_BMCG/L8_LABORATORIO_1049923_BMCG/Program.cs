using System;
using System.ComponentModel.Design;
using System.Globalization;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laboratorio semana 8");

        //        int num = Convert.ToInt32(Console.ReadLine());

        //        do
        //        {
        //            Console.WriteLine("El número ingresado es:" + num);
        //            Console.WriteLine("\nIngrese un numero:");

        //            num = Convert.ToInt32(Console.ReadLine());
        //        } while (num != 0)

        //        while(num != 0)
        //        {
        //            if (num > 0)
        //            {
        //                Console.WriteLine(\nPositivo);

        //            }
        //        }

        //    }
        //}

        Console.WriteLine("\nIngrese un numero mayor que 0:");
        int N = Convert.ToInt32(Console.ReadLine());
        int A = 0;
        int B = 1;
        int C = 0;
        int i = 2;
        String resultado = "";


        if (N > 0)
        {
            resultado = A.ToString();

            if (N > 1)
            {
                resultado += B.ToString();

                while (i < N)
                {
                    C = A + B;
                    resultado += C.ToString();
                    A = B;
                    B = C;
                    i++;

                }

                Console.WriteLine("Resultado= " + resultado);
            }
            else
            {
                Console.WriteLine("Resultado= " + resultado);

            }
        }
        else
        {
            Console.WriteLine("Resultado= " + resultado);
        }


    }
}

