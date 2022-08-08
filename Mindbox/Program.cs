using System;

namespace Mindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cicr = new Circle(2);
            var tr = new Triangle(5,4,3);
            Figure noNameFigure = cicr;
            Figure noNameFigureButGuess = tr;
            noNameFigure.ShowFigure();
            noNameFigureButGuess.ShowFigure();
            Console.WriteLine(tr.IsRectangular);
        }
    }
}
