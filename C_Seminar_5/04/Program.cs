/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int res = 0;
int len = 123;
int[] arr = GetArray(len);

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 1000);
    }
    return arr;
}

Console.WriteLine("Массив: [{0}", String.Join(", ", arr) + "]");

for (int i = 0; arr.Length > i; i++)
{
    if (arr[i] >= 10 && arr[i] <= 99)
    {
        res ++;
    }
}
Console.WriteLine();
Console.Write("Количество чисел от 10 до 99 в массиве: " + res);
