    Console.WriteLine("We have a random number");
int a = new Random().Next(1,100000);    
Console.WriteLine(a);    
Console.WriteLine("***The result***");
if (a>=100 && a<=999)
{
    int b = a%10;
Console.WriteLine("The third number is "+b);
}
    if (a<100)
    {
  Console.WriteLine("This number doesn't have the third number");
  }
  if (a>=1000 && a<=9999)
  {
int c = a%100/10;
    Console.WriteLine("The third number is "+c);
  }
  if (a>=10000 && a<=99999)
  {
int d = a%1000/100;
    Console.WriteLine("The third number is "+d);
  }