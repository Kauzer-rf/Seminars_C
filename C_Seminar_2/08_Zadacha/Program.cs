/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
KratnoeChislo(161);
KratnoeChislo(7);
KratnoeChislo(1);

void KratnoeChislo(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число " + number + " кратно и 7, и 23.");
    }
    else
    {
        Console.WriteLine("Число " + number + " не кратно 7 и 23 одновременно");
    }
}

/* Решение без метода
Console.Write("Enter bumber: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Число " + num + " кратно и 7, и 23.");
}
else
{
    Console.WriteLine("Число " + num + " не кратно 7 и 23 одновременно");
}
*/
