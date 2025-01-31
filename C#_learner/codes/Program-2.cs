//Check whether the number is odd//
//********************************//

using System;
namespace Is_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (IsOdd(number))
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
                else
                {
                    Console.WriteLine("{0} is an even number.", number);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }

}
