using System;

namespace dev1
{
    public class Pcalculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("========BIENVENIDO =========");
            Console.WriteLine("============================");
            Console.WriteLine("==========A===MI============");
            Console.WriteLine("============================");
            Console.WriteLine("========CALCULADORA=========");
            Console.WriteLine("============================");

            Console.WriteLine("¿Qué es lo que deseas hacer?");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicación");
            Console.WriteLine("4: División");
            Console.WriteLine("5: Residuo");

            Console.Write("\nElige una opción (1-5): ");

            // Validación para aceptar únicamente números enteros entre 1 y 5 (rechaza decimales y texto)
            if (!int.TryParse(Console.ReadLine(), out int operacion) || operacion < 1 || operacion > 5)
            {
                Console.WriteLine("\nError: Debes ingresar un número entero válido entre 1 y 5.");
                return;
            }

            Console.Write("\nIngresa el número para A: ");
            double priNum = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingresa el número para B: ");
            double segNum = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine();

            // Estructura condicional usando if / else if
            if (operacion == 1)
            {
                Console.WriteLine($"La suma de estos números es: {priNum + segNum}");
            }
            else if (operacion == 2)
            {
                Console.WriteLine($"La resta de estos números es: {priNum - segNum}");
            }
            else if (operacion == 3)
            {
                Console.WriteLine($"La multiplicación de estos números es: {priNum * segNum}");
            }
            else if (operacion == 4)
            {
                if (segNum == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                else
                {
                    Console.WriteLine($"La división de estos números es: {priNum / segNum}");
                }
            }
            else if (operacion == 5)
            {
                if (segNum == 0)
                {
                    Console.WriteLine("Error: No se puede calcular el residuo con divisor cero.");
                }
                else
                {
                    Console.WriteLine($"El residuo de estos números es: {priNum % segNum}");
                }
            }
        }
    }
}
