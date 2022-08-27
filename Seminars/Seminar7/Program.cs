// 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
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
*/

/*
//2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// на вход - размер, на выход - массив
int [,] Create2dArray (int rows, int columns)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;
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
Console.Write("Input size of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2dArray (r, c);
Show2dArray(myArray);
*/

/*
// 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// на вход -массив, на выход - массив
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
int [,] Qvad (int [,] customeArray)
{
    for (int i = 0; i < customeArray.GetLength(0); i += 2)
        for (int j = 0; j < customeArray.GetLength(1); j += 2)
            customeArray [i, j] = customeArray [i, j] * customeArray [i, j];
    return customeArray;
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
Console.WriteLine(" ");
Show2dArray (Qvad (myArray));
*/


// 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// i = j
// на вход - массив, на выход - число,т.е. сумму, требуемых элементов.
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
int SumDiagonal (int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array [i, i];
        /*for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array [i, j];
            }
        }
        */
    }
    return sum;
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
int result = SumDiagonal (myArray);
Console.WriteLine($"Sum of elements located in main diagonal is {result}.");
