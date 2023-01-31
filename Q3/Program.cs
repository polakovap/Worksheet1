/* Name: Petra Poláková
 * Date: 31/01/2023
 * Description: practicing the knowledge of methods and loops from semester 1
 */
namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call out the methods
            PrintTriangle();
            PrintTriangleUpsideDown();
            PrintTriangleGeneral();
            PrintTriangleGeneralCharacter();
        }
        static private void PrintTriangle() //method which prints a 5 row triangle with #
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine("");
            }
        }
        static private void PrintTriangleUpsideDown() //method which prints an upside down triangle with 5 rows
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("# ");
                }
                Console.WriteLine("");
            }
        }
        static private void PrintTriangleGeneral() //method which prints a triangle with a number of rows chose by the user
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine("");
            }
        }
        static private void PrintTriangleGeneralCharacter() //method which prints a triangle with a number of rows with characters which chose the user
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the character for the pattern: ");
            string character = Console.ReadLine();

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{character}");
                }
                Console.WriteLine("");
            }
        }
    }
}