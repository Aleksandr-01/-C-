//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
int b = 0;
if (b == a % 2){
    Console.WriteLine($"Число {a} является четным");
}else{
    Console.WriteLine($"Число {a} не является четным");
}