// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант 1 
// Console.Clear();
// Console.Write("Введите число до четырехзначного: ");
// int num = int.Parse(Console.ReadLine());
// int n1 = num / 1000;
// int n2 = num / 100 - n1 * 10;
// int n3 = (num % 100) / 10;
// int n4 = num % 10;
// int s = n1  + n2 + n3 + n4;
// Console.WriteLine($"Сумма цифр в числе = {s}");

//Вариант 2
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int num){
    
    int counter = Convert.ToString(num).Length;
    int a = 0;
    int b = 0;

    for (int i = 0; i < counter; i++)
    {
      a = num - num % 10;
      b = b + (num - a);
      num = num / 10;
    }
   return b;
  }

int s = SumNumber(num);
Console.WriteLine($"Сумма цифр в числе = {s}");

