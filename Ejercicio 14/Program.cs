namespace Ejercicio_14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un numero para saber si es positivo o negativo ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine("El numero " + num1 + " es positivo");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("El numero es cero");
            }
            else
            {
                Console.WriteLine("El numero " + num1 + " es negativo");
            }
        }
    }
}
