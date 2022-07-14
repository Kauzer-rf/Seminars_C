/* Напишите программу, которая выводит 3х значное число и удаляет втроую цифру этого числа.
*/

int a = new Random().Next(100, 1000);
Console.WriteLine (a);

int result = delete2num (a);
Console.WriteLine (result);

int delete2num (int number)
{
    int digitOne = number / 100;
    int digitThird = number % 10;
    int resultDouble = digitOne * 10 + digitThird;
    return resultDouble;
}