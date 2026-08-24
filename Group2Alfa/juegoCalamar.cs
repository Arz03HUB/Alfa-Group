using System;

namespace JuegoDelCalamar
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NOMBRE_JUEGO = "EL JUEGO DEL CALAMAR";
            const int TOTAL_CUPOS = 3;
            const int EDAD_MINIMA = 18;
            const double PREMIO_TOTAL = 45600000000;
            const string PRUEBA_1 = "Luz Roja, Luz Verde";
            const string PRUEBA_2 = "Panal de Azúcar (Dalgona)";
            const string PRUEBA_3 = "Tira y Afloja";
            const string ESTADO_VIVO = "VIVO";
            const string ESTADO_FUERA = "ELIMINADO";

            string jugador1;
            string jugador2;
            string jugador3;
            string jugadorElegido = "";
            string estadoFinal = "";
            int numeroJugador = 0;
            int puntaje = 0;

            int opcionJugador;
            int opcionPrueba;
            int decision;
            int edad;
            string pruebaElegida = "";
            string clasificacion = "";

            Console.WriteLine("========================================");
            Console.WriteLine(NOMBRE_JUEGO);
            Console.WriteLine("Cupos habilitados: " + TOTAL_CUPOS);
            Console.WriteLine("========================================\n");

            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();

            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine();

            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();

            Console.WriteLine("\n--- JUGADORES REGISTRADOS ---");
            Console.WriteLine("001: " + jugador1);
            Console.WriteLine("002: " + jugador2);
            Console.WriteLine("003: " + jugador3);
            Console.WriteLine("-----------------------------\n");

            Console.Write("¿Qué jugador entra a la arena? (1-3): ");
            opcionJugador = int.Parse(Console.ReadLine());

            if (opcionJugador == 1)
            {
                jugadorElegido = jugador1;
                numeroJugador = 1;
            }
            else if (opcionJugador == 2)
            {
                jugadorElegido = jugador2;
                numeroJugador = 2;
            }
            else if (opcionJugador == 3)
            {
                jugadorElegido = jugador3;
                numeroJugador = 3;
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            Console.WriteLine("\nJugador seleccionado: " + jugadorElegido + " (N° " + numeroJugador + ")\n");

            Console.Write("Ingresa la edad del jugador: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= EDAD_MINIMA)
            {
                Console.WriteLine("Acceso concedido a los juegos.");
                puntaje = puntaje + 20;
            }
            else
            {
                Console.WriteLine("ACCESO DENEGADO: No cumple la edad mínima.");
                estadoFinal = ESTADO_FUERA;
                return;
            }

            Console.WriteLine("\n--- PRUEBAS DISPONIBLES ---");
            Console.WriteLine("1. " + PRUEBA_1);
            Console.WriteLine("2. " + PRUEBA_2);
            Console.WriteLine("3. " + PRUEBA_3);
            Console.Write("Elige una prueba (1-3): ");
            opcionPrueba = int.Parse(Console.ReadLine());

            if (opcionPrueba == 1)
            {
                pruebaElegida = PRUEBA_1;
                Console.Write("¿Te detienes cuando la muñeca gira la cabeza? (1 = Sí / 2 = No): ");
                decision = int.Parse(Console.ReadLine());

                if (decision == 1)
                {
                    estadoFinal = ESTADO_VIVO;
                    puntaje = puntaje + 50;
                }
                else
                {
                    estadoFinal = ESTADO_FUERA;
                }
            }
            else if (opcionPrueba == 2)
            {
                pruebaElegida = PRUEBA_2;
                Console.WriteLine("Figuras: 1. Círculo | 2. Triángulo | 3. Paraguas");
                Console.Write("Elige una figura (1-3): ");
                decision = int.Parse(Console.ReadLine());

                if (decision == 3)
                {
                    Console.Write("¿Usas la técnica de calentar la aguja o lamer la galleta? (1 = Sí / 2 = No): ");
                    decision = int.Parse(Console.ReadLine());

                    if (decision == 1)
                    {
                        estadoFinal = ESTADO_VIVO;
                        puntaje = puntaje + 80;
                    }
                    else
                    {
                        estadoFinal = ESTADO_FUERA;
                    }
                }
                else
                {
                    estadoFinal = ESTADO_VIVO;
                    puntaje = puntaje + 40;
                }
            }
            else if (opcionPrueba == 3)
            {
                pruebaElegida = PRUEBA_3;
                Console.Write("¿Tu equipo coordina y usa la estrategia de tirar juntos? (1 = Sí / 2 = No): ");
                decision = int.Parse(Console.ReadLine());

                if (decision == 1)
                {
                    estadoFinal = ESTADO_VIVO;
                    puntaje = puntaje + 60;
                }
                else
                {
                    estadoFinal = ESTADO_FUERA;
                }
            }
            else
            {
                Console.WriteLine("Prueba inválida.");
                estadoFinal = ESTADO_FUERA;
            }

            if (puntaje >= 90)
            {
                clasificacion = "Rango S - Sobresaliente";
            }
            else if (puntaje >= 60)
            {
                clasificacion = "Rango A - Experto";
            }
            else if (puntaje >= 30)
            {
                clasificacion = "Rango B - Regular";
            }
            else
            {
                clasificacion = "Rango C - Insuficiente";
            }


            Console.WriteLine("\n========================================");
            Console.WriteLine("            REPORTE FINAL               ");
            Console.WriteLine("========================================");
            Console.WriteLine("Jugador:        " + jugadorElegido);
            Console.WriteLine("Número:         00" + numeroJugador);
            Console.WriteLine("Prueba jugada:  " + pruebaElegida);
            Console.WriteLine("Estado final:   " + estadoFinal);
            Console.WriteLine("Puntaje total:  " + puntaje);
            Console.WriteLine("Clasificación:  " + clasificacion);

            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine("Premio ganado:  $" + PREMIO_TOTAL + " KRW");
            }

            Console.WriteLine("========================================");
            Console.ReadKey();
        }
    }
}