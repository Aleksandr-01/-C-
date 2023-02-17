// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

Console.Clear();

int [] RandomArray(int n)
{   
    int [] array = new int [n];
        for(int i = 0; i < n; i++)
    {
        array [i] = new Random().Next(1000);
    }
    return array;
}

int [] arr1 = RandomArray(123);

int FindNum(int[] arr)
{
int find = 0;
foreach(int x in arr)
{
    find += x > 9 && x <100 ? 1 : 0;
}

return find;
}

Console.Write($"[{String.Join(", ", arr1)}]");
Console.Write ($" -> {FindNum (arr1)}");