//7 и 23 число одновременно кратно
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) 
{
    Console.WriteLine("да");
}
else
    Console.WriteLine("нет");