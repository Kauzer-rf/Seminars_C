/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для пользователя.

1 2 3 4    1 5 9 3
5 6 7 8 -> 2 6 0 4
9 0 1 2    3 7 1 5
3 4 5 6    4 8 2 6
*/
int[,] array =
{
  {1, 2, 3, 4},
  {5, 6, 7, 8},
  {9, 0, 1, 2},
  {3, 4, 5, 6},
};

Console.WriteLine("\nЗадан следующая матрица: ");
PrintArray(array);
if (array.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("\nОшибка. Задана не квадратная матрица!");
    return;
}
Transpose(array);
Console.WriteLine("\nИзмененная матрица: ");
PrintArray(Transpose(array));

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] Transpose(int[,] array)
{
    int[,] FixedArray = new int[array.GetLength(0), array.GetLongLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            FixedArray[i, j] = array[j, i];
        }
    }
    return FixedArray;
}