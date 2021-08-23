using System;

///<summary>MatrixMath class</summary>
class VectorMath
{
    ///<summary>method that calculates the cross product of two 3D vectors and returns the resulting vector.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] crossProduct = {0, 0, 0};
        double[] not3d = new double[1] {-1};

        if (!matrix.GetLength(0) == 3 || !matrix.GetLength(1) == 3)
        {
            return not3d;
        }
        crossProduct = CrossProduct(vector1, vector2);
        return crossProduct;
    }
}
