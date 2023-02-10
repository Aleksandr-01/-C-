// Напишите программу, которая принимает на вход число А
// и выдает сумму чисел от 1 до А
// a = 5
// sum = 1 + 2 + 3 + 4 + 5

Console.Clear();
Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine ($"Сумма чисел от 1 до {limit} равна {GetSum (limit)}");

int GetSum (int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
         sum += i;
    return sum;
}