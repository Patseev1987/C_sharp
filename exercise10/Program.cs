    Console.WriteLine("We have a random number");
int a = new Random().Next(100,1000);    
Console.WriteLine(a);    
Console.WriteLine("***The result***");
int b = (a/10)%10;
Console.WriteLine(b);
  