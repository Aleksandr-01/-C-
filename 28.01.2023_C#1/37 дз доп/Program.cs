// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

Console.Clear();
int [] RandomArray(int n)
{   
    int [] array = new int [n];
        for(int i = 0; i < n; i++)
    {
        array [i] = new Random().Next(1, 11);
    }
    return array;
}
int [] arr1 = RandomArray(7);

int [] SumNum(int [] array)
{   int size = (array.Length + 1)/ 2;
    int [] result = new int [size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result [i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];

    return result;
}

int [] arr2 = SumNum(arr1);

Console.Write($"[{String.Join(", ", arr1)}]");
Console.Write($" -> [{String.Join(", ", arr2)}]");