namespace Ejercicio_23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu nota ");
            int num1 = int.Parse(Console.ReadLine());
            if ((num1 >= 90) && (num1 <= 100))
            {
                Console.WriteLine("Aprobaste con A ");
            }
            else if ((num1 >= 80) && (num1 <= 89))
            {
                Console.WriteLine("Aprobaste con B ");
            }
            else if ((num1 >= 70) && (num1 <= 79))
            {
                Console.WriteLine("Aprobaste con C ");
            }
            else if ((num1 >= 60) && (num1 <= 69))
            {
                Console.WriteLine("Aprobaste con D ");
            }
            else
            {
                Console.WriteLine("Reprobaste  con F ni modo hay T2 y mesa");
            }
        }
    }
}
