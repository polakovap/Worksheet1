/* Name: Petra Poláková
 * Date: 25/01/2023
 * Description: practicing the knowledge of methods and loops from semester 1
 */
namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call out the methods
            PrintIntegersFor();
            PrintIntegersWhile();
            PrintIntegersDo();
            PrintExcludingFor();
            PrintDescendingFor();
        }

        static int PrintIntegersFor() //a method which prints all the numbers between 40 and 60 using for loop
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine($"{i}"); ;
            }
            return 0;
        }
        static int PrintIntegersWhile() //a method which prints all the numbers between 40 and 60 using while loop
        {
            int i = 40;
            while (i <= 60)
            {
                Console.WriteLine($"{i}");
                i++;
            }
            return 0;
        }
        static int PrintIntegersDo() //a method which prints all the numbers between 40 and 60 using do while loop
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
        static int PrintExcludingFor() //a method which prints all the numbers between 40 and 60 except 46 and 48
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
        static int PrintDescendingFor() //a method which prints all the numbers between 40 and 60 from largest to smallest
        {
            for (int i = 60; i >= 40; i--)
            {
                Console.WriteLine($"{i}");
            }
            return 0;
        }
    }
}