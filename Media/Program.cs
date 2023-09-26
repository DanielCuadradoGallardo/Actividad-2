using System.Numerics;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce numero: ");
            int numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce numero: ");
            int numero4 = int.Parse(Console.ReadLine());

            double media = (double)(numero1 + numero2 + numero3 + numero4) / 4;

            Console.WriteLine("La media es: " + media);
        }
    }
}