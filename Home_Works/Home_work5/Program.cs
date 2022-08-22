/*
// 1. Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


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
int ShowCurrentEven(int[]array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 ==0) 
        current ++;
    }
    return current;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible 3-didit positive value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible 3-didit positive value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
int countEven = ShowCurrentEven(myArray);
ShowArray(myArray);
Console.Write($"Count of even number in ramdome 3-digit array is {countEven}.");
*/

/*
// 2. Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
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
int SumOfUnevenElements(int[]array)
{   
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0) 
        current = current + array [i];
    }
    return current;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
int sumOfUnevenElements = SumOfUnevenElements(myArray);
ShowArray(myArray);
Console.Write($"Sum of uneven position elements is {sumOfUnevenElements}.");
*/


/*
// 3. Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size)
{
    double [] newArray = new double [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        newArray[i] = rand.Next(-10000, 10000) + rand.NextDouble();
    return newArray;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double DifferenceMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array [i];
    }
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < min)
        min = array [j];
    }
    double result = max - min;
    return result;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray (a);
ShowArray(myArray);
double total = DifferenceMinMax(myArray);
Console.Write($"Difference between max and min elements of array is {total}.");
*/
