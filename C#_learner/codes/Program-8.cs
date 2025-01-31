//Of 5 numbers, how many are even or odd?//
//***************************************//

using System;
namespace _5Numbers_CheckEvenOdd
{
    internal class Program
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

            int evenCount = CountEvenNumbers(numbers);
            int oddCount = CountOddNumbers(numbers);

            Console.WriteLine($"Among the given numbers, {evenCount} {(evenCount == 1 ? "is" : "are")} even, and {oddCount} {(oddCount == 1 ? "is" : "are")} odd.");
        }

        static int CountEvenNumbers(int[] numbers)
        {
            int count = 0;

            foreach (int number in numbers)
            {
                if (IsEven(number))
                {
                    count++;
                }
            }

            return count;
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

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}

