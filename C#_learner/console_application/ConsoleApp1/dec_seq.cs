// //decreasing sequence


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the number of elements in the array: ");
//         if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//         {
//             int[] array = new int[n];

//             Console.WriteLine("Enter the elements of the array:");

//             for (int i = 0; i < n; i++)
//             {
//                 Console.Write($"Element {i + 1}: ");
//                 if (!int.TryParse(Console.ReadLine(), out array[i]))
//                 {
//                     Console.WriteLine("Invalid input. Please enter valid integers.");
//                     return;
//                 }
//             }

//             int numberOfDecreasingSequences, longestDecreasingSequenceLength;
//             FindDecreasingSequences(array, out numberOfDecreasingSequences, out longestDecreasingSequenceLength);

//             Console.WriteLine($"Number of decreasing sequences: {numberOfDecreasingSequences}");
//             Console.WriteLine($"Length of the longest decreasing sequence: {longestDecreasingSequenceLength}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid positive integer for the number of elements.");
//         }
//     }

//     static void FindDecreasingSequences(int[] array, out int numberOfSequences, out int longestSequenceLength)
//     {
//         numberOfSequences = 0;
//         longestSequenceLength = 0;

//         int currentSequenceLength = 1;

//         for (int i = 1; i < array.Length; i++)
//         {
//             if (array[i] < array[i - 1])
//             {
//                 currentSequenceLength++;
//             }
//             else
//             {
//                 if (currentSequenceLength > 1)
//                 {
//                     numberOfSequences++;
//                     longestSequenceLength = Math.Max(longestSequenceLength, currentSequenceLength);
//                 }

//                 currentSequenceLength = 1;
//             }
//         }

//         // Check the last sequence
//         if (currentSequenceLength > 1)
//         {
//             numberOfSequences++;
//             longestSequenceLength = Math.Max(longestSequenceLength, currentSequenceLength);
//         }
//     }
// }