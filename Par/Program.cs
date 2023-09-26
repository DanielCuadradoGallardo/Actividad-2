namespace Par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 50;

            for(int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}