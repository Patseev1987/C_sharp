
void PositiveCounter(int Length)
{
    int[] MyArray = new int[Length];
    int Count = 0;
    for (int i = 0; i < Length; i++)
    {
        Console.WriteLine($"Enter {i + 1} number:");
        int x = int.Parse(Console.ReadLine());
        MyArray[i] = x;
        if (x > 0)
            Count++;
    }
    Console.WriteLine($"You entered {Count} positive numbers.");
}
Console.Clear();
Console.WriteLine("How many numbers do you want to enter?");
int Size = int.Parse(Console.ReadLine());
Console.WriteLine();
PositiveCounter(Size);