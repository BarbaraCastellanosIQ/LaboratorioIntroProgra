class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 2");
        int numero;
        string entrada;

        Console.WriteLine("Ingrese un número del 1 al 7: ");
        entrada = Console.ReadLine();
        numero = Int32.Parse(entrada);

        if (numero >= 1 && numero <= 7)
        {
            if (numero == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Miércoles");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Sábado");
            }
            else if (numero == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Error el número ingresado no se encuentra entre los valores de 1 y 7");
            }
        }
    }
}

