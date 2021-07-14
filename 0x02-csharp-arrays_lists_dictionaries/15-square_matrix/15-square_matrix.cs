using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int [,] twoD = myMatrix;
        int rowLength = twoD.GetLength(0);
        int colLength = twoD.GetLength(1);
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                twoD[i, j] *= twoD[i, j];
            }
        }
        return (twoD);
    }
}
