/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    double [,] newArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = Math.Round(Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) + new Random().NextDouble(), 2); 
        }
    }
    return newArray;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Input size of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray (r, c, min, max);
Show2dArray(myArray);
*/


/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void SearchElements (int iUser, int jUser, int[,]array)
{
    int result = array[iUser, jUser];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == iUser && j == jUser)
            Console.WriteLine($"The array have element with index {iUser} and {jUser} and it is {result}."); 
        }
    }
}
Console.Write("Input size of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray (r, c, min, max);
Console.Write("Input search index row of element: ");
int rowUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Input search index column of element: ");
int columnUser = Convert.ToInt32(Console.ReadLine());
Show2dArray(myArray);
if (rowUser <= myArray.GetLength(0) && columnUser <= myArray.GetLength(1))
    {
        SearchElements (rowUser, columnUser, myArray);
    }
else Console.WriteLine($"The array have not element with index {rowUser} and {columnUser}.");
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double [] Average (int [,] array)
{
    double [] newArray = new double [array.GetLength(1)];
    double average = 0;
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        average = Math.Round(sum / array.GetLength(0), 2);  
        newArray[j] = average;
    }
    return newArray;
}
Console.Write("Input size of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray (r, c, min, max);
Show2dArray(myArray);
Console.WriteLine("The averages of each column are:");
double[] result = Average(myArray);
ShowArray (result);


