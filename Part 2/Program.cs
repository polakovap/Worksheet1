/* Name: Petra Poláková
 * Date: 31/01/2023
 * Description: practicing the knowledge of methods and loops from semester 1
 */
namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("The hours used (-999 to exit): ");
            int hours = int.Parse(Console.ReadLine());
            double total = 0;

            while (hours != -999)
            {
                Console.WriteLine($"Charge: {CalculateCharge(hours):c}");
                
                total += CalculateCharge(hours); //total += hours is the same as total = total + hours

                Console.WriteLine($"Total charges: {total:c}");

                Console.Write("The hours used (-999 to exit): ");
                hours = int.Parse(Console.ReadLine());
            }
        }
        static double CalculateCharge (int numOfHours) //method to calculate the charges for the user
        {
            double charge = 0;
            if (numOfHours<=3)
            {
                charge = 2;
            }
            else
            {
                charge = 2 + (numOfHours - 3) * 0.5;
            }
            if (charge >= 10)
            {
                charge = 10;
            }
            return charge;
        }
    }
}