// using System;
// using System.Collections;
// class List 
// {
//     ArrayList array = new ArrayList();
//     public object this[int index]
//     {
//         get
//         {
//             if(index < 0 || index >= array.Count)
//             {
//                 return null;

//             }
//             else
//             {
//                 return (array[index]);
//             }
//         }
//         set
//         {
//             array[index] = value;
//         }
//     }


// }
// class IndexerTest
// {
//     public static void Main()
//     {
//         List list = new List();
//         list[0] = "123";
//         list[1] = "abc";
//         list[2] = "xyz";
//         for(int i = 0; i < 3; i++)
//         {
//             Console.WriteLine(list[i]);
//         }

//     }
// }