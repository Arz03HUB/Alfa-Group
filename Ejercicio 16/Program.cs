using System.Net.NetworkInformation;

namespace Ejercicio_16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa la contraseña correcta ");
            int contraseña = int.Parse(Console.ReadLine()); 
            int correcta = 1234;
            if (contraseña == correcta)
            {
                Console.WriteLine("Acceso permitido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
         }  }
    }
}
