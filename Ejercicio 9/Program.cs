namespace Ejercicio_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa los minutos que quieras convertir a segundos y horas");
            int minutos = int.Parse(Console.ReadLine());
            int segundos = (minutos * 60);
            double horas = (minutos / 60);
            Console.WriteLine(minutos + " Minutos son " + segundos + " Segundos y " + horas + " Horas");
        }
    }
}
