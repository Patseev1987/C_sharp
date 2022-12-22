Console.WriteLine ("Enter the day of the week number ");
    int numberDayOfWeek=Convert.ToInt32(Console.ReadLine());
if (numberDayOfWeek==6 || numberDayOfWeek==7)
{
  Console.WriteLine("This day is day off!");
}
if (numberDayOfWeek>0 && numberDayOfWeek<6)
 {
      Console.WriteLine("This day is not day off!");
}
if (numberDayOfWeek<=0 || numberDayOfWeek>=8)
{
    Console.WriteLine("You made a mistake!");
    Console.WriteLine("Try again and enter a nuber from 1 to 7");
}