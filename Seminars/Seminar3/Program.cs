/*
// Задача 1. Программа, которая на вход принимает координаты точек, а на выход выдает номер четверти, в которой находится эта точка.
int FindQuart (double x,double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());
int quarNum = FindQuart (xA, yA);
if (quarNum == 0)
{
    Console.WriteLine("Point is on the axes!");
}
else{
    Console.WriteLine($"Point is located on {quarNum} quart.");
}

*/

/*
// Задача 2. Программа, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти.
void FindCoordinats (int quart)
{
    if (quart == 1) 
    Console.WriteLine("Points has value x > 0 and y > 0");
    if (quart == 2) 
    Console.WriteLine("Points has value x < 0 and y > 0");
    if (quart == 3) 
    Console.WriteLine("Points has value x < 0 and y < 0");
    if (quart == 4) 
    Console.WriteLine("Points has value x > 0 and y < 0");
    if (quart != 1 && quart != 2 && quart != 3 && quart !=4) 
    Console.WriteLine($"Сoordinate plane doesn't have quart number {quart}");
}
Console.Write("Input number of quart in coordinate plane: ");
int customeQuart = Convert.ToInt32(Console.ReadLine());
FindCoordinats (customeQuart);

*/

/*
// Задача 3. Программа, которая на вход принимает координаты двух точек, а на выходе показывает расстояние между ними в 2D пространстве.
double Distance (double x1, double y1, double x2, double y2)
{  
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
}
Console.Write("Input coordinate x from dot number 1: ");
double customeX1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate y from dot number 1: ");
double customeY1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate x from dot number 2: ");
double customeX2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate y from dot number 2: ");
double customeY2 = Convert.ToDouble(Console.ReadLine());
double customeDistance = Distance (customeX1, customeY1, customeX2,customeY2);
Console.WriteLine($"Distance from dot number 1 with coordinate x={customeX1}, y={customeY1} to dot number 2 with coordinate x={customeX2}, y={customeY2} is {customeDistance}. ");
*/

// Задача 4. Программа, которая на вход принимает число (N), а на выходе выдает на консоль квадрат чисел от 1 до N.
void ShowSquare (int n)
{
    int current = 1;
    while(current <= n)
    {   
        int current2 = current * current;
        Console.WriteLine($"Square from numder {current} = {current2}");
        current++;
    }
}
Console.Write("Input integer number: ");
int customeNumber = Convert.ToInt32(Console.ReadLine());
ShowSquare (customeNumber);
