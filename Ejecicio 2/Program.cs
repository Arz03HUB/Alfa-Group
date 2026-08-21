namespace Ejecicio_2
{
    public class Area
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;
            Console.WriteLine("Indresa el radio del círculo:");
            double radio = double.Parse(Console.ReadLine());
            double area = PI * radio * radio;
            Console.WriteLine("el radio del circulos es " + area);
            
        }
    }
}
