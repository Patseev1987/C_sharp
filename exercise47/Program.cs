// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] GetArrayDoubleRandom(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {

            int a = new Random().Next(0, 10);
            double b = new Random().NextDouble();
            newArray[i, j] = a + b;
        }
    }
    return newArray;
}
void ShowArray(double[,] sArray)
{
    for (int i = 0; i < sArray.GetLength(0); i++)
    {
        for (int j = 0; j < sArray.GetLength(1); j++)
        {
            Console.Write($"{sArray[i, j]:F2}  ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Enter the number of rows:");
int mRows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns:");
int mColumns = int.Parse(Console.ReadLine());
Console.WriteLine("**************************************************");
double[,] Array = GetArrayDoubleRandom(mRows, mColumns);
ShowArray(Array);