namespace Ejercicio_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa 2 numeros para dividir ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double division = (num1 % num2);
            Console.WriteLine("El residuo de dividir " + num1 + " entre " + num2 + " es: " + division);
           }
    }
}
