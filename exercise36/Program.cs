// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumEventNumbers(int[] SENArray)
{
    int result = 0;
    for (int i = 0; i < SENArray.Length; i++)
    {
        if (SENArray[i] % 2 == 0)
        {
            result += SENArray[i];
        }
    }
    return result;
}

int[] myArray = CreateRandomArray(10, -10, 10);
ShowArray (myArray);
Console.WriteLine("*******************************");
Console.WriteLine($"The sum of even numbers in the array is {SumEventNumbers(myArray)}");