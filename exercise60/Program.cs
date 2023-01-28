// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

void ShowArray(int[,,] yArray)
{
    for (int g = 0; g < yArray.GetLength(0); g++)
    {
        for (int i = 0; i < yArray.GetLength(1); i++)
        {
            for (int j = 0; j < yArray.GetLength(2); j++)
            {
                Console.Write($"{yArray[g, i, j]}({g},{i},{j})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] GetArrayRandom(int rowsG, int columnsG, int zLine)
{
    int[,,] result = new int[rowsG, columnsG, zLine];
    int counter = 10;
    for (int g = 0; g < result.GetLength(0); g++)
    {
        for (int i = 0; i < result.GetLength(1); i++)
        {
            for (int j = 0; j < result.GetLength(2); j++)
            {
                result[g, i, j] = counter;
                counter++;
            }
        }
    }
    return result;
}




Console.WriteLine("Enter the number of rows:");
int myRows = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
Console.WriteLine("Enter the number of columns:");
int myColumns = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
Console.WriteLine("Enter the number of zline:");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
int[,,] newArray = GetArrayRandom(myRows, myColumns, z);
ShowArray(newArray);
