// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int [] RandomArray(int n)
{   
    int [] array = new int [n];
        for(int i = 0; i < n; i++)
    {
        array [i] = new Random().Next(-100, 100);
    }
    return array;
}
int [] arr1 = RandomArray(4);

int SumNum(int[] arr)
{ int num= 0;
    for (int i = 1; i< arr.Length; i+=2)
    {
        num = num + arr[i];
    }
return num;
}

Console.Write($"[{String.Join(", ", arr1)}]");
Console.Write ($" -> {SumNum (arr1)}");