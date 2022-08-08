/*
// 1. Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Max = {number1}, Min = {number2}");
}
else
{
    Console.WriteLine($"Max = {number2}, Min = {number1}");
}
*/



/*
// 2. Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"Maximal number is {max}.");
*/



/*
// 3. Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Number {number} is even number.");
}
else 
{
    Console.WriteLine($"Number {number} is uneven number.");
}
*/


/*
// 4. Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input integer positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
if (number % 2 == 0)
{
    while (current <= number)
    {
        Console.Write(current + " ");
        current = current + 2;
    }
}    
else
{
    while (current < number)
    {
        Console.Write(current + " ");
        current = current + 2;
    }
    
}    

*/
