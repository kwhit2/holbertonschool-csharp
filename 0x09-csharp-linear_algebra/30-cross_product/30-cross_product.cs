using System;

///<summary>MatrixMath class</summary>
class VectorMath
{
    ///<summary>method that calculates the cross product of two 3D vectors and returns the resulting vector.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        // two checks away: negative numbers and 0 edge cases
//        double[] crossProduct = {0, 0, 0};
//        double[] not3d = new double[1] {-1};
//
//        if (vector1.Length != 3 || vector2.Length != 3)
//        {
//            return not3d;
//        }
//        crossProduct = CrossProduct(vector1, vector2);
//        return crossProduct;

        double[] crossProduct = {0, 0, 0};
        double[] not3d = new double[1] {-1};

        if (vector1.Length != 3 || vector2.Length != 3)
        {
            return not3d;
        }

        crossProduct[0] = vector1[1] * vector2[2]
                     - vector1[2] * vector2[1];
        crossProduct[1] = vector1[2] * vector2[0]
                     - vector1[0] * vector2[2];
        crossProduct[2] = vector1[0] * vector2[1]
                     - vector1[1] * vector2[0];

        return crossProduct;
    }
}
