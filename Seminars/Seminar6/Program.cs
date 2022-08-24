/*
// 1/ Программа, которая переворачивает одномерный массив.
int [] ReverseArray (int [] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
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
ShowArray(ReverseArray(myArray));
*/

/*
/ 2. Напишите программу, которая на вход принимает три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// a < b + c

bool Check (int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;   
    else
    return false;
}
Console.Write("Input integer number (side a): ");
int sideA = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input integer number (side b): ");
int sideB = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input integer number (side c): ");
int sideC = Convert.ToInt32 (Console.ReadLine());
bool result = Check(sideA, sideB, sideC);
if (result == true) Console.WriteLine ($"Triangle whith sides {sideA}, {sideB}, {sideC} is exist.");
else Console.WriteLine ($"Triangle whith sides {sideA}, {sideB}, {sideC} is not exist.");
*/

/*
// 3. Не используя рекурсию вывести первые N чисел Фибоначи. Первые два числа Фибоначи a и b.
int[]FibbonachiArray(int a, int b, int size)
{
    int [] newArray = new int[size];
    newArray[0] = a;
    newArray[1] = b;
    for (int i=2; i < size; i++)
    {
        newArray[i] = newArray[i-1] + newArray[i-2]; 
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input first number of Fibbonacci: ");
int fibA = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input second number of Fibbonacci: ");
int fibB = Convert.ToInt32 (Console.ReadLine());
Console.Write("How many Fibbonachi numbers do you want to see? ");
int fibN = Convert.ToInt32 (Console.ReadLine());
int[]result = FibbonachiArray(fibA, fibB, fibN);
ShowArray(result); //ShowArray(FibbonachiArray (fibA, fibB, fibN))
*/

// 4. Программа, которая будет преобразовывать десятичное число в двоичное.
void Transformation (int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    Console.WriteLine(result);
}
Console.Write("Input decimal number: ");
int num = Convert.ToInt32 (Console.ReadLine());
Console.Write($"Number {num} to binary is ");
Transformation (num);