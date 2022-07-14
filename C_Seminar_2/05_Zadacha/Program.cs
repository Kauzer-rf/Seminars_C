/*Напишите программу, которая выводит случайное число из открезка [10,100) и показывает наибольшую цифру 
78 -> 8
12 -> 2
85 -> 8
*/

int num = new Random().Next(10, 100);
Console.WriteLine("Random number: " + num);

int firstDigit = num / 10;
int secondDigit = num % 10;

Console.WriteLine("Max number: " + getMax(firstDigit, secondDigit));

int getMax(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
