// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int [,] FindElement (int[,] array)
{
    Console.WriteLine("Введите строку массива:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите номер элемента в строке");
    int n = int.Parse(Console.ReadLine());
    if (m > array.GetLength(0) || n > array.GetLength(1) || m <= 0 || n <= 0)
    {Console.WriteLine("Нет такого элемента");}
    else {Console.WriteLine($"Найденный элемент -> {array[m-1,n-1]}");}
    return array;
}

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindElement(array);