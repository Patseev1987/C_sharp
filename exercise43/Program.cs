void crossPoint(double k1, int b1, double k2, int b2)
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Эти прямые совпадают!");
    else if (k1 == k2)
        Console.WriteLine("Эти прямые парралельны!");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых: ({x},{y}).");
    }
}
Console.Clear();
Console.WriteLine("Введите k1 для первой прямой y=k1*x+b1.");
double kk1 = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите b1 для первой прямой y=k1*x+b1.");
int bb1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите k2 для второй прямой y=k2*x+b2.");
double kk2 = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите b2 для второй прямой y=k2*x+b2.");
int bb2 = int.Parse(Console.ReadLine());
Console.WriteLine();
crossPoint(kk1, bb1, kk2, bb2);