namespace Ejercicio_28
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estas ingresando a un peaje que tipo de vehiculo tienes");
            Console.WriteLine("1: Moto ");
            Console.WriteLine("2: Auto ");
            Console.WriteLine("3: Autobus ");
            Console.WriteLine("4: camion ");
            int vehiculo = int.Parse(Console.ReadLine());

            if (vehiculo == 1)
            {
                Console.WriteLine("El peaje para tu vehiculo de transporte es : 2$ ");
            }
            else if (vehiculo == 2)
            {
                Console.WriteLine("El peaje para tu vehiculo de transporte es : 5$ ");
            }
            else if (vehiculo == 3)
            {
                Console.WriteLine("El peaje para tu vehiculo de transporte es : 10$ ");
            }
            else if (vehiculo == 4)
            {
                Console.WriteLine("El peaje para tu vehiculo de transporte es : 15$ ");
            }
            else 
            {
                Console.WriteLine("Lo siento no se cuanto es el peaje de es vehiculo o si existe ");
            }
            
        }
    }
}
