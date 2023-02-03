Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (b == a * a){
    Console.WriteLine("да");
}else{
    Console.WriteLine("нет");
}