namespace Ejercicio_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa los grados celsius que quieras convertir a Fahrenheit");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Grados Celsius: " + celsius + " en grados Fahrenheit: " + fahrenheit);
        }
    }
}
