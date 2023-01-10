// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void cubed (int x)
{
    if(x>0)
    {
    int index=1;
        while (index <= x)
        {
            Console.WriteLine(index*index*index);
            index++;
        }
    }
    else if (x==0)
    {
        Console.WriteLine("0");
    }
    else
    {
        int index=-1;
        while (index >= x)
        {
            Console.WriteLine(index*index*index);
            index--;
        }    
    }


}
Console.Clear();
Console.WriteLine("Enter the number!");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("**********************************************");
cubed (number);

