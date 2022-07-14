/* Напишите программу, которая выводит 3х значное число и удаляет втроую цифру этого числа.
*/

int a = new Random().Next (100, 1000);
Console.WriteLine(a);

int digitone = a / 100;
int digitThird = a % 10;
//Console.WriteLine(digitone*10 + digitThird);
Console.WriteLine(digitone + "" + digitThird);