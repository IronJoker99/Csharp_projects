using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool opt = IsPalindrome(number);

            if (opt == false)
            {
                int removedDigit = FindDigitToRemoveForPalindrome(number);

                if (removedDigit != -1)
                {
                    Console.WriteLine($"To make the number a palindrome, remove digit: {removedDigit}");
                }
                else
                {
                    Console.WriteLine("The number is already a palindrome or cannot become a palindrome by removing a single digit.");
                }
            }
            else
            {
                Console.WriteLine("number is a palindrome number");
            }
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

    static int FindDigitToRemoveForPalindrome(int number)
    {
        string numberString = number.ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            int candidate = int.Parse(numberString.Remove(i, 1));

            if (IsPalindrome(candidate))
            {
                return int.Parse(numberString[i].ToString());
            }
        }
        return -1;
    }
}
