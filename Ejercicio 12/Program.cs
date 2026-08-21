namespace Ejercicio_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un numero entero para saber si es par o impar ");
            int num1 = int.Parse(Console.ReadLine());
            double residuo = (num1 % 2);
            if (residuo == 0)
            {
                Console.WriteLine("El numero " + num1 + " es par");
            }
            else
            {
                Console.WriteLine("El numero " + num1 + " es impar");
            }
        }
    }
}
