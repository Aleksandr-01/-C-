// Задача 59
// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен первый найденный наименьший элемент.

Console.Clear();
int[,,] tripleArray = {{{101, 102, 103},{111, 112, 113},{121, 122, 123}},
{{201, 202, 203},{211, 212, 213},{221, 222, 223}},
{{201, 202, 203},{211, 212, 213},{221, 222, 223}}};

void removal(int[,,] array){
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);

    for (int i=0; i<x; i++)
    {
        for (int j=0; j<y; j++)
        {
            for (int k=0; k<z; k++)
            {
                Console.Write($"{array[i,j,k]}({i} {j} {k})");
            }
            Console.WriteLine();
        }
         Console.WriteLine();
    }
}
removal(tripleArray);