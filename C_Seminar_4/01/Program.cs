﻿/*
Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/ 
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= a; i++)
{
sum = sum + i;
}
Console.WriteLine("Ответ: " + sum);

