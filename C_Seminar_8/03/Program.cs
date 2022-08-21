/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных. Пул чисел от 0 до 10.

1 2 3
4 6 1
2 1 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

int[,] array = 
{
    {1,2,3},
    {4,6,1},
    {2,1,6}
};
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
Console.WriteLine("\nЗадан следующий массив: ");
PrintArray(array);

int[] numbers = new int[10]; // записано 10 на случай рандомного массива с пулом чисел 0 - 10.
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        numbers[array[i,j]] ++;
    }
}

for (int i = 0; i < numbers.GetLength(0); i++)
{
    if (numbers[i] != 0) Console.WriteLine("Элемент " + i + " встречается " + numbers[i] + " раз.");
}