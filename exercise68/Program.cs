// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
    else
        return -1;
}
Console.WriteLine("Enter the m number for A(m,n):");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the n number for A(m,n):");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("*******************************");
int akk = FunctionAkkerman(m, n);
Console.WriteLine($"The value for Akkerman function is {akk}.");