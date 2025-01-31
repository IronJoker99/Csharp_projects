// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("enter the number to check for a palidrome");
//         if(int.TryParse(Console.ReadLine(), out int number))
//         {
//             bool opt = IsPalidrome(number);
//             if(opt == false)
//             {
//                 int Removedigit = RemovingtheDigitForNumber(number);
//                 if(Removedigit != -1)
//                 {
//                     Console.Write($"the given number can remove to be polidome : {Removedigit}");
//                 }
//                 else
//                 {
//                     Console.Write("the given number is a already a polidrome we not remove again");

//                 }
//             }
//             else
//             {
//                 Console.Write("the number is polidrome");
//             }
//         }
        
//     }
//     static bool IsPalidrome(int num)
//     {
//         string numstr = num.ToString();
//         int left = 0;
//         int right = numstr.Length -1;
//         while(left < right)
//         {
//             if(numstr[left] != numstr[right])
//             {
//                 return false;
//             }
//             left++;
//             right--;

//         }
//         return true;

//     }

//     static int RemovingtheDigitForNumber(int num1)
//     {
//         string numstring = num1.ToString();

//         for(int i = 0; i < numstring.Length; i++)
//         {
//             int candidate = int.Parse(numstring.Remove(i,1));

//             if(IsPalidrome(candidate))
//             {
//                 return int.Parse(numstring[i].ToString());
//             }
//         }
//         return -1;

//     }
// }