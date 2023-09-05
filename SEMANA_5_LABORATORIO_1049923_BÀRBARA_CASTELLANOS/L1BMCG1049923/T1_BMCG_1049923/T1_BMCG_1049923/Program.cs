using System;

class Program
{
    static void Main(string[] args)
    {
    /*ENTRADA*/

        Console.WriteLine("Mi segundo programa");
        /*Nombre*/
    
        Console.WriteLine("Ingrese su nombre:");
        string Nombre = Console.ReadLine();

        /*Edad*/
        Console.WriteLine("Ingrese su edad:");
        string Edad = Console.ReadLine();

        /*Carrera*/
        Console.WriteLine("Ingrese su carrera:");
        string Carrera = Console.ReadLine();

        /*Carné*/
        Console.WriteLine("Ingrese su carné:");
        string Carné = Console.ReadLine();

    /*SALIDA*/
        Console.WriteLine("Mi segundo programa");
        Console.WriteLine("Nombre:" + Nombre);
        Console.WriteLine("Edad:" + Edad);
        Console.WriteLine("Carrera:" + Carrera);
        Console.WriteLine("Carné:" + Carné);
        Console.WriteLine("Soy " + Nombre + "," + " tengo " + Edad + " años " + " y estudio la carrera de " + Carrera + ".");
        Console.WriteLine("Mi número de Carné es: " + Carné);

        Console.ReadKey();
    }
}