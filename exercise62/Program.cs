// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// I think it is the easiest solution for this task =)
// System.Console.WriteLine("Enter the first number in array:");
// int number = int.Parse(Console.ReadLine());
// number=number-1;
// Console.WriteLine("**************************************");
// int[,] easy = new int[4, 4] {
//     {number+1, number+2, number+3, number+4},
//     {number+12,number+13,number+14,number+5},
//     {number+11,number+16,number+15,number+6},
//     {number+10, number+9, number+8,number+7}
// };
// void ShowArray(int[,] yArray)
// {
//     for (int i = 0; i < yArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < yArray.GetLength(1); j++)
//         {
//             Console.Write($"{yArray[i, j]}   ");
//         }
//         Console.WriteLine();
//     }
// }
// ShowArray(easy);

// It's one-stop solution.
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
int[,] FillArrayInASpiral(int[,] sArray)
{
    System.Console.WriteLine("Enter the first number in array:");
    int number = int.Parse(Console.ReadLine());
    int k = -1;
    int lastIndexRows = sArray.GetLength(0) - 1;
    int lastIndexColumns = sArray.GetLength(1) - 1;

    if (sArray.GetLength(0) >= sArray.GetLength(1))
    {
        if (sArray.GetLength(1) % 2 == 0)
            k = sArray.GetLength(1) / 2;
        else
            k = (sArray.GetLength(1) / 2) + 1;
    }
    else
    {
        if (sArray.GetLength(0) % 2 == 0)
            k = sArray.GetLength(0) / 2;
        else
            k = (sArray.GetLength(0) / 2) + 1;
    }

    for (int i = 0; i < k; i++)
    {
        for (int j = i; j < sArray.GetLength(1) - i; j++)
        {
            sArray[i, j] = number;
            number++;
        }
        for (int h = i + 1; h < sArray.GetLength(0) - i; h++)
        {
            sArray[h, lastIndexColumns - i] = number;
            number++;
        }
        if (sArray[lastIndexRows - i, lastIndexColumns - i - 1] == 0)
        {
            for (int g = lastIndexColumns - i; g > 0 + i; g--)
            {
                sArray[lastIndexRows - i, g - 1] = number;
                number++;

            }
        }
        if (sArray[lastIndexRows - 1 - i, i] == 0)
        {
            for (int f = lastIndexRows - 1 - i; f > i; f--)
            {
                sArray[f, i] = number;
                number++;
            }
        }
        else
            break;
    }
    return sArray;
}

Console.WriteLine("Enter the number of rows:");
int myRows = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
Console.WriteLine("Enter the number of columns:");
int myColumns = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
int[,] newArray = new int[myRows, myColumns];
int[,] spiralArray = FillArrayInASpiral(newArray);
Console.WriteLine("**************************************");
ShowArray(spiralArray);