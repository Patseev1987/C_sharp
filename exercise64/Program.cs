// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
void WriteNumbers(int min, int max)
{
    if (min == max)
    {
        Console.WriteLine(min);
        return;
    }
    Console.WriteLine(max);
    WriteNumbers(min, max - 1);

}

Console.WriteLine("Enter the first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the first number:");
int lastNumber = int.Parse(Console.ReadLine());
Console.WriteLine("*******************************");
WriteNumbers(firstNumber, lastNumber);