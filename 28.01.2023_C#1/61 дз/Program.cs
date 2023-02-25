// Задача 61
// Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

Console.Clear();
int i, n, c;
Console.WriteLine("Введите количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);

float factorial(int n){
   float x = 1;
   for (int i = 1; i <= n; i++) x *= i;
   return x;
}

for (i = 0; i < n; i++){
   for (c = 0; c <= (n - i); c++)
      Console.Write(" "); 
   for (c = 0; c <= i; c++){
      Console.Write(" ");
      Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); 
   }
   Console.WriteLine(); 
}