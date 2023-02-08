using System;
using System.Linq;

namespace Shapes
{
    public class Triangle: IEnclosedShape
    {
        double[] SideLengths;

        public bool IsRight { get {
                Array.Sort(SideLengths);
                // Pythagorean Theorem
                return Math.Pow(SideLengths[0], 2) + Math.Pow(SideLengths[1], 2) == Math.Pow(SideLengths[2], 2);
            } }


        //a,b,c is length of the triangle sides
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Provided side length is not a positive double");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("Provided sides do not form a triangle");
            }
            SideLengths = new double[3] { a, b, c };
        }

        public double GetArea()
        {
            // Heron's Formula for the area of a triangle
            double p = SideLengths.Sum() / 2; // half perimeter
            return Math.Sqrt(p * (p - SideLengths[0]) * (p - SideLengths[1]) * (p - SideLengths[2]));
        }
    }
}
