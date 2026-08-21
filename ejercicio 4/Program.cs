namespace ejercicio_4
{
    public class IVA
    {
        static void Main(string[] args)
        {
            double iva = 0.13;
            Console.WriteLine("Ingrese el precio del producto"); 
            double precio = double.Parse(Console.ReadLine());
            double impuesto = precio * iva;
            double total = precio + impuesto;
            Console.WriteLine("El impuesto a pagar es: " + impuesto);
            Console.WriteLine("El total es: " + total);
        }
    }
}
