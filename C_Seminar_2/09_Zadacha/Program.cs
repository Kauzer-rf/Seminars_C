/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно из чисел квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());

/* Решение без функции
if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("Answear: Yes");
}
else {
    Console.WriteLine("Answear: No");
}
*/
if (isSqr(num1, num2))
{
    Console.WriteLine("Answear: Yes");
}
else {
    Console.WriteLine("Answear: No");
}

bool isSqr(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}