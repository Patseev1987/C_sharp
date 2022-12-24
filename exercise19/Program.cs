Console.Clear();
int dicision=0;
int number;
while (dicision==0)
{
    Console.WriteLine ("Enter the five-digit number!");
    int num=Convert.ToInt32(Console.ReadLine());
    if (num<10000 || num > 99999)
    {
        
        Console.WriteLine();
        Console.WriteLine(" Entered number is not five-digit! Try again.");
        Console.WriteLine();
    }
    else 
    {
        dicision = 1;
        number=num;
        /* Решение через тип переменной string.
        
           string str = number.ToString();         
        int x = str.Length;
            if (str[0]==str[x-1] && str[1]==str[x-2])
         */
            if(number%10==number/10000 && number%100/10==number%10000/1000)
            {
            Console.WriteLine("This number is palindrome!");
            }
            else
            {
                Console.WriteLine("This number is not palindrome!");
            }
    }
}



