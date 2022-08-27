// 1. Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateUserArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} number: ");
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
int PositiveNumersCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if (array [i] > 0) count++;
    }
    return count;
}
Console.Write("Input how many numbers would you like to enter: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateUserArray (m);
ShowArray(myArray);
int result = PositiveNumersCount (myArray);
Console.WriteLine($"There are {result} positive numbers");
*/

// 2. Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void PointOfIntersection(double customK1, double customB1, double customeK2, double customeB2)
{
    double x = (customeB2 - customB1) / (customK1 - customeK2);
    double y = customK1 * x + customB1;
    if (customK1 == customeK2) Console.WriteLine("These lines are parallel");
    else Console.WriteLine($"The point of intersection of the lines has coordinates: {x}; {y}");
}
Console.WriteLine("Input the value k1, where: y = k1 * x + b1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value b1, where: y = k1 * x + b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value k2, where: y = k2 * x + b2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value b2, where: y = k2 * x + b2");
double b2 = Convert.ToDouble(Console.ReadLine());
PointOfIntersection(k1, b1, k2, b2);