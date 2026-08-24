using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDelCalamar
{
    internal class JuegoDelCalamar
    {
        static void Main(string[] args)
        {
            const int EDAD_MINIMA = 18;
            const double PREMIO_TOTAL = 45600000000;

            string jugador1;
            string jugador2;
            string jugador3;
            string jugadorElegido = "";
            string numeroJugador = "";
            string prueba = "";
            string estado = "";
            string clasificacion = "";

            int opcionJugador;
            int edad;
            int opcionPrueba;
            int figura;
            int aguja;
            int puntaje = 0;

            Console.WriteLine("===================================");
            Console.WriteLine("======= EL JUEGO DEL CALAMAR=======");
            Console.WriteLine("=====UNICEN - Programacion II======");
            Console.WriteLine("===================================");

            Console.WriteLine("--- REGISTRO DE JUGADORES ---");

            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();

            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine();

            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();

            Console.WriteLine("--- SELECCION DE JUGADOR ---");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);

            Console.WriteLine("Cual de los 3 jugadores va a la arena (1-3)");
            Console.WriteLine("Si seleccionas un jugador invalido se escojera a 3 ");
            opcionJugador = int.Parse(Console.ReadLine());

            if (opcionJugador == 1)
            {
                jugadorElegido = jugador1;
                numeroJugador = "001";
            }
            else
            {
                if (opcionJugador == 2)
                {
                    jugadorElegido = jugador2;
                    numeroJugador = "002";
                }
                else
                {
                    jugadorElegido = jugador3;
                    numeroJugador = "003";
                }
            }

            Console.Write("Ingrese la edad de " + jugadorElegido + ": ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= EDAD_MINIMA)
            {
                Console.WriteLine("ACCESO PERMITIDO. " + jugadorElegido + " puede competir.");

                Console.WriteLine("\n--- SELECCION DE PRUEBA ---");
                Console.WriteLine("1) Luz roja, luz verde");
                Console.WriteLine("2) Dalgona (galleta de azucar)");
                Console.WriteLine("3) Tira y afloja");

                Console.Write("Elija la prueba (1-3): ");
                opcionPrueba = int.Parse(Console.ReadLine());

                if (opcionPrueba == 1)
                {
                    prueba = "Luz roja, luz verde";
                    estado = "SOBREVIVE";
                    puntaje = 100;
                    clasificacion = "TRIUNFO";
                }
                else
                {
                    if (opcionPrueba == 2)
                    {
                        prueba = "Dalgona (galleta de azucar)";

                        Console.WriteLine("\nElija la figura:");
                        Console.WriteLine("1) Triangulo (facil)");
                        Console.WriteLine("2) Estrella (medio)");
                        Console.WriteLine("3) Sombrilla (dificil)");

                        Console.Write("Figura elegida: ");
                        figura = int.Parse(Console.ReadLine());

                        Console.Write("Usa la aguja calentada? (1 = si / 2 = no): ");
                        aguja = int.Parse(Console.ReadLine());

                        if (aguja == 1)
                        {
                            estado = "SOBREVIVE";
                            puntaje = 100;
                            clasificacion = "TRIUNFO";

                            Console.WriteLine("La aguja caliente corta el azucar. "
                                + jugadorElegido + " lo logra!");
                        }
                        else
                        {
                            estado = "LE DISPARARON EN LA 100";
                            puntaje = 0;
                            clasificacion = "ELIMINADO";
                        }
                    }
                    else
                    {
                        prueba = "Tira y afloja";
                        estado = "SOBREVIVE";
                        puntaje = 100;
                        clasificacion = "TRIUNFO";
                    }
                }

                Console.WriteLine("\n=================================");
                Console.WriteLine("     REPORTE FINAL");
                Console.WriteLine("=================================");
                Console.WriteLine("Jugador       : " + jugadorElegido);
                Console.WriteLine("Numero        : " + numeroJugador);
                Console.WriteLine("Prueba        : " + prueba);
                Console.WriteLine("Estado        : " + estado);
                Console.WriteLine("Puntaje       : " + puntaje + " / 100");
                Console.WriteLine("Clasificacion : " + clasificacion);
                Console.WriteLine("Premio en juego: " + PREMIO_TOTAL + " won");
            }
            else
            {
                Console.WriteLine("ACCESO DENEGADO.");
            }
        }
    }
}
    

