namespace Ejercicio_15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu nota ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 >= 51)
            {
                Console.WriteLine("Aprobaste felicidades ");
            }
            else
            {
                Console.WriteLine("Reprobaste ni modo hay T2 y mesa");
            }
        }
    }
}
