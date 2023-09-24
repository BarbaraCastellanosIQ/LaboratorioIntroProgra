class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tarea 1: calculadora de fórmulas de movimiento rectilíneo");

        Console.WriteLine("El programa calculará la variable faltante de la fórmula Vf=Vo + at");

        Console.WriteLine("Ingresar un valor para la velocidad final, en caso de desconocerla coloque N/A: ");
        string numero1 = Console.ReadLine();
        double VF = 0;

        if (numero1 != "N/A")
        {
            VF = Convert.ToDouble(numero1);
        }

        Console.WriteLine("Ingresar un valor para la velocidad inicial, en caso de desconocerla coloque N/A: ");
        string numero2 = Console.ReadLine();
        double VO = 0;

        if (numero2 != "N/A")
        {
            VO = Convert.ToDouble(numero2);
        }

        Console.WriteLine("Ingresar un valor para la aceleración, en caso de desconocerla coloque N/A: ");
        string numero3 = Console.ReadLine();
        double AC = 0;

        if (numero3 != "N/A")
        {
            AC = Convert.ToDouble(numero3);
        }

        Console.WriteLine("Ingresar un valor para el tiempo, en caso de desconocerla coloque N/A: ");
        string numero4 = Console.ReadLine();
        double TIEM = 0;

        if (numero4 != "N/A")
        {
            TIEM = Convert.ToDouble(numero4);
        }

        double respuesta1 = VO + AC * TIEM;

        double respuesta2 = VF - (AC * TIEM);

        double respuesta3 = (VF - VO) / TIEM;

        double respuesta4 = (VF - VO) / AC;

        if (numero1 == "N/A" && numero2 == "N/A" && numero3 == "N/A" && numero4 == "N/A")
        {
            Console.WriteLine("Ingresar mínimo tres variables");
        }
        else if (numero1 == "N/A")
        {
            Console.WriteLine("La velocidad final es: " + respuesta1);
        }
        else if (numero2 == "N/A")
        {
            Console.WriteLine("La velocidad inicial es: " + respuesta2);
        }
        else if (numero3 == "N/A")
        {
            Console.WriteLine("La aceleración es: " + respuesta3);
        }
        else if (numero4 == "N/A")
        {
            Console.WriteLine("El tiempo es: " + respuesta4);
        }
        else
        {
            Console.WriteLine("Debe ingresar únicamente tres valores");
        }

        Console.WriteLine("Fin del programa");
    }
}