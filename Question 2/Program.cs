/* Name: Petra Poláková
 * Date: 30/01/2023
 * Description: practicing the knowledge of methods and loops from semester 1
 */
namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call out the methods
            CountOddNumbers();
            AvarageMinMax();
        }
        static int CountOddNumbers()
        {
            int[] numbers = new int[5];
            int oddNumbers = 0;

            //read in the numbers
            for (int i=0; i < 5; i++)
            {
                Console.Write($"{"Enter number"} {(i + 1)}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                int figuringOdd = numbers[i]%2; 
                
                //calculate the amount of odd numbers
                if (figuringOdd == 1) 
                {
                    oddNumbers = oddNumbers + 1;
                }
            }
            
            //display the result
            Console.WriteLine($"{oddNumbers}");
            return 0;
        }
        static int AvarageMinMax()
        {
            int[] numbers = new int[5];
            
            //read in the numbers
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{"Enter number"} {(i + 1)}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

           //find the average, smallest and largest number
            int average = (int)numbers.Average();
            int smallest = numbers.Min();
            int largest = numbers.Max();

            //Display the results
            Console.WriteLine($"The average of these numbers is {average}\nThe smallest number is {smallest}\nThe largest number is {largest}");
            return 0;
        }
    }
}