Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
  Console.WriteLine("Нет такого дня недели");
    return;

}
if (numberDayOfWeek == 1)
{
  Console.WriteLine("Это Понедельник");
}
if (numberDayOfWeek == 2)
{
  Console.WriteLine("Это Вторник");
}
if (numberDayOfWeek == 3)
{
  Console.WriteLine("Это Среда");
}
if (numberDayOfWeek == 4)
{
  Console.WriteLine("Это Четверг");
}
if (numberDayOfWeek == 5)
{
  Console.WriteLine("Это Пятница");
}
if (numberDayOfWeek == 6)
{
  Console.WriteLine("Это Суббота");
}
if (numberDayOfWeek == 7)
{
  Console.WriteLine("Это Воскресенье");
}