using System.ComponentModel.Design;

namespace Ejercicio_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que es lo que decea realizar ");
            Console.WriteLine("1: Suma ");
            Console.WriteLine("2: Resta  ");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4: Division");
            int opcion = int.Parse(Console.ReadLine());

            if ((opcion <= 4) && (opcion >= 1))
            {
                Console.WriteLine("Ingrese un numero decimal ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un  segundon numero decimal ");
                double num2 = double.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    double suma = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + suma);
                }
                else if (opcion == 2)
                {
                    double resta = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resta);
                }
                else if (opcion == 3)
                {
                    double multiplicacion = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacion);
                }
                else if (opcion == 4)
                {
                    if (num2 != 0)
                    {
                        double division = num1 / num2;
                        Console.WriteLine("El resultado de la division es: " + division);
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida. Por favor, seleccione una opcion del 1 al 4.");

            }
        } 
    }
}
