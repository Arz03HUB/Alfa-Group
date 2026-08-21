namespace Ejercicio_29
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa los 3 lados de un triangulo ");
            int lado1 = int.Parse(Console.ReadLine());
            int lado2 = int.Parse(Console.ReadLine());
            int lado3 = int.Parse(Console.ReadLine());
           
            if ((lado1 == lado2) && (lado2 == lado3) && (lado1 == lado3))
            {
                Console.WriteLine("Es un triangulo equilatero ");
            }
            else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
            {
                Console.WriteLine("Es un triangulo Isosceles");
            }
            else
            {
                Console.WriteLine("Es un triangulo Escaleno ");
            }
        }
    }
}

