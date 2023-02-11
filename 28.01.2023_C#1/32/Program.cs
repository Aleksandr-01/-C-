// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();
Console.WriteLine("Please enter the number "); 
int number = int.Parse(Console.ReadLine());

int[] Create(int N){
    int[] A = new int[N];
    for (int i=0; i<N; i++) {
        Console.WriteLine($"Please enter the {(i+1)} element of array");
        A[i] = int.Parse(Console.ReadLine());
        }
    return A;
}
int[] array = Create(number);
Console.Write($"[{String.Join(", ", array)}]");

// const N = 10;
// var
//     arr: array[1..N] of integer;
//     i: byte;
// begin
//     randomize;
//     for i:=1 to N do begin
//         arr[i] := random(100) - 50;
//         write(arr[i]:4);
//     end;
//     writeln;
//     for i:=1 to N do 
//         arr[i] := -1 * arr[i];
//     for i:=1 to N do 
//         write(arr[i]:4);
//     writeln;
// end.
