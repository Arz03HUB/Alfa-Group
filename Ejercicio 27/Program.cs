namespace Ejercicio_27
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu estatura ");
            double estatura = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresa tu peso ");
            double peso = double.Parse(Console.ReadLine());
            double IMC = (peso / (estatura * estatura))*10000;

            if (IMC < 18.5)
            {
                Console.WriteLine("Bajo peso ");
            }
            else if ((IMC >= 18.5) && (IMC <= 24.9))
            {
                Console.WriteLine("Normal");
            }
            else if ((IMC >= 25) && (IMC <= 29.9))
            {
                Console.WriteLine("Sobre peso");
            }
            else if (IMC >30)
            {
                Console.WriteLine("obesidad ");
            }
            else
            {
                Console.WriteLine("no existes o fallesiste ");
            }
        }
    }
}
