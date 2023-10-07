class Program
{
    static void Main()
    {
        Console.WriteLine("Tarea no. 01: Semana 9-Bárbara Castellanos 1049923");
        Console.WriteLine("Parte A");
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("El número debe ser un entero mayor que 0");
        }
        else
        {
            double suma = 0.0;
            int i = 1;

            while (i <= num)
            {
                suma += 1.0 / i;
                i++;
            }
            Console.WriteLine("La primera serie tiene como resultado:  " + suma);
        }

        Console.WriteLine("Parte B");
        if (num <= 0)
        {
            Console.WriteLine("El número debe ser un entero mayor que 0");
        }
        else
        {
            double suma2 = 0.0;

            for (int j = 1; j <= num; j++)
            {
                suma2 += 1.0 / Math.Pow(2, j);

            }
            Console.WriteLine("La primera serie tiene como resultado: " + suma2);
        }
    }
}