namespace Ejercicio_24
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa una edad ");
            int num1 = int.Parse(Console.ReadLine());
            if ((num1 >= 0) && (num1 <= 12))
            {
                Console.WriteLine("Eres un niñato aun ");
            }
            else if ((num1 >= 13) && (num1 <= 17))
            {
                Console.WriteLine("Adolecente la edad de burro ");
            }
            else if ((num1 >= 18) && (num1 <= 64))
            {
                Console.WriteLine("Adulto eres un miembro funcional de la sociedad");
            }
            else if ((num1 >= 65) && (num1 <= 100))
            {
                Console.WriteLine("Adulto mayor a un paso de la tumba ");
            }
            else
            {
                Console.WriteLine("Ya no existes");
            }
        }
    }
}
