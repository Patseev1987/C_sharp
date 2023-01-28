// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int[,] GetSortRowsArray(int[,] nArray)
{

    for (int i = 0; i < nArray.GetLength(0); i++)
    {
        for (int g = 0; g < nArray.GetLength(1); g++)
        {

            for (int j = 0; j < nArray.GetLength(1); j++)
            {
                int temp = nArray[i, g];
                if (nArray[i, j] < temp)
                {
                    nArray[i, g] = nArray[i, j];
                    nArray[i, j] = temp;
                    temp = nArray[i, g];

                }
            }
        }
    }
    return nArray;
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
int[,] newArray2 = GetSortRowsArray(newArray);
ShowArray(newArray2);