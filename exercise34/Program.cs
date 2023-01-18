// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int CounterEventNumbers(int[] CENArray)
{
    int result = 0;
    for (int i = 0; i < CENArray.Length; i++)
    {
        if (CENArray[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] myArray = CreateRandomArray(10, 100, 1000);
ShowArray (myArray);
Console.WriteLine("***************************");
Console.WriteLine($"The number of even numbers in the array is {CounterEventNumbers(myArray)}");
