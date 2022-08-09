
/*
// 1. Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Программа работает корректно только для положительных трехзначных чисел.

int SelectionSecondDigit (int number)
{  
    int doz = number / 10;
    int digit2 = doz % 10;
    return digit2;
}
Console.Write("Input integer three-digit number: ");
int customNumber = Convert.ToInt32(Console.ReadLine());
int secondDigit = SelectionSecondDigit(customNumber);
Console.WriteLine($"Two digit from number {customNumber} is {secondDigit}.");

*/


/*

// 2. Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Программа будет корректно работать только для чисел от -1 000 000 до 1 000 000. Для иных чисел в принципе работать не будет.
void SelectionThirdDigit(int number)
{
    if (number >= -99 && number < 100)
        Console.WriteLine("Custome's numder doesn't contain a third digit.");
    if (number > 99 && number < 1000)
       {
            int digit3 = number % 10;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       }
    if (number > 999 && number < 10000)
       {
            int digit3 = (number / 10) % 10;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       }
    if (number > 9999 && number < 100000)
       {
            int digit3 = (number / 100) % 10;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       } 
    if (number > 99999 && number < 1000000)
       {
            int digit3 = (number / 1000) % 10;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       }   
    if (number < -99 && number > -1000)
       {
            int digit3 = (number % 10) * -1;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       }
    if (number < -999 && number > -10000)
       {
            int digit3 = ((number / 10) % 10) * -1;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       }
    if (number < -9999 && number > -100000)
       {
            int digit3 = ((number / 100) % 10) * -1;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       } 
    if (number < -99999 && number > -1000000)
       {
            int digit3 = ((number / 1000) % 10) * -1;
            Console.WriteLine($"Third digit of number {number} is {digit3}");
       }   
}
Console.Write("Input integer number (from -1000000 to 1000000): ");
int customNumber = Convert.ToInt32(Console.ReadLine());
SelectionThirdDigit(customNumber);

*/


/*
// 3. Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int number)
{
    if(number >= 1 && number < 6)
        return false;
    else
        return true;
}
Console.Write ("Input number day of the week (from 1 to 7): ");
int day = Convert.ToInt32(Console.ReadLine());
bool typeOfDay = Weekend(day);
    if(day>=1 && day<=7)
    Console.WriteLine($"Day of the week number {day} is weekend. This statement is {typeOfDay}");
    else
    Console.WriteLine("Incorrect number was introduce");

*/