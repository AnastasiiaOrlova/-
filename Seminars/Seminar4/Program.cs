/*
// 1. Программа, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.
int FindSum (int number)
{
    int sum = 0;
    for (int current = 1; current <= number; current++)
    {
        sum += current; //sum = sum + current
    }
    return sum;
}
Console.Write ("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}.");
*/

/*
// 2. Программа, которая на вход принимает число и выдает количество цифр в числе.
int FindeDigits (int number)
{
    int digit = 0;
    while (number > 0)
    {
        number = number / 10;
        digit++;
    }
    return digit;
}
Console.Write ("Input integer number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = FindeDigits(userNumber);
Console.WriteLine($"Number {userNumber} consist {result} digit.");
*/

/*
// 3. Программа, которая на вход принимает число N, а на выходе выдает произведение чисел от 1 до N.
int FindMultiplication (int number)
{
    int multiplication = 1;
    for (int current = 1; current <= number; current++)
    {
        multiplication = multiplication * current;
    }
    return multiplication;
}
Console.Write ("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindMultiplication(a);
Console.WriteLine($"Multiplication of numbers from 1 to {a} is {result}.");
*/

// 4. Программа, которая выводит массив из 8-и элементов,заполненный 0 и 1 в случайном порядке.
/*
void PrintArray (int[] array)
{
    int count = 8;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]}, ");
    }
}
int[]array = new int [8];
PrintArray(array);
*/

//Общий вариант
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
