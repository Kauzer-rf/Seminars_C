/*
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
Console.Write("Введите число: ");

/* string num = Console.ReadLine();
int res = num.Length;
Console.WriteLine("Количество цифр: " + res);
*/

int num = int.Parse(Console.ReadLine());
int i = 0;
while (num != 0)
{
    num = num / 10;
    i++;
}
Console.Write(i);