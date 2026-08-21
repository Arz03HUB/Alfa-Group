namespace Ejercicio_11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu edad ");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad felicidades ya eres legal ");
            }
            else
            {
                Console.WriteLine("Eres menor de edad aun eres ilegal ");
            }
            
        }
    }
}
