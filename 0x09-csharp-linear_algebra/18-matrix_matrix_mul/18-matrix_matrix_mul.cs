using System;

///<summary>MatrixMath class</summary>
class MatrixMath
{
    ///<summary>method that multiplies two matrices and returns the resulting matrix</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] defaultMatrix = new double[,] {{-1}};
        int rA = matrix1.GetLength(0);
        int cA = matrix1.GetLength(1);
        int rB = matrix2.GetLength(0);
        int cB = matrix2.GetLength(1);
        double temp = 0;
        double[,] kHasil = new double[rA, cB];

        if (cA != rB)
        {
            return defaultMatrix;
        }
        else
        {
            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    kHasil[i, j] = temp;
                }
            }
        return kHasil;
        }
    }
}
