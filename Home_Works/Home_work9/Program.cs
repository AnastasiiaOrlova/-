//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum(int n, int m)
{
    if (m != n)
    {
        if (n > m) 
        {
            return FindSum(n-1, m) + n;
        }
        else
        {
            return FindSum(m-1, n) + m;
        }
    } 
    else
        return n;
}
Console.Write("Input the first number: ");
int oneNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second numder: ");
int twoNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"Sum of elements from {oneNumber} to {twoNumber} is: ");
Console.WriteLine(FindSum(oneNumber, twoNumber));
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman (m - 1, 1);
    if (m > 0 && n > 0) return Akkerman (m - 1, Akkerman (m, n - 1));
    else
        {
            Console.WriteLine("Check first and second number. They must be positive");
            return 0;
        }
}
Console.Write("Input first positive number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
int akk = Akkerman(m, n);
Console.WriteLine($"The akkerman function is {akk}");
