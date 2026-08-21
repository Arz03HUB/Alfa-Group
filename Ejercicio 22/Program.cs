namespace Ejercicio_22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa 3 numeros para saber cual es el mayor ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("El numero " + num1 + " es mayor que " + num2 + " y " + num3);
            }
            else if ((num1 < num2) && (num2 > num3))
            {
                Console.WriteLine("El numero " + num2 + " es mayor que " + num1 + " y " + num3);
            }
            else
            {
                Console.WriteLine("El numero " + num3 + " es mayor que " + num1 + " y " + num2);
            }
        }
    }
}
