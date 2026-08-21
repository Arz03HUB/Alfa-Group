namespace Ejercicio_30
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un color del semaforo ");
            string color = Console.ReadLine();
           
            if (color == "rojo")
            {
                Console.WriteLine("Deterse");
            }
            else if (color == "amarillo")
            {
                Console.WriteLine("Precaucion");
            }
            else if (color == "verde")
            {
                Console.WriteLine("Avazar");
            }
            else
            {
                Console.WriteLine("Color no valido");
            }
            
        }
    }
}

