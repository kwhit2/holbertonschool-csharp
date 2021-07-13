using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1;
            int d2;

            for (d1 = 0; d1 <= 9; d1++)
            {
                for (d2 = d1 + 1; d2 <= 9; d2++)
                {
                    Console.Write(d1.ToString() + d2.ToString());
                    if (d1 == 8 && d2 == 9)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
