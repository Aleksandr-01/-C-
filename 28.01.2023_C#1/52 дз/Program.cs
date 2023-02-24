// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Задайте число строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте число элементов массива");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray (m, n);

int[,] GetArray (int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray2(int [,] arr)
{   Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i, j];
    }
       Console.Write($"{sum/arr.GetLength(0):f1} ");
    }
}

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray2(array);