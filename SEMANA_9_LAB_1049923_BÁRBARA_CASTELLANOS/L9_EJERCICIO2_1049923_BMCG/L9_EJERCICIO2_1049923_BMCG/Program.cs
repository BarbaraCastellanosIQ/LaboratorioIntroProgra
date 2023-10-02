class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio No. 2");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nTabla del " + i + ":\t");
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i * j + "\t");
            }
        }
        Console.ReadLine();
    }
}

