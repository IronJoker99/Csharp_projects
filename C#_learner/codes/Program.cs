//Check whether the number is palindrome
//**************************************

using System;
namespace IsPalindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }

        static bool IsPalindrome(int num)
        {
            // Convert the number to a string for easier comparison
            string numStr = num.ToString();

            int left = 0;
            int right = numStr.Length - 1;

            while (left < right)
            {
                if (numStr[left] != numStr[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
