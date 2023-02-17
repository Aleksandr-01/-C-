// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int [] GetRandomArray(int a)
{   
    int [] array = new int [a];
        for(int i = 0; i < a; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
    return array;
}

int [] arr1 = GetRandomArray(4);

int SumEvenNum(int[] array)
{
    int SumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            SumEven++;
    }
    return SumEven;
}

Console.Write($"[{String.Join(", ", arr1)}]");
Console.Write ($" -> {SumEvenNum (arr1)}");