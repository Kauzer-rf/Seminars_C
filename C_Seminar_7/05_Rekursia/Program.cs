/*
Найти факторичал числа
*/
Console.Write("Ведите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Факториал числа " + num + ": " + factorial(num));

int factorial(int number)
{
    if (number == 1)
    {
        return number;
    }
    return number * factorial(number - 1);
}
