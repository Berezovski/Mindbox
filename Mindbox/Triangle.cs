using System;
using System.Collections.Generic;
using System.Text;

namespace Mindbox
{
    sealed public class Triangle : Figure
    {
        private double sideA, sideB, sideC;

        protected override string FigureName => "Triangle";
        protected override double Area 
        {
            get 
            {
                double p = Perimeter / 2.0;
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)) ;
            }
        }
        protected override double Perimeter => sideA + sideB + sideC;

        public bool IsRectangular { get =>
                (sideA * sideA + sideB * sideB == sideC * sideC) ||
                (sideA * sideA + sideC * sideC == sideB * sideB) ||
                (sideC * sideC + sideB * sideB == sideA * sideA);             
        }

        public Triangle(double a, double b, double c)
        {
            if( (a<=0) || (b <= 0) || (c <= 0))
            {
                throw new ArgumentException($"The input data cannot be less than 0 (your data: {a},{b},{c})");
            }

            sideA = a;
            sideB = b;
            sideC = c;
        }
    }
}
