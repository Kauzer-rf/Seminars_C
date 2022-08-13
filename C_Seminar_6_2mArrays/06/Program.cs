/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int[] res = new int[32]; // int 32 битный элемент, больше быть не может
int i = 0;

while (n > 0)
{
    res[i] = n % 2;
    n = n / 2;
    i++;
}
Console.Write("Результат: ");
for (int j = i - 1; j >= 0; j--)
{
    Console.Write(res[j]);
}
