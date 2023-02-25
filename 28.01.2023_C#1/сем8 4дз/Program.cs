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