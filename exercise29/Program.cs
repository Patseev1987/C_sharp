// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] FillArrayRandom (int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.WriteLine(array[i]);
}
return array;
}

int[] arr = FillArrayRandom(8);

Console.WriteLine();

Console.WriteLine($" [ {String.Join(", ", arr)} ]");