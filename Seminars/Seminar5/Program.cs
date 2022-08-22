/*
// 1. Задайте массив из 12-ти элементов, заполненный случайными числами из диапазона [-9, 9].
// Найтиде сумму отрицательных и положительных элементов массива.

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
void FindMinMax (int[]array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i =0; i<array.Length; i++)
    {
        if (array [i] > 0)
        sumPositive += array[i];
        else
        sumNegative += array[i];
    }
    Console.WriteLine ($"Sum of negative elements is {sumNegative}.");
    Console.WriteLine ($"Sum of positive elements is {sumPositive}.");
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
FindMinMax (myArray);
*/

/*
// 2. Напишите программу замены элементов массива, которая положительные элементы меняет на отрицательныеи наоборот.
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
int [] ChangeArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = array [i] * -1;
    }
    return array;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
ShowArray(ChangeArray(myArray));
*/

/*
// 3. Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве.
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
bool SearchValue(int[]array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;   
    }
    return false;
}
Console.Write("Input size for array: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] createArray = CreateArray (userSize);
ShowArray(createArray);
Console.Write("Input desired number from array: ");
int desiredNumber = Convert.ToInt32(Console.ReadLine());
bool result = SearchValue (createArray, desiredNumber);
if (result == true) Console.WriteLine ($"Custome massive has desired number {desiredNumber}.");
else Console.WriteLine ($"Custome massive has not desired number {desiredNumber}.");
*/

// 4. Задайте одномерный массив из 12-ти случайных чисел. Найдите кол-во эл-тов массива, значение которых лежит в отрезке [10, 99].
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
int QtElements (int[]array, int minElement, int maxElement)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minElement && array[i] <= maxElement)
        current += 1;
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
Console.Write("Input min value of range array: ");
int minValue  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of range array: ");
int maxValue  = Convert.ToInt32(Console.ReadLine());
int qtElements = QtElements(myArray, minValue, maxValue);
ShowArray(myArray);
Console.Write($"Custome array has {qtElements} elements with number from {minValue} to {maxValue}");