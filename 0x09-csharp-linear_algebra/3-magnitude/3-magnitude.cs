using System;

///<summary>Vector Math Class</summary>
class VectorMath
{
    ///<summary>Method that calculates and returns the length of a given vector.</summary>
    public static double Magnitude(double[] vector)
    {
        // 2D vector check
        if (vector.Length == 2)
        {
            // The length or magnitude of a vector is calculated with the pythagorean theorm (square root of x^2 + y^2)
            double result = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)));
            // round to decimal places (hundreth)
            return Math.Round(result, 2);
        }
        // 3D vector check
        if (vector.Length == 3)
        {
            double result = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)));
            return Math.Round(result, 2);
        }
        else
            return -1;
    }
}
