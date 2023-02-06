Console.Clear();
Console.Write("Введите количество монеток: ");
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
for (int i = 0; i < n; i++){
    int b = int.Parse(Console.ReadLine());
    mas[i] = b;
}
int r = 0, g = 0;
for (int i = 0; i < n; i++)
{
    if(mas[i] == 0){
        g++;
    }else{
        r++;
    }
}
if (g > r){
    Console.Write($"Нужно сделать {r} переворотов");
}else{
    Console.Write($"Нужно сделать {g} переворотов");
}


//Вариант 2 
//более оптимальный
Console.Clear();
Console.Write("Введите количество монеток: ");
int n = int.Parse(Console.ReadLine());
int r = 0, g = 0;
for (int i = 0; i < n; i++){
    int b = int.Parse(Console.ReadLine());
    if (b == 0){
        g++;
    }
    else{
        r++;
    }
}
if (g > r){
    Console.Write($"Нужно сделать {r} переворотов");
}else{
    Console.Write($"Нужно сделать {g} переворотов");
}