////class Program
//{
//    static void Main(string[] args)
//        int a, b, c;

//    a = 7;
//    b = a;
//    c = b++;

//    //diferencias entre tipos de datos numéricos, boleanos y cadenas

//    string cadena;
//    int entero;
//    float flotante;
//    decimal dec;
//    bool boleano;

//    cadena = "texto";
//    entero = 100;
//    flotante = 3.1416f;
//    dec = 10.00m
//    boleano = true;

//    //Operaciones Aritméticas (incluyendo DIV Y MOD)

//}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio no. 01: Operaciones aritméticas");

        Console.WriteLine("Ingrese un número: ");
        string numero1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numero1);

        Console.WriteLine("Ingrese otro número: ");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        int suma = num1 + num2;

        Console.WriteLine("Suma: " + num1 + "+" + num2 + "=" + suma);

        int resta = num1 - num2;

        Console.WriteLine("Resta: " + num1 + "-" + num2 + "=" + resta);

        int multiplicación = num1 * num2;

        Console.WriteLine("Multiplicación: " + num1 + "*" + num2 + "=" + multiplicación);

        int división = num1 / num2;

        Console.WriteLine("División: " + num1 + "/" + num2 + "=" + división);

        int residuo = num1 % num2;

        Console.WriteLine("Residuo: " + num1 + "%" + num2 + "=" + residuo);

        Console.WriteLine("Ejercicio 2: operaciones booleanas");

        if (num1 > num2)
        {
            Console.WriteLine( num1 + " es mayor que: " + num2);
        }

        else if (num1 < num2)
        {
            Console.WriteLine( num1 + " es menor que: " + num2);
        }

        else if (num1 == num2)
        {
            Console.WriteLine( num1 + " es igual que: " + num2);
        }

        Console.WriteLine("Ejercicio 3: Jerarquía de operaciones");

        Console.WriteLine("Ingrese nuevamente, otro número: ");
        string numero3 = Console.ReadLine();
        int num3 = Convert.ToInt32(numero3);

        Console.WriteLine("Ingrese otro número para realizar las operaciones: ");
        string numero4 = Console.ReadLine();
        int num4 = Convert.ToInt32(numero4);

        Console.WriteLine("Ingrese nuevamente, otro número: ");
        string numero5 = Console.ReadLine();
        int num5 = Convert.ToInt32(numero5);

        int operación1 = (num3 * num4 + num5);

        Console.WriteLine("Operación 1: " + num3 + "*" + num4 + "+" + num5 + "=" + operación1);

        int operación2 = num3 * (num4 + num5);

        Console.WriteLine("Operación 2: " + num3 + "*" + "(" + num4 + "+" + num5 + ")" + "=" + operación2);

        int operación3 = num3 / (num4 * num5);

        Console.WriteLine("Operación 3: " + num3 + "/" + "(" + num4 + "*" + num5 + ")" + "=" + operación3);


        Console.ReadKey();

    }
}