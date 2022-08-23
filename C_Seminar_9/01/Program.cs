/*
Задача 63: Решить с помощью рекурсии. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

/*
for (int i = 1; i <= n; i++)
{
    Console.Write(i + ", ");
}
*/

void NaturalNum(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write(start + ", ");
    start++;
    NaturalNum(start, end);
}
NaturalNum(1, n);