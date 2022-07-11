// Ввод 2х чисел, проверка является ли 1ое квадратом 2ого.
Console.Write("Введите число - 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число - 2: ");
int num2 = int.Parse(Console.ReadLine());
if(num2 * num2 == num1)
{
    Console.WriteLine("Ok. Число 1 это квадрат числа 2");
}
else
{
    Console.WriteLine("Нет. Число 1 не являются квадратом числа 2");
}