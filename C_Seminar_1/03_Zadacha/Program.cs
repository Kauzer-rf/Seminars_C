// День недели по номеру
Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine());

if (n == 1) {
    Console.WriteLine("Ponedelnik");
} else if (n == 2){
    Console.WriteLine("Vtornik");
} else if (n == 3){
    Console.WriteLine("Sreda");
} else if (n == 4){
    Console.WriteLine("Chetverg");
} else if (n == 5){
    Console.WriteLine("Pyatnica");
} else if (n == 6){
    Console.WriteLine("Subbota");
} else if (n == 7){
    Console.WriteLine("Voskresenie");
} else {
    Console.WriteLine("Net takogo dnya");
}