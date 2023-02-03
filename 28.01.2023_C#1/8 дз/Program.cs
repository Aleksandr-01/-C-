//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int b = 2;
while(b <= n){
    Console.Write($"{b} ");
    b = b + 2;
}