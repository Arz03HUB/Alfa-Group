namespace Ejercicio_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 3 notas");
            int nota1 = int.Parse(Console.ReadLine());
            int nota2 = int.Parse(Console.ReadLine());
            int nota3 = int.Parse(Console.ReadLine());

            int suma = nota1 + nota2 + nota3;
            double promedio = suma / 3.0;
            Console.WriteLine("El promedio de tus notas es: " + promedio);
        }
    }
}
