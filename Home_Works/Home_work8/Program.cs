
/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
int [,] Sorting2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(1) - 1; t++)
                if (array [i, t] < array [i, t + 1])
                {
                    int temp = array[i, t];
                    array [i, t] = array [i, t + 1];
                    array [i, t + 1] = temp;
                }
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
int [,] newArray = Sorting2dArray (myArray);
Show2dArray(newArray);
*/

/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int [] SumRows (int[,]array)
{    
    int [] newArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array [i, j];
            newArray [i] = sum;
        }
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int MinSumRows (int[]array)
{
    int min = array [0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array [i];
            index = i;
        }
    }
    return index;
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
int [] resultArray = SumRows (myArray);
ShowArray(resultArray);
int minSumRows = MinSumRows (resultArray);
Console.Write($"Rows with min sum of elements is row number {minSumRows}"); //Счет начинаем с нуля.
*/

/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
int[,] Multiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] newArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    if (arrayA.GetLength(1) != arrayB.GetLength(0)) 
        {
            Console.WriteLine("These matrices cannot be multiplied");
            return newArray;
        }
    else
    {
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int temp = 0; temp < arrayB.GetLength(0); temp++)
                {    
                    newArray[i, j] += arrayA[i, temp] * arrayB[temp, j];                
                }
            }
        }
    }
    return newArray;
}
Console.Write("Input number of rows of first array: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns of first array: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows of second array: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns of second array: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = CreateRandom2dArray(r1, c1, min, max);
int[,] secondArray = CreateRandom2dArray(r2, c2, min, max);
Show2dArray(firstArray);
Console.WriteLine();
Show2dArray(secondArray);
Console.WriteLine();
int[,] multipliedArray = Multiplication(firstArray, secondArray);
Show2dArray(multipliedArray);
*/


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");
int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

