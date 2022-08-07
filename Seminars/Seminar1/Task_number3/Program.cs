Console.Write("Input integer possitive number: ");
int number = Convert.ToInt32 (Console.ReadLine());
int current = number * (-1);
while (current <= number)
{
    Console.Write(current + " ");
    current ++;
}