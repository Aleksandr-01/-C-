// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] array = Create(num);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] Create (int n)
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
    }
