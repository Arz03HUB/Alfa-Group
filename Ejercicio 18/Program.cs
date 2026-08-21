namespace Ejercicio_18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa el precio de tu producto para saber si tienes descuento ");
            double precio = double.Parse(Console.ReadLine());
            double descuento = (precio *0.10);
            double total = (precio - descuento);
            if (precio >= 100)
            {
                Console.WriteLine("Felicidades tienes descuento y solo pagaras " + total + " Bs ");
            }
            else
            {
                Console.WriteLine("pagas el precio normal de " + precio + " Bs ");
            }   }
    }
}
