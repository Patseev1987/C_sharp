// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int sum = 0;
int x = 0;
int count = 0;

int Sum(int number)
{
    if (number >= 0)
    {
        while (number > 0)
        {
            x = number % 10;
            sum = sum + x;
            number = number / 10;
            count++;
        }
    }
    else
    {
        while (number < 0)
        {
            x = number % 10;
            sum = sum + x;
            number = number / 10;
            count++;
        }
    }
    return sum;
}

Console.WriteLine("Enter the number:");
int a = int.Parse(Console.ReadLine());

int o = Sum(a);
Console.WriteLine($"This number contains {count} digits.");
Console.WriteLine($"The sum of digits equals to {o}.");
