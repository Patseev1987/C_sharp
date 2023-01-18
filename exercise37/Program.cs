// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

Console.WriteLine("Enter the size of the array:");
int n = int.Parse(Console.ReadLine());


int[] MyArray = CreateRandomArray(n, 0, 10);
ShowArray(MyArray);



int[] CreateNewArray(int[] narray)
{
    int ArrayLength;
    int[] newArray;
    if (narray.Length % 2 == 0)
    {
        ArrayLength = narray.Length / 2;
        newArray = new int[ArrayLength];
        for (int i = 0; i < ArrayLength; i++)
        {
            newArray[i] = narray[i] * narray[(narray.Length - 1) - i];


        }
    }
    else
    {
        ArrayLength = ((narray.Length - 1) / 2);
        newArray = new int[ArrayLength + 1];
        for (int j = 0; j < ArrayLength; j++)
        {
            newArray[j] = narray[j] * narray[(narray.Length - 1) - j];



        }
        newArray[newArray.Length - 1] = narray[ArrayLength];
    }
    return newArray;

}


System.Console.WriteLine();
int[] myNewArray = CreateNewArray(MyArray);
ShowArray(myNewArray);

