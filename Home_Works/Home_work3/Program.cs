/*
// 1. Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

*/
void Polindrom (int num)
{
    int digit1 = num / 10000; 
    int digit2 = (num / 1000) % 10;
    int digit3 = (num / 100) % 10;
    int digit4 = (num / 10) % 10;
    int digit5 = num % 10;
    if (digit1 == digit5 && digit2 == digit4)
    Console.WriteLine($"Number {num} is a polindrom.");
    else
    Console.WriteLine($"Number {num} is not a polindrom.");
}
Console.Write("Input integer five digit number: ");
int customeNumber = Convert.ToInt32(Console.ReadLine());
Polindrom(customeNumber);

/*
// 2. Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{  
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
}
Console.Write("Input coordinate x from dot number 1: ");
double customeX1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate y from dot number 1: ");
double customeY1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate z from dot number 1: ");
double customeZ1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate x from dot number 2: ");
double customeX2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate y from dot number 2: ");
double customeY2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate z from dot number 2: ");
double customeZ2 = Convert.ToDouble(Console.ReadLine());
double customeDistance = Distance (customeX1, customeY1, customeZ1, customeX2,customeY2, customeZ2);
Console.WriteLine($"Distance from dot number 1 with coordinate x={customeX1}, y={customeY1}, z={customeZ1} to dot number 2 with coordinate x={customeX2}, y={customeY2}, z={customeZ2} is {customeDistance}.");
*/


/*
// 3. Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowCube (int n)
{
    int current = 1;
    while(current <= n)
    {   
        double currentInCube = Math.Pow(current, 3);
        Console.WriteLine($"Cube from numder {current} = {currentInCube}");
        current++;
    }
}
Console.Write("Input positive integer number: ");
int customeNumber = Convert.ToInt32(Console.ReadLine());
ShowCube(customeNumber);
*/