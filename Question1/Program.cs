namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersFor();
            PrintIntegersWhile();
            PrintIntegersDo();
            PrintExcludingFor();
        }

        static int PrintIntegersFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine($"{i}"); ;
            }
            return 0;
        }
        static int PrintIntegersWhile()
        {
            int i = 40;
            while (i <= 60)
            {
                Console.WriteLine($"{i}");
                i++;
            }
            return 0;
        }
        static int PrintIntegersDo()
        {
            int i = 40;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            }
            while (i <= 60);
            return 0;
        }
        static int PrintExcludingFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                if (i != 46 && i != 48)
                {
                    Console.WriteLine($"{i}");
                }
            }
            return 0;
        }
    }
}