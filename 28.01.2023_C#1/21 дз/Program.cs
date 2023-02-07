//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите X точки A: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y точки A: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Введите Z точки A: ");
double Z1 = double.Parse(Console.ReadLine());
Console.Write("Введите X точки B: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y точки B: ");
double Y2 = double.Parse(Console.ReadLine());
Console.Write("Введите Z точки B: ");
double Z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) +  Math.Pow(Z1 - Z2, 2));
Console.WriteLine($"Длина отрезка = {d:f2}");