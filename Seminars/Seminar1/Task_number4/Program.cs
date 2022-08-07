Console.Write("Input integer three-digit number: ");
int number = Convert.ToInt32 (Console.ReadLine());
int ed = number % 10;
Console.WriteLine($"Last digit of {number} is {ed}");