// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
int n = POW(a, b);
Console.WriteLine($"Число A в степени B = {n}");

int POW (int x, int y)
{
    int pow = 1;
    for(int i = 1; i <= y; i++)
        {
        pow *= x;
        }
    return pow;
}
