// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
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

void FindElement(int[,] fArray)
{

    System.Console.WriteLine("""
    How do you want to find an element? 
    Do you want to find an element in array by value? 
    Press "V"
    Do you want to find an element in array by index?
    Press "I"
    Do you want to find an element in array by serial number?
    Press "S"
    """);

    string enteredChar = Console.ReadLine();

    switch (enteredChar.ToLower())
    {
        case "v":

            Console.WriteLine("Enter the number:");

            int x = int.Parse(Console.ReadLine());
            bool logick = false;

            for (int i = 0; i < fArray.GetLength(0); i++)
            {
                for (int j = 0; j < fArray.GetLength(1); j++)
                {
                    if (fArray[i, j] == x)
                        logick = true;

                }
            }
            if (logick == true)
                Console.WriteLine($"This array contains {x}!");
            else
                Console.WriteLine($"This array does not contain {x}!");
            ShowArray(fArray);
            break;
        case "i":
            Console.WriteLine("Enter the first index:");
            int index1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second index:");
            int index2 = int.Parse(Console.ReadLine());
            if (index1 > fArray.GetLength(0) || index2 > fArray.GetLength(1) || index1 >= 0 || index2 >= 0)
                Console.WriteLine($"This index corresponds to the number {fArray[index1, index2]}");
            else
                Console.WriteLine("You entered wrong index");

            ShowArray(fArray);
            break;
        case "s":
            Console.WriteLine("Enter the serial number:");
            int index = int.Parse(Console.ReadLine());
            int counter = 0;
            int temp = -1;
            for (int i = 0; i < fArray.GetLength(0); i++)
            {
                for (int j = 0; j < fArray.GetLength(1); j++)
                {
                    counter++;

                    if (counter == index)
                    {

                        temp = fArray[i, j];
                        break;
                    }

                }
            }
            if (temp != -1)
                System.Console.WriteLine($"This index corresponds to the number {temp}");
            else
                Console.WriteLine("You entered wrong serial number");
            ShowArray(fArray);
            break;


        default:
            Console.WriteLine("You entered wrong letter");
            break;
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
int[,] myArray = GetArrayRandom(myRows, myColumns);
// Console.WriteLine("Enter the number  to search");
// int element = int.Parse(Console.ReadLine());
FindElement(myArray);