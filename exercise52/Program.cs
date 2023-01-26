Console.Clear();
void ShowArray (int[,] yArray)
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
void FindSum(int[,] myArray)
{
    Console.WriteLine("Enter the number of columns:");
    int number = int.Parse(Console.ReadLine());
    double sum = 0;

    if (number > 0 && number <= myArray.GetLength(1))
    {
        for (int i = 0; i < myArray.GetLength(0); i++)

        {
            sum = myArray[i, (number - 1)] + sum;
        }

        Console.WriteLine($"The average is {sum/myArray.GetLength(1)}");
        Console.WriteLine();
        Console.WriteLine("You can check:");
        ShowArray(myArray);

    }
    else
    {
        Console.WriteLine("You entered wrong number of columns");
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

Console.WriteLine("Enter the number of rows:");
int myRows = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
Console.WriteLine("Enter the number of columns:");
int myColumns = int.Parse(Console.ReadLine());
Console.WriteLine("***************************");
int[,] newArray = GetArrayRandom(myRows, myColumns);
FindSum(newArray);