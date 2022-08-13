/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] array = { 1, 2, 3, 4, 5, 6 };
System.Console.WriteLine("Исходный массив: { 1, 2, 3, 4, 5, 6 }");
int[] copyArray = GetCopy(array);
System.Console.WriteLine("Копия исходного массива: [ {0} ", String.Join(", ", GetCopy(array)) + " ]");

int[] GetCopy(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

