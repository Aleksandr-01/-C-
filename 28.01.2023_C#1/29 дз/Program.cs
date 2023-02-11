// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int num = 8;
Console.Write("Мин элемент массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Макс элемент массива: ");
int y = int.Parse(Console.ReadLine());
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");

int[] GetBinArray(int size)
{   
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(x + 1, y);
    }
    return result;
    }
