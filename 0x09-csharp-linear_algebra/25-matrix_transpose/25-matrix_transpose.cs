﻿using System;

///<summary>MatrixMath class</summary>
class MatrixMath
{
    ///<summary>method to transpose a matrix and return the resulting matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] returnMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                returnMatrix[j, i] = matrix[i, j];
            }
        }
        return returnMatrix;
    }
}
