﻿/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

1 2 3 4      3 4 5 6
5 6 7 8  ->  5 6 7 8
9 0 1 2      9 0 1 2
3 4 5 6      1 2 3 4
*/

int[,] array = 
{
    {1, 2, 3, 4,},
    {5, 6, 7, 8,},
    {9, 0, 1, 2,},
    {3, 4, 5, 6,},
    {7, 7, 7, 7,},
};

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void Swap(int[,]array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0,i];
        array[0,i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

Console.WriteLine("\nЗадан следующий массив: ");
PrintArray(array);


Swap(array);
Console.WriteLine("\nИзмененный массив: ");
PrintArray(array);

