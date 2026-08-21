namespace Ejercicio_17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un anio para saber si es bisiesto ");
            int bisiest = int.Parse(Console.ReadLine());
            int anio = (bisiest % 4);
            if (anio == 0)
            {
                Console.WriteLine("El anio " + bisiest + " es bisiesto ");
            }
            else
            {
                Console.WriteLine("El anio " + bisiest + " no es bisiesto ");
            }
        }
    }
}
