// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

void ShowArray(int[,] yArray)
{
    for (int i = 0; i < yArray.GetLength(0); i++)
    {
        for (int j = 0; j < yArray.GetLength(1); j++)
        {
            Console.Write($"{yArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}
int[,] GetArrayRandom(int rowsG, int columnsG)
{
    int[,] result = new int[rowsG, columnsG];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 11);
        }
    }
    return result;
}

int GetSumRowsMin(int[,] nArray)
{
    int[] sum = new int[nArray.GetLength(0)];

    for (int i = 0; i < nArray.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < nArray.GetLength(1); j++)
        {
            temp = nArray[i, j] + temp;
        }
        sum[i] = temp;
    }
    int min = sum[0];
    int counter = 0;
    for (int g = 0; g < sum.Length; g++)
    {
        if (sum[g] < min)
        {
            min = sum[g];
            counter = g;
        }
    }
    return counter + 1;
}


Console.WriteLine("Enter the number of rows:");
int myRows = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
Console.WriteLine("Enter the number of columns:");
int myColumns = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
int[,] newArray = GetArrayRandom(myRows, myColumns);

ShowArray(newArray);
Console.WriteLine("*************************************");
int myCounter = GetSumRowsMin(newArray);
Console.WriteLine($"The minimum sum in a row of array elements is in {myCounter} row!");