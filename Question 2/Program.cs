namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountOddNumbers();
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
                
                if (figuringOdd == 1)
                {
                    oddNumbers = oddNumbers + 1;
                }
            }
            Console.WriteLine($"{oddNumbers}");
            return 0;
        }
    }
}