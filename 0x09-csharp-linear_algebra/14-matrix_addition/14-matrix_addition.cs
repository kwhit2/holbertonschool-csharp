using System;

///<summary>MatrixMath class</summary>
class MatrixMath
{
    ///<summary>method that adds two matrices and returns the resulting matrix.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] defaultMatrix = new double[,] {{-1}};
        double[,] returnMatrix;

        if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
        {
            returnMatrix = new double[2,2];
        }
        else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
        {
            returnMatrix = new double[3,3];
        }
        else
        {
            return defaultMatrix;
        }
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                returnMatrix[i, j] = matrix1[i, j] + matrix2[i, j]; 
            }
        }
        return returnMatrix;
    }
}
