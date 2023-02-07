//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// Вариант 1 без проверки на длинну строки
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

//Вариант 2 пятизначного числа с проверкой на длинну строки
// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//  if (number[0]==number[4] & number[1]==number[3])
//  {
//    Console.WriteLine($"{number} - Это число палиндром");
//  }
//  else Console.WriteLine($"{number} - Это число не палиндром");
// }
// if (number!.Length == 5)
// {
//  CheckingNumber(number);
// }
// else
// {
//    Console.WriteLine($"Введено не пятизначное число");
// }