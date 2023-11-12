//Bárbara Castellanos 1049923
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al juego de dados, ¿Tienes tanta suerte como crees? ¡Ven y ponte a prueba!");

        int partidas, tiros;
        Console.Write("Ingresa la cantidad de partidas a jugar que desee: ");
        if (!int.TryParse(Console.ReadLine(), out partidas) || partidas <= 0) //El "!" junto con el TryParse verifica si es entero el número ingresado y si no es así, se ejecuta el mensaje de invalidación
        {
            Console.WriteLine("La cantidad de partidas es inválida, por favor, ingrese nuevamente la cantidad de partidas, siendo un número entero y positivo.");
            return;
        }

        Console.Write("Ingresa la cantidad de tiros por partida a jugar que desee: ");
        if (!int.TryParse(Console.ReadLine(), out tiros) || tiros <= 0)
        {
            Console.WriteLine("La cantidad de tiros es inválida, por favor, ingrese nuevamente la cantidad de tiros, siendo un número entero y positivo");
            return;
        }

        // Variables declaradas para guardar la información que se recolecte para las estadísticas del final.
        int partidasGanadasJugador = 0;
        int tirossumaPar = 0;
        int tirossumaImpar = 0;
        int tirosIguales = 0;
        int probabilidadGanar = 0;

        //Se generan los números aleatorios con "Random".

        Random random = new Random();

        int puntajeFinalJugador = 0;
        int puntajeFinalCasa = 0;

        for (int partida = 1; partida <= partidas; partida++)
        {
            Console.WriteLine("Partida:" + partida );
            int puntajeJugador = 0;
            int puntajeCasa = 0;
            bool jugadorGana = false; //Se señala como falso porque al inicio de cada partida o tirada, el jugador todavía no ha ganado

            for (int tiro = 1; tiro <= tiros; tiro++)
            {
                int dado1 = random.Next(1, 6);
                int dado2 = random.Next(1, 6);
                int suma = dado1 + dado2;

                Console.WriteLine("Tiro: " + tiro );

                Console.WriteLine("Dado 1: " + dado1 + " , " + "Dado 2: " + dado2);

                Console.WriteLine("Suma de los dados lanzados: " + suma);

                Thread.Sleep(1000); // Para simular la espera del tiro de los dados. (1 segundo)

                if (tiro == 1)
                {
                    if (suma == 12 || suma == 6)
                    {
                        jugadorGana = true; //Si el jugador gana, se ejecuta el procedimiento de este caso (Gracias al bool).
                        puntajeJugador += 12;
                    }
                    else if (suma == 4 || suma == 10) //Se señala que si la suma da estos resultados, el puntaje de la casa aumenta 12 puntos.
                    {
                        puntajeCasa += 12;
                    }
                    else
                    {
                        puntajeJugador = suma; // Si no, el puntaje del jugador va sumando más puntos.
                    }
                }
                else
                {
                    if (suma == 11)
                    {
                        puntajeCasa += 6;
                    }
                    else if (jugadorGana)
                    {
                        puntajeJugador += suma;
                    }
                    else
                    {
                        puntajeCasa += suma;
                    }
                }

                if (suma % 2 == 0) //Cuenta los tiros pares de los dados, o sea verifica si la suma de los valores da valores pares.
                {
                    tirossumaPar++;
                }
                else
                {
                    tirossumaImpar++;
                }

                if (dado1 == dado2) //Verifica si las dos caras de los lados lanzados son iguales, para ir almacenando ese conteo en "tiradasIguales"
                {
                    tirosIguales++;
                }
            }

            if (jugadorGana)
            {
                partidasGanadasJugador++; //Si el jugador gana una tirada, va aumentando en 1 en 1, en las tiradasGanadasJugador
            }

            if (partidas <= 0)
            {
            }
            else
            {
                probabilidadGanar = (partidasGanadasJugador * 100) / partidas;
            }

            puntajeFinalJugador += puntajeJugador;
            puntajeFinalCasa += puntajeCasa;
        }


        Console.WriteLine("Resultado final:");
        Console.WriteLine("El ganador de la partida:" + (partidasGanadasJugador > partidas / 2 ? "El jugador" : "La Casa") ); //Si el número de tiradas ganadas por el jugador es mayor que la mitad del número total de partidas, la expresión devuelve true. Esto significa que el jugador ha ganado más de la mitad de las partidas. Si es "True" se muestra "El jugador" y si es "False" se muestra "La casa".
        Console.WriteLine("Tiros realizados en cada partida:" + tiros);
        Console.WriteLine("Partidas ganadas por el jugador:" + partidasGanadasJugador );
        Console.WriteLine("Probabilidad de ganar:" + probabilidadGanar + "%" );
        Console.WriteLine("Tiros con suma par :" + tirossumaPar);
        Console.WriteLine("Tiros con suma impar:" + tirossumaImpar);
        Console.WriteLine("Tiros con números iguales:" + tirosIguales);
        Console.WriteLine("Puntaje final del jugador:" + puntajeFinalJugador);
        Console.WriteLine("Puntaje final de la Casa:" + puntajeFinalCasa);

        Console.ReadKey();
    }
}

