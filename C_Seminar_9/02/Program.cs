/*
Задача 63+: Решить с помощью рекурсии. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 0.
N = 5 -> "5, 4, 3, 2, 1"
*/
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

void NaturalBack(int start)
{
    if (start == -1)
    {
        return;
    }
    Console.Write(start + ", ");
    start--;
    NaturalBack(start);
}
NaturalBack(n);