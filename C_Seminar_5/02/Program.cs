/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

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
Console.Write("Введите длину массива: ");
int count = int.Parse(Console.ReadLine());
int[] arr = GetArray(count);
Console.WriteLine("Изначальный массив: [{0}", String.Join(", ", arr) + "]");

for (int i = 0; i < arr.Length; i++)
{

    {
        arr[i] = arr[i] * (-1);
    }
}
Console.WriteLine("Перевернутый массив: [{0}", String.Join(", ", arr) + "]");