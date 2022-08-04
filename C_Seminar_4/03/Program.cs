/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int sum = 1;

for (int i = 1; i <= n; i++)
{
sum = sum * i;
}
Console.WriteLine("Ответ: " + sum);