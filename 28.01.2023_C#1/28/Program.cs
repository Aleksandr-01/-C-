// Задача 28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine ($"Произведение чисел = {GetMyltiply (n)}");

int GetMyltiply (int n)
{
    int result = 1;
    for (int i =2; i <= n; i++)
        result *= i;
    return result;
}