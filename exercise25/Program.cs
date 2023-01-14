// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

double raisedToThePower(double x, int a)
{
    double sum = -1;
    if (a <= -1 && x == 0) Console.WriteLine("It's a infinity!");
    else if (a > 0)
    {
        sum = x;
        for (int i = 2; i <= a; i++)
        {
            sum = sum * x;
        }
    }
    else if (a == 0 && x != 0)
    {
        sum = 1;
    }
    else if (a < 0 && x != 0)
    {
        sum = 1 / x;
        for (int j = a; j < -1; j++)
        {
            sum = sum / x;
        }
    }

    else if (a == 0)
    {
        sum = 0;
    }
    return sum;
}
Console.WriteLine("Enter the number:");
double number = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the exponent:");
int exponent = int.Parse(Console.ReadLine());
double result = raisedToThePower(number, exponent);

if (result != -1)
{
    Console.WriteLine("********************");
    Console.WriteLine(result);
}
