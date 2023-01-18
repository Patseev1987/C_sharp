// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

int DifferenceBetweenMinAndMax(int[] DBMAMrray)
{
    int result = 0;
    int min = DBMAMrray[0];
    int max = DBMAMrray[0];
    for (int i = 0; i < DBMAMrray.Length; i++)
    {
        if (DBMAMrray[i] < min)
        {
            min = DBMAMrray[i];
        }
        else if (DBMAMrray[i] > max)
        {
            max = DBMAMrray[i];
        }
    }
    result = max - min;
    return result;
}

int[] myArray = CreateRandomArray(10, -100, 100);
ShowArray(myArray);
Console.WriteLine("*******************************");
Console.WriteLine($"The difference between min and max is {DifferenceBetweenMinAndMax(myArray)}");