/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Ответ: " + Multiply(n));

int Multiply(int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        res = res * i;
    }
    return res;
}
