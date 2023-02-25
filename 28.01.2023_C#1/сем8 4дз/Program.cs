// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// массив размером 2 x 2 x 2
// int[,,]
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
int[,,] decimalArrays = new int[,,]{ { { 12, 22 }, { 23, 36 } }, { { 45, 53 }, { 61, 73 } } };
for(int i = 0; i<decimalArrays.GetLength(0); i++){
   for(int j = 0; j < decimalArrays.GetLength(1); j++){
      Console.Write("\n");
      for(int k = 0; k< decimalArrays.GetLength(2); k++){
         Console.Write($"{decimalArrays[i,j,k]}({i},{j},{k}) " );
      }
   }
}   
           

// using System;
// using static System.Console;

// Clear();

// Write("Введите показатель 1: ");
// int A = int.Parse(ReadLine()); // Convert.ToInt32(Console.ReadLine());
// Write("Введите показатель 2: "); 
// int B = int.Parse(ReadLine()); 
// Write("Введите показатель 3: "); 
// int C = int.Parse(ReadLine()); 
// int[,,] array = RandomArray(A, B, C); 
// Show3dArray(array); 

// int[,,] RandomArray( int field, int rows, int columns) 
// { 
//     int[,,] newArray = new int[field, rows, columns]; 
//     for(int i = 0; i < field; i++)
//     { 
//         for(int j = 0; j < rows; j++)
//      { 
//         for(int k = 0; k < columns; k++) 
//         { 
//             newArray[i,j,k] = i + j + k; 
//         } 
//      } 
//     } 
//     return newArray; 
// } 
// void Show3dArray(int[,,] array)
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for(int j = 0; j < array.GetLength(1); j++) 
//         { 
//             for(int k = 0; k < array.GetLength(2); k++) 
//             { 
//                 Console.Write("[" + i + "," + j + "]" + array[i, j, k] + " "); 
//             } 
//             Console.WriteLine(); 
//         } 
//         Console.WriteLine(); 
//     } 
//     Console.WriteLine(); 
// }