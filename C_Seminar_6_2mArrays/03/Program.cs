/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
*/
bool IsTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
System.Console.Write("Введите число 3: ");
int c = int.Parse(Console.ReadLine());


if (IsTriangle(a, b, c))
{
    System.Console.WriteLine("Условие выполянется.");
}
else
{
    System.Console.WriteLine("Условие Не выполянется.");
}

