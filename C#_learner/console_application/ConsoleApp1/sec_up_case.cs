// using System;

// namespace Sentence_upper_case
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("enter the sentence");
//             string input = Console.ReadLine();

//             string  secondWordUpperCase = GetsecondWordUpperCase(input);

//             Console.Write($"the secons word upper case is : {secondWordUpperCase}");
//         }
//         static string GetsecondWordUpperCase(string input1)
//         {
//             string[] words = input1.Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

//             //check thre is a second word
//             if (words.Length >= 2)
//             {
//                 return words[1].ToUpper();
//             }
//             else{
//                 return "no second word found";
//             }


//         }
//     }
// }

