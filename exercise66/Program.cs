// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
int WriteSum(int min, int max)
{
    int sum = max;
    if (min != max)
    {
        sum = sum + WriteSum(min, max - 1);
        return sum;
    }
    else
        return sum;
}
Console.WriteLine("Enter the first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the first number:");
int lastNumber = int.Parse(Console.ReadLine());
Console.WriteLine("*******************************");
int sumRange = WriteSum(firstNumber, lastNumber);
Console.WriteLine($"Sum is {sumRange}.");
