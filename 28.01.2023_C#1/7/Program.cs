Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100 || number > 999)
{
  Console.WriteLine("Это не трехзначное число");
    return;
    }

int n = number % 10;
Console.WriteLine($"Последняя цифра трехзначного числа {n} ");