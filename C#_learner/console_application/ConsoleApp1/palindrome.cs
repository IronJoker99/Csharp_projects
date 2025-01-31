// using System;

// namespace Inpalindrome
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("enter the number");
//             int number = int.Parse(Console.ReadLine());

//             if (IsPalindrome(number))
//             {
//                 Console.Write($"{number} is palindrome");
//             }
//             else
//             {
//                 Console.Write($"{number} is not palindrome");
//             }
//         }
//         static bool IsPalindrome(int num)
//         {
//             string Numstring = num.ToString();
//             int Left = 0;
//             int Right = Numstring.Length - 1;

//             while (Left < Right)
//             {
//                 if (Numstring[Left] != Numstring[Right])
//                     return false;
//                 Left++;
//                 Right--;
//             }
//             return true;

//         }
//     }
// }