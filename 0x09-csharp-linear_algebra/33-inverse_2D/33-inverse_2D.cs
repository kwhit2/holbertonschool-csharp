using System;

///<summary>MatrixMAth class</summary>
class MatrixMath
{
    ///<summary>method that calculates the inverse of a 2D matrix and returns the resulting matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] not2d = new double[,] {{-1}};
        double[,] nonInvertible = new double[,] {{-1}};

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return not2d;
        }
        
    }
}
