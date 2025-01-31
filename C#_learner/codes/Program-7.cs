//Of given 5 numbers, how many are odd?//
//*************************************//

using System;
namespace Numbers_CheckOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid integers.");
                    return;
                }
            }
            int oddCount = CountOddNumbers(numbers);
            Console.WriteLine("Among the given numbers, {0} numbers are odd", oddCount);
        }

        static int CountOddNumbers(int[] numbers)
        {
            int count = 0;

            foreach (int number in numbers)
            {
                if (IsOdd(number))
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}

