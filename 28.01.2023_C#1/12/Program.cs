Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
if (0 == num1 % num2)
{
    Console.WriteLine($"{num1}, {num2} -> Кратно, остатка нет");
}
else
{
    Console.WriteLine($"{num1}, {num2} -> Не кратно, остаток от деления {num1 % num2}");
}