/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
Console.Write("Введите длину массива: ");
int count = int.Parse(Console.ReadLine());
int[] arr = GetArray(count);
Console.WriteLine("Изначальный массив: [{0}", String.Join(", ", arr) + "]");

Console.Write("Введите искомое число: ");
int res = int.Parse(Console.ReadLine());

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

bool Contains(int[] array, int n)
{
    for (int i = 0; array.Length > i; i++)
    {
        if (array[i] == n)
        {
            return true;
        }

    }
    return false;
}

if (Contains(arr, res) == true)
{
   Console.WriteLine("Указанное число " + res + " есть в массиве."); 
}
if (Contains(arr, res) == false)
{
   Console.WriteLine("Указанноого числа " + res + " нет в массиве."); 
}

/*
for (int i = 0; arr.Length > i; i++)
{
    if (arr[i] == res)
    {
        Console.WriteLine("Указанное число " + res + " есть в массиве.");
        return;
    }
}
Console.WriteLine("Указанноого числа " + res + " нет в массиве.");
*/