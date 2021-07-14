using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new int[4] { 0, 1, 2, 3 };
            arr[1] = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            arr[2] = new int[2] { 0, 1 };

            for (int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    if (col == arr[row].Length - 1)
                    {
                        Console.WriteLine(arr[row][col]);
                    }
                    else
                    {
                        Console.Write("{0} ", arr[row][col]);
                    }
                }
            }

        }
    }
}
