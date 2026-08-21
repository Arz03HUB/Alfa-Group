using System.ComponentModel.Design;

namespace ejercicio_3
{
    public class Edad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año de su nacimiento ");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero del mes que nacio ");
            int mes = int.Parse(Console.ReadLine());
            
            if (mes > 8)
            {
                int edad = (2025 - anio);
                Console.WriteLine("Su edad es " + edad);
            }
            else
             {
                int edad = 2026 - anio; 
                Console.WriteLine("Su edad es " + edad);
            }
            
        }
    }
}
