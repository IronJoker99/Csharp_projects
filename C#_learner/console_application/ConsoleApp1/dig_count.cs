
// //digit count 

// using System;
// using System.Collections.Generic;
// namespace AllDigitCount
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("enter the number: ");
//             int number = int.Parse(Console.ReadLine());

//             Dictionary<int, int> digitcount = countdigits(number);
//             //countdigits(number);
//             //Console.Write(digitcount);
//             Console.WriteLine("the counted values");
//             foreach(var entry in digitcount)
//             {
//                 Console.WriteLine("{0} is present {1} times",entry.Key,entry.Value);
//             }

//         }
//         static Dictionary<int, int> countdigits(int num)
//         {
//             Dictionary<int, int> digitcount = new Dictionary<int, int>();
//             string numstr = Math.Abs(num).ToString();
//             //Console.WriteLine(numstr);

//             foreach (char digitchar in numstr)
//             {
//                 int digit = int.Parse(digitchar.ToString());

//                 if(digitcount.ContainsKey(digit))
//                 {
//                     digitcount[digit]++;
//                 }
//                 else
//                 {
//                     digitcount[digit] = 1;
//                 }
//             }
//             return digitcount;
//         }
    
//     }
// }