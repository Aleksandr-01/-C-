Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int b = -n;
while(b <= n){
    Console.Write($"{b} ");
    b++; // b=b+1;
}