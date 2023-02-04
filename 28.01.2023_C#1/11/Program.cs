Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число {num}");
int num1 = num / 100;
int num2 = num % 10;
//int num3 = (num % 100) / 10;
Console.WriteLine($"{num1}{num2}");