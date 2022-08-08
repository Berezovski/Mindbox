using System;
using System.Collections.Generic;
using System.Text;

namespace Mindbox
{
    public abstract class Figure
    {
        protected abstract string FigureName { get; }
        protected abstract double Area { get; }
        protected abstract double Perimeter { get; }

        public virtual void ShowFigure()
        {
            Console.WriteLine(
                $"Название фигуры: {FigureName}\n" +
                $"Площадь: {Area}\n" +
                $"Периметр: {Perimeter}"
            );
            Console.WriteLine();
        }
    }
}
