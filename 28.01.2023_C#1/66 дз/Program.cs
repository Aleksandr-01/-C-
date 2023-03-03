// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());

int FindSum(int M, int N)
{
    if (M == N)
        return M;
    return (M + FindSum(M + 1, N));
}

Console.WriteLine($"{FindSum(M, N)}");