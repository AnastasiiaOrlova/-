/*
// 1. Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Вариант 1.
int Exponentiation (int a, int b)
{
    int result = a;
    int current = 1;
    while (current < b)
    {
        result = result * a;
        current += 1;
    }
    return result;
}
Console.Write("Input integer positive first number: ");
int customA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer posotive second number: ");
int customB = Convert.ToInt32(Console.ReadLine());
int customResult = Exponentiation (customA, customB);
Console.WriteLine($"{customA} exponentiation {customB} is {customResult}");
*/
/*
// Вариант 2.
int Exponentiation (int a, int b)
{
    int result = a;
    for (int current = 1; current < b; current++)
    {
        result = result * a;
    }
    return result;
}
Console.Write("Input integer positive first number: ");
int customA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer posotive second number: ");
int customB = Convert.ToInt32(Console.ReadLine());
int customResult = Exponentiation (customA, customB);
Console.WriteLine($"{customA} exponentiation {customB} is {customResult}");
*/

/*
// 2. Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Sum (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}
Console.Write("Input integer number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumResult = Sum (userNumber);
Console.WriteLine($"Sum of digits in the number {userNumber} is {sumResult}.");
*/

/*
// 3. Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
            Console.Write($"Input {i} element of array: ");
            newArray[i] = Convert.ToInt32(Console.ReadLine());
        }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input size for array: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] createArray = CreateArray (userSize);
ShowArray(createArray);
*/
