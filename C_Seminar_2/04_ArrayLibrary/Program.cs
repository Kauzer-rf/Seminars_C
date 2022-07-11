/* Учучшенный синтаксис 03 задачи
*/
// void - метод который ничего не возвращает
void FillArray(int[] col1)
{
    int length = col1.Length;
    int index = 0;
    while (index < length)
    {
        col1[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col2)
{
    int lenght2 = col2.Length;
    int index2 = 0;
    while (index2 < lenght2)
    {
        Console.WriteLine(col2[index2]);
        index2++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
