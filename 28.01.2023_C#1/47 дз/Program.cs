// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Задайте количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] GetArray = new double[m, n];
FillArray(GetArray);
PrintArray(GetArray);

void PrintArray(double[,] array)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            Console.Write($"{array[i, j]} ");
        }
            Console.WriteLine();
    }
}

void FillArray(double[,] array)
{ 
    for (int i = 0; i < m; i++)
    { 
    for (int j = 0; j < n; j++)
        { 
           array[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
}