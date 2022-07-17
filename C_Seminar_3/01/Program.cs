/*
Дана длина массива. 
Нужно заполнить его случайными числами. 
Дано некоторое число. 
Нужно найти индекс этого числа.
*/
Console.Write("Number to find: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[20];

FillArrayWithRandomNums(array);
Console.Write("Array: ");

PrintArray(array);
int index = Find(array, num);
Console.WriteLine("Otvet index = " + index);


void FillArrayWithRandomNums(int[] array) // Метод для заполнения массива рандомными цифрами
{
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 10);
        i++;
    }
}

void PrintArray(int[] array) // Метод для вывода всего массива
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}

int Find(int[] array, int number) // Метод для поиска индекса заданного цисла из массива
{
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] == number)
        return i;
        i++;
    }
    return -1;
}