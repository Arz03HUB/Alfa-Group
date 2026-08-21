namespace Ejercicio_20
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa las horas que trabajaste ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 >= 40)
            {
                Console.WriteLine("Tienes horas extras :) ");
            }
            else
            {
                Console.WriteLine("Jornada normal :( ");
            }
        }   }
}
