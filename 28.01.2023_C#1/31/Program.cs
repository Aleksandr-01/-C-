//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();
int num = new Random().Next(-9, 9);
int num = int.Parse(Console.ReadLine());
int[] array = GetBinArray(num);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }

    return result;
}

Console.Clear();

int[] GetRandomArray(int size,int minValue,int maxValue){  
      int[] result = new int[size];
    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue,maxValue+1);
    return result;
    }
int [] A = GetRandomArray(12, -9, 10);
Console.WriteLine($"[{String.Join(", ", A)}]");
int neg=0, pos=0;
for (int i=0; i<12; i++) {
    if (A[i]<0) 
        neg+=1;
    else if (A[i]>0) 
        pos+=1;
    }
Console.WriteLine($"+: {pos}");
Console.WriteLine($"-: {neg}");