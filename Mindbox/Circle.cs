using System;
using System.Collections.Generic;
using System.Text;

namespace Mindbox
{
    sealed public class Circle : Figure
    {
        protected override string FigureName { get => "Circle"; }
        protected override double Area { get => Math.PI * _radius * _radius; }
        protected override double Perimeter { get => 2.0 * Math.PI * _radius; }

        private double _radius;

        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException($"The input data cannot be less than 0 (your data: {r})");
            }

            _radius = r;
        }
    }
}
