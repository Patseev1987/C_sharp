// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] GetMultiplicationArrays(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int g = 0; g < array1.GetLength(1); g++)
            {
                temp = temp + array1[i, g] * array2[g, j];
            }
            result[i, j] = temp;
        }
    }

    return result;
}

Console.WriteLine("Enter the number of rows for first array:");
int myRows1 = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
Console.WriteLine("Enter the number of columns for first array:");
int myColumns1 = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
int[,] newArray1 = GetArrayRandom(myRows1, myColumns1);

ShowArray(newArray1);
Console.WriteLine();
Console.WriteLine("Enter the number of rows for second array:");
int myRows2 = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
Console.WriteLine("Enter the number of columns for second array:");
int myColumns2 = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
int[,] newArray2 = GetArrayRandom(myRows2, myColumns2);

ShowArray(newArray2);
Console.WriteLine("*************************************");
Console.WriteLine("This is result of multiplying arrays!");
int[,] multiplicationArray = GetMultiplicationArrays(newArray1, newArray2);
ShowArray(multiplicationArray);