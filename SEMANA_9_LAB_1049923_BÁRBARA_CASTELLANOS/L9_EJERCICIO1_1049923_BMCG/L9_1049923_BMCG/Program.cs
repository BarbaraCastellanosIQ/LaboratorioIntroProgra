class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero mayor que 0");
        int n = Convert.ToInt32(Console.ReadLine());
        int contador = 1;
        int sumatoria = 0;
        string texto = "";

        while (contador <= n)
        {
            texto = texto + contador + "+";
            sumatoria = sumatoria + contador;
            contador++;

        }

        Console.WriteLine(texto);

    }
}
