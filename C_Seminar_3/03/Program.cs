/* Задача 18: Напишите программу которая по заданному номеру четверти,
показывает диапазон возможноых координат точек в этой четверти (х и у).
*/
Console.Write("Enter quarter: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Otvet: " + foundXY(num));

string foundXY(int a)
{
    if (a == 1)
    {
        return "x > 0 & y > 0";
    }
    if (a == 2)
    {
        return "x < 0 & y > 0";
    }
    if (a == 3)
    {
        return "x < 0 & y < 0";
    }
    if (a == 4)
    {
        return "x > 0 & y < 0";
    }
    return "error";
}