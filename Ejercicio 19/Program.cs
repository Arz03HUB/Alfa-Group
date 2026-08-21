namespace Ejercicio_19
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa 2 numeros para dividir ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double residuo = (num1 % num2);
            if (residuo == 0)
            {
                Console.WriteLine("El numero " + num1 + " se divide perfectamente entre " + num2);
            }
            else
            {
                 Console.WriteLine("El numero " + num1 + " no se divide perfectamente entre " + num2);
            }
        }
    }
}
