using System;

///<summary>Vector Math class</summary>
class VectorMath
{
    ///<summary>method that adds two vectors and returns the resulting vector.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // declare a vector with only -1 in it
        double[] vectSum = new double[1] {-1};

        if (vector1.Length == 2 && vector2.Length == 2)
        {
            // add corresponding values and add to vectSum
            vectSum = new double[2] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1])};
        }
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            // add corresponding values and add to vectSum
            vectSum = new double[3] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1]), (vector1[2] + vector2[2])};
        }
        return vectSum;
    }
}
