/*
Задача 17. Напишите программу, которая принимает на вход координаты Х и У, примерно они не равны 0. 
Выдает номер четверти плоскости, в которой находится точка. 
*/

Console.Write("Введите Х: ");
int xIn = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int yIn = int.Parse(Console.ReadLine());

int res = getQuarter(xIn, yIn);
Console.WriteLine("Номер квадрата: " + res);


int getQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return 0;

}
