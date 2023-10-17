using System.Reflection;

class Program
{
    //clase ruta

    static void Main(string[] args)
    {
        // declaracion de variables

        int opcionmen = 0;
        int opcionmen2;
        double ajustadorprecio = 0;
        double ajustadorprecio1;
        double ajustadorprecio2;
        double preciototal = 0;
        int otroboleto = 0;
        int numerokm = 0;
        double tiempoviaje = 0;
        double tiempo1;
        // proporcionando atributos a los objetos

        Ruta ruta1 = new Ruta("Ruta 1", 51, 61, 14, 0, "Estacion Javier", "Estacion Trebol");
        Ruta ruta2 = new Ruta("Ruta 2", 51, 71, 28, 0, "Estacion Javier", "Estacion Don Bosco");
        Ruta ruta3 = new Ruta("Ruta 3", 71, 82, 13, 0, "Estacion Don Bosco", "Estacion Plaza Municipal");
        Ruta ruta4 = new Ruta("Ruta 4", 61, 51, 7, 0, "Estacion Trebol", "Estacion Javier");
        Ruta ruta5 = new Ruta("Ruta 5", 82, 51, 21, 0, "Estacion Plaza municipal", "Estacion Javier");

        Console.WriteLine("Bienvenido al sistema de transmetro");
        Console.WriteLine("Por favor ingrese la fecha en la que está realizando el viaje (DD/MM/AAAA): ");
        string fechaViaje = Console.ReadLine();
        Console.WriteLine("Por favor ingrese el numero de estacion de entrada ");
        int confirentrada = Convert.ToInt32(Console.ReadLine());

        do
        {

            while (otroboleto == 1)
            {
                Console.WriteLine("Tomando en cuenta que usted se encuentra en la estacion " + confirentrada);
                otroboleto = 3;
            }

            Console.WriteLine("Por favor ingrese el numero de estacion de salida ");
            int confirsalida = Convert.ToInt32(Console.ReadLine());


            if ((confirentrada == ruta1.estacionentrada && confirsalida == ruta1.estacionsalida) || (confirentrada == ruta2.estacionentrada && confirsalida == ruta2.estacionsalida) || (confirentrada == ruta3.estacionentrada && confirsalida == ruta3.estacionsalida) || (confirentrada == ruta4.estacionentrada && confirsalida == ruta4.estacionsalida) || (confirentrada == ruta5.estacionentrada && confirsalida == ruta5.estacionsalida))
            {


                while (opcionmen == 0)
                {
                    Console.WriteLine("\n Si usted se encuentra embarazada o viaja con niños menores de 3 años, presione 1; \n si usted tiene entre 15 y 25 años, presione 2;\n o presione 3 si no coincide con ninguna de las anteriores");
                    opcionmen2 = Convert.ToInt32(Console.ReadLine());
                    if (opcionmen2 == 1 || opcionmen2 == 2)
                    {
                        switch (opcionmen2)
                        {
                            case (1):
                                Console.WriteLine("Usted viaja gratis");
                                ajustadorprecio = 0;
                                break;
                            case (2):
                                Console.WriteLine("Usted tiene un 21% de descuento en su pasaje");
                                ajustadorprecio = 0.79;
                                break;

                        }
                    }
                    else
                    {
                        ajustadorprecio = 1;
                    }
                    Thread.Sleep(2500);
                    Console.Clear();
                    opcionmen = 1;
                }


                switch (confirentrada, confirsalida)
                {
                    case (51, 61):
                        ajustadorprecio1 = ((ruta1.numkilometros - 10) * 0.02) + (1 * 0.07);
                        ajustadorprecio2 = ajustadorprecio1 * ajustadorprecio;
                        ajustadorprecio2 = Math.Round(ajustadorprecio2, 2);
                        preciototal += ajustadorprecio2;
                        Console.WriteLine("Usted ha seleccionado la ruta {0}, con estacion de entrada {1} y estacion de salida {2}.\n Su ruta posee {3} kilometros.", ruta1.cualruta, ruta1.nomrutain, ruta1.nomrutafin, ruta1.numkilometros);
                        numerokm += ruta1.numkilometros;
                        tiempo1 = 40.0 / ruta1.numkilometros;
                        tiempo1 = Math.Round(tiempo1, 2);
                        tiempoviaje += tiempo1;
                        Console.WriteLine("Tu viaje por la " + ruta1.cualruta + " cuesta: " + ajustadorprecio2 + " quetzales");
                        Console.WriteLine("Tu viaje durara un aproximado de " + tiempo1 + " horas");
                        Console.WriteLine("Presiona enter para avanzar");
                        Console.ReadKey();
                        Console.WriteLine("Okay empecemos el viaje");
                        Console.WriteLine("Espera mientras se realiza el viaje... tomara unos segundos...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Viaje completado");
                        Thread.Sleep(2500);
                        confirentrada = 61;
                        Console.Clear();

                        break;
                    case (51, 72):
                        ajustadorprecio1 = ((ruta2.numkilometros - 10) * 0.02) + (1 * 0.07);
                        ajustadorprecio2 = ajustadorprecio1 * ajustadorprecio;
                        ajustadorprecio2 = Math.Round(ajustadorprecio2, 2);
                        preciototal += ajustadorprecio2;
                        Console.WriteLine("Usted ha seleccionado la ruta {0}, con estacion de entrada {1} y estacion de salida {2}.\n Su ruta posee {3} kilometros.", ruta2.cualruta, ruta2.nomrutain, ruta2.nomrutafin, ruta2.numkilometros);
                        numerokm += ruta2.numkilometros;
                        tiempo1 = 40.0 / ruta2.numkilometros;
                        tiempo1 = Math.Round(tiempo1, 2);
                        tiempoviaje += tiempo1;
                        Console.WriteLine("Tu viaje por la " + ruta2.cualruta + " cuesta: " + ajustadorprecio2 + " quetzales");
                        Console.WriteLine("Tu viaje durara un aproximado de " + tiempo1 + " horas");
                        Console.WriteLine("Presiona enter para avanzar");
                        Console.ReadKey();
                        Console.WriteLine("Okay empecemos el viaje");
                        Console.WriteLine("Espera mientras se realiza el viaje... tomara unos segundos...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Viaje completado");
                        Thread.Sleep(2500);
                        confirentrada = 72;
                        Console.Clear();

                        break;
                    case (71, 82):
                        ajustadorprecio1 = ((ruta3.numkilometros - 10) * 0.02) + (1 * 0.07);
                        ajustadorprecio2 = ajustadorprecio1 * ajustadorprecio;
                        ajustadorprecio2 = Math.Round(ajustadorprecio2, 2);
                        preciototal += ajustadorprecio2;
                        Console.WriteLine("Usted ha seleccionado la ruta {0}, con estacion de entrada {1} y estacion de salida {2}.\n Su ruta posee {3} kilometros.", ruta3.cualruta, ruta3.nomrutain, ruta3.nomrutafin, ruta3.numkilometros);
                        numerokm += ruta3.numkilometros;
                        tiempo1 = 40.0 / ruta3.numkilometros;
                        tiempo1 = Math.Round(tiempo1, 2);
                        tiempoviaje += tiempo1;
                        Console.WriteLine("Tu viaje por la " + ruta3.cualruta + " cuesta: " + ajustadorprecio2 + " quetzales");
                        Console.WriteLine("Tu viaje durara un aproximado de " + tiempo1 + " horas");
                        Console.WriteLine("Presiona enter para avanzar");
                        Console.ReadKey();
                        Console.WriteLine("Okay empecemos el viaje");
                        Console.WriteLine("Espera mientras se realiza el viaje... tomara unos segundos...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Viaje completado");
                        Thread.Sleep(2500);
                        confirentrada = 82;
                        Console.Clear();

                        break;
                    case (61, 51):
                        ajustadorprecio1 = (ruta4.numkilometros * 0.02);
                        ajustadorprecio2 = ajustadorprecio1 * ajustadorprecio;
                        ajustadorprecio2 = Math.Round(ajustadorprecio2, 2);
                        preciototal += ajustadorprecio2;
                        Console.WriteLine("Usted ha seleccionado la ruta {0}, con estacion de entrada {1} y estacion de salida {2}.\n Su ruta posee {3} kilometros.", ruta4.cualruta, ruta4.nomrutain, ruta4.nomrutafin, ruta4.numkilometros);
                        numerokm += ruta4.numkilometros;
                        tiempo1 = 40.0 / ruta4.numkilometros;
                        tiempo1 = Math.Round(tiempo1, 2);
                        tiempoviaje += tiempo1;
                        Console.WriteLine("Tu viaje por la " + ruta4.cualruta + " cuesta: " + ajustadorprecio2 + " quetzales");
                        Console.WriteLine("Tu viaje durara un aproximado de " + tiempo1 + " horas");
                        Console.WriteLine("Presiona enter para avanzar");
                        Console.ReadKey();
                        Console.WriteLine("Okay empecemos el viaje");
                        Console.WriteLine("Espera mientras se realiza el viaje... tomara unos segundos...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Viaje completado");
                        Thread.Sleep(2500);
                        confirentrada = 51;
                        Console.Clear();

                        break;
                    case (82, 51):
                        ajustadorprecio1 = ((ruta5.numkilometros - 10) * 0.02) + (1 * 0.07);
                        ajustadorprecio2 = ajustadorprecio1 * ajustadorprecio;
                        ajustadorprecio2 = Math.Round(ajustadorprecio2, 2);
                        preciototal += ajustadorprecio2;
                        Console.WriteLine("Usted ha seleccionado la ruta {0}, con estacion de entrada {1} y estacion de salida {2}.\n Su ruta posee {3} kilometros.", ruta5.cualruta, ruta5.nomrutain, ruta5.nomrutafin, ruta5.numkilometros);
                        numerokm += ruta5.numkilometros;
                        tiempo1 = 40.0 / ruta5.numkilometros;
                        tiempo1 = Math.Round(tiempo1, 2);
                        tiempoviaje += tiempo1;
                        Console.WriteLine("Tu viaje por la " + ruta5.cualruta + " cuesta: " + ajustadorprecio2 + " quetzales");
                        Console.WriteLine("Tu viaje durara un aproximado de " + tiempo1 + " horas");
                        Console.WriteLine("Presiona enter para avanzar");
                        Console.ReadKey();
                        Console.WriteLine("Okay empecemos el viaje");
                        Console.WriteLine("Espera mientras se realiza el viaje... tomara unos segundos...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Viaje completado");
                        Thread.Sleep(2500);
                        confirentrada = 51;
                        Console.Clear();

                        break;
                }

                Console.WriteLine("Desea realizar otro viaje? Presione 1 para hacerlo o 2 para salir");
                otroboleto = Convert.ToInt32(Console.ReadLine());

            }
            else
            {

                Console.WriteLine("Las estaciones ingresadas no coinciden con una posible ruta");
                Console.WriteLine("Por favor presione 1 para volver a intentar o 2 para salir");
                otroboleto = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        } while (otroboleto == 1 || otroboleto == 3);

        Console.WriteLine("Gracias por utilizar el sistema de transmetro");
        Console.WriteLine("Usted ha recorrido un total de: " + numerokm + " kilometros y su total a pagar es de: " + preciototal + " quetzales.");
        Console.ReadLine();

    }

}
public class Ruta
{
    public string cualruta { get; set; }
    public int estacionentrada { get; set; }
    public int estacionsalida { get; set; }
    public int numkilometros { get; set; }
    public double precioruta { get; set; }
    public string nomrutain { get; set; }
    public string nomrutafin { get; set; }

    // constructor
    public Ruta(string cualruta, int estacionentrada, int estacionsalida, int numkilometros, double precioruta, string nomrutain, string nomrutafin)
    {
        this.cualruta = cualruta;
        this.estacionentrada = estacionentrada;
        this.estacionsalida = estacionsalida;
        this.numkilometros = numkilometros;
        this.precioruta = precioruta;
        this.nomrutain = nomrutain;
        this.nomrutafin = nomrutafin;

    }

}