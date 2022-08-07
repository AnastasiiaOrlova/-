Console.Write ("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int square2 = n2 * n2;
if (n1 == square2)
    Console.WriteLine ($"{n1} is square of {n2}");
else 
    Console.WriteLine ($"{n1} is not square of {n2}");