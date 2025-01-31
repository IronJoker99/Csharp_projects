// using System;
// namespace Is_odd
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("enrter the number: ");
//             string input = Console.ReadLine();

//             if(int.TryParse(input, out int number))
//             {
//                 if(Isodd(number))
//                 {
//                     Console.WriteLine($"{number} is odd");
//                 }
//                 else
//                 {
//                     Console.Write("{0} is even", number);
//                 }
//             }
//             else
//             {
//                 Console.Write("the input value is invalid");
//             }
//         }
//         static bool Isodd(int num)
//         {
//             return num % 2 != 0;
//         }
//     }
// }


