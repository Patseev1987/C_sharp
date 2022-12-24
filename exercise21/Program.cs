// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void length(int x,int y,int z,int xx,int yy,int zz)
{
    int xLength=x-xx;
    int yLength=y-yy;
    int zLength=z-zz;
    double solution=Math.Sqrt(Math.Pow(xLength, 2)+Math.Pow(yLength, 2)+Math.Pow(zLength, 2));
    Console.WriteLine($"The length of the segment is {solution:f3}");
}
Console.Clear();
Console.WriteLine("Enter the X1");
int x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Y1");
int y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Z1");
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the X2");
int x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Y2");
int y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Z2");
int z2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("**********************************************");
length(x1,y1,z1,x2,y2,z2);