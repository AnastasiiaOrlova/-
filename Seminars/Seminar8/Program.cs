// 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
        return array;
    else
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    return array;
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
Console.WriteLine();
myArray = ChangeRows(myArray, 0, r-1);
Show2dArray(myArray);
*/

// 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
int[,] ChangeRowsAndColumns(int[,] array)
{
    int rows = array.GetLength(1);
    int columns = array.GetLength(0);
    int [,] newArray = new int [rows, columns];
    if(rows != columns)
        return array;
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[i,j] = array[j,i];
            }
        }
    return newArray;
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
Console.WriteLine();
myArray = ChangeRowsAndColumns(myArray);
Show2dArray(myArray);
*/

/*
// 2 вариант
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
int[,] ChangeRowsColumns(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
        return array;
    else
    {
        for(int i = 0; i < array.GetLength(0)-1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
                {
                    int temp = array[i, j];
                    array[i,j] = array[j, i];
                    array[j,i] = temp;
                }
    }
    return array;
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
Console.WriteLine();
myArray = ChangeRowsColumns(myArray);
Show2dArray(myArray);
*/

/*
// 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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
int[,] DeleteMinRCElements(int[,] array)
{
    int min = array [0, 0];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                iMin = i;
                jMin = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array [i, jMin] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [iMin, j] = 0;
    }
    return array;
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
Console.WriteLine();
myArray = DeleteMinRCElements(myArray);
Show2dArray(myArray);
*/

//2 вариант
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
int[,] DeleteRowsColumns(int[,] array)
{
    int min = array[0, 0];
    int rowIndex = 0;
    int columnIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
            {
               if (array[i,j] < min)
                {
                    min = array[i,j];
                    rowIndex = i;
                    columnIndex = j;
                }
            }
    Console.WriteLine(min + " " + rowIndex + " " + columnIndex);
    Console.WriteLine();
    int[,] newArray = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(i < rowIndex && j < columnIndex) newArray[i, j] = array[i,j];
                if(i < rowIndex && j > columnIndex) newArray[i, j - 1] = array[i,j];
                if(i > rowIndex && j < columnIndex) newArray[i - 1, j] = array[i,j];
                if(i > rowIndex && j > columnIndex) newArray[i - 1, j - 1] = array[i,j];
            }     
    return newArray;   
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
int[,] DArray = DeleteRowsColumns(myArray);
Show2dArray(DArray);