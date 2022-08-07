/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
int[] getArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

int[] array = getArray(12);
int sumLess = 0;
int sumGreater = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumGreater = sumGreater + array[i];
    }
    else
    {
        sumLess = sumLess + array[i];
    }
}
Console.WriteLine("Получился массив: [{0}", String.Join(", ", array) + "]");
Console.WriteLine("Сумма положительных чисел: " + sumGreater);
Console.WriteLine("Сумма отрицательных чисел: " + sumLess);