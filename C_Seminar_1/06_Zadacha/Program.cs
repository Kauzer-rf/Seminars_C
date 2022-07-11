// Прога принимает на вход 3х значное число и на выходе показывает последнюю цифру.
Console.Write("Ведите 3х значное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num % 10);

/* 
Вывод второй цифры
Console.Write("Ведите 3х значное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num % 100 / 10);

*/