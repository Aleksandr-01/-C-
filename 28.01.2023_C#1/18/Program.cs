// Задача 18
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int n = int.Parse(Console.ReadLine());
while((n<1) || (n>4))
{
    Console.WriteLine("Введено не верное число четверти, повторите ввод:");
    n = int.Parse(Console.ReadLine());
}
if(n == 1){
    Console.WriteLine("Точка находится на X>0 и Y>0");
}else if(n == 2){
    Console.WriteLine("Точка находится на X<0 и Y>0");
}else if(n == 3){
    Console.WriteLine("Точка находится на X<0 и Y<0");
}else if(n == 4){
    Console.WriteLine("Точка находится на X>0 и Y<0");
}