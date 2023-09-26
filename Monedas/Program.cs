namespace Monedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int precio = 45;

            float introducido = float.Parse(Console.ReadLine());
            double vuelta = introducido - 0.45f;

            int monedas2e = 0;
            int monedas1e = 0;
            int monedas50c = 0;
            int monedas20c = 0;
            int monedas10c = 0;
            int monedas5c = 0;

            while (vuelta > 0)
            {
                if (vuelta >= 2)
                {
                    vuelta -= 2;
                    vuelta = Math.Round(vuelta, 2);
                    monedas2e++;

                }
                else if (vuelta >= 1)
                {
                    vuelta -= 1;
                    vuelta = Math.Round(vuelta, 2);
                    monedas1e++;
                }
                else if (vuelta >= 0.50d)
                {
                    vuelta -= 0.5d;
                    vuelta = Math.Round(vuelta, 2);
                    monedas50c++;
                }
                else if (vuelta >= 0.20d)
                {
                    vuelta -= 0.2d;
                    vuelta = Math.Round(vuelta, 2);
                    monedas20c++;
                }
                else if (vuelta >= 0.10d)
                {
                    vuelta -= 0.1d;
                    vuelta = Math.Round(vuelta, 2);
                    monedas10c++;
                }
                else if(vuelta < 0.10d)
                {
                    vuelta -= 0.05d;
                    vuelta = Math.Round(vuelta, 2);
                    monedas5c++;
                }
            }
            Console.WriteLine("Tu cambio es: ");
            if(monedas2e != 0)
            {
                Console.WriteLine(monedas2e + " moneda/s de 2 euro");
            }
            if (monedas1e != 0)
            {
                Console.WriteLine(monedas1e + " moneda/s de 1 euro");
            }
            if (monedas50c != 0)
            {
                Console.WriteLine(monedas50c + " moneda/s de 50 cents");
            }
            if (monedas20c != 0)
            {
                Console.WriteLine(monedas20c + " moneda/s de 20 cents");
            }
            if (monedas10c != 0)
            {
                Console.WriteLine(monedas10c + " moneda/s de 10 cents");
            }
            if (monedas5c != 0)
            {
                Console.WriteLine(monedas5c + " moneda/s de 5 cents");
            }
        }
    }
}