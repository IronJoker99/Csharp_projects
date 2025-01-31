//Digit Count in the given Number
//*******************************

using System;
using System.Collections.Generic;
namespace AllDigitsCount
{

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Dictionary<int, int> digitCount = CountDigits(number);

            Console.WriteLine("Digit Counts:");
            foreach (var entry in digitCount)
            {
                Console.WriteLine("{0} is present: {1} times.", entry.Key,entry.Value);
            }
        }

        static Dictionary<int, int> CountDigits(int num)
        {
            Dictionary<int, int> digitCount = new Dictionary<int, int>();
            string numStr = Math.Abs(num).ToString();

            foreach (char digitChar in numStr)
            {
                int digit = int.Parse(digitChar.ToString());

                if (digitCount.ContainsKey(digit))
                {
                    digitCount[digit]++;
                }
                else
                {
                    digitCount[digit] = 1;
                }
            }
            return digitCount;
        }
    }
}
