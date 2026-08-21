namespace Ejercicio_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 2 numero");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tus numeros sin cambiar son A: " + num1 + " y B: " + num2);
            
            int num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("Tus numeros intercambiados son A: " + num1 + " y B: " + num2);
        }
    }
}
