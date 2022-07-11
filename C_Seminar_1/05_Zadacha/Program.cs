/* На вход принимается одно значение N, а на выходе показывает все целы числа в промежутке -N
4-> "-4, -3, -2, -1, 1, 2, 3, 4"
*/
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

int i = -num;
while (i <= num){
    Console.Write(i + " ");
    i++;
}

/* Решение с помощью оператора For
for (int i = -num; i <= num; i++){
    Console.Write(i + " ");
}
*/