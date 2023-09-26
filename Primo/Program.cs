using System.Globalization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximo = 0;
            int i = 1;
            while(maximo != 5){
                int cont = 0;
                if (i == 1)
                {
                    if (maximo != 5)
                    {
                        Console.WriteLine(i);
                        maximo++;
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            cont++;
                        }
                    }
                    if (cont == 2)
                    {
                        if(maximo != 5){
                            Console.WriteLine(i);
                            maximo++;
                        }
                    }
                 }
                i++;
            }  
        }
    }
}