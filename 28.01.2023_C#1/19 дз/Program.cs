//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
int Length = number.Length;
string txt = number.Replace(" ","");
bool Pal()
{
  for (int i = 0; i < Length / 2; i++)
      if (number[i] != number[Length - 1 - i])
      {
       return false;
      }
    return true;
}
if (Pal())
{
  Console.WriteLine($"{number} - Это число палиндром");
}
else
{
   Console.WriteLine($"{number} - Это число не палиндром");
}