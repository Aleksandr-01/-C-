// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double [] RandomArray(int n)
{   
    double [] array = new double [n];
        for(int i =0; i<n; i++)
    {
        array [i] = new Random().Next(100);
    }
    return array;
}
double [] arr1 = RandomArray(5);

double FindDiff(double [] A)
{
    double max = A[0];
    double min = A[0];
    for (int i = 1; i<A.Length; i++)
    {
     if (A[i]> max) max = A[i];
     if (A[i]< min) min = A[i];
    }
    double diff = max - min;
    return diff;
}

Console.Write($"[{String.Join(", ", arr1)}]");
Console.Write ($" -> {FindDiff (arr1)}");