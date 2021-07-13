using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigi = Math.Abs(number % 10);
        Console.Write("The last digit of " + number + " is ");
	    if (lastDigi > 5)
        {
            Console.WriteLine(lastDigi + " and is greater than 5");
        }
        else if (lastDigi == 0)
        {
            Console.WriteLine(lastDigi + " and is 0");
        }
        else
        {
            Console.WriteLine(lastDigi + " and is less than 6 and not 0");
        }
    }
}
