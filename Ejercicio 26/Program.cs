namespace Ejercicio_26
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un numero del 1 al 7 ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            { 
                Console.WriteLine("Lunes ");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Miercoles");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("Jueves ");
             }
            else if (num1 == 4)
             {
                Console.WriteLine("Viernes ");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("Sabado");
            }

            else if (num1 == 7)
            {
                Console.WriteLine("Domingo ");
            }
            else
            {
                Console.WriteLine("Ese dia no existe ");
            }
        }
    }
}
            

