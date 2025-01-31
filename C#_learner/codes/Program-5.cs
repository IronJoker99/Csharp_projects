//Convert seconnd word to upper case
//**********************************

using System;
namespace SecondWordUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            string secondWordUpperCase = GetSecondWordUpperCase(input);

            Console.WriteLine($"Second word in uppercase: {secondWordUpperCase}");
        }

        static string GetSecondWordUpperCase(string input)
        {
            // Split the input string into words
            string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Check if there is a second word
            if (words.Length >= 2)
            {
                // Return the second word in uppercase 
                return words[1].ToUpper();
            }
            else
            {
                return "No second word found.";
            }
        }
    }
}
