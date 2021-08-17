using System;

///<summary>Vector Math class</summary>
class VectorMath
{
    ///<summary>method that calculates dot product of either two 2D or two 3D vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length ==2)
        {
            double dotProd = ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]));
            return Math.Round(dotProd, 2);
        }
        if (vector1.Length == 3 && vector2.Length ==3)
        {
            double dotProd = ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + vector1[2] * vector2[2]);
            return Math.Round(dotProd, 2);
        }
        else
        {
            return -1;
        }
    }
}
