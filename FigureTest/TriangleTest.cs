
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureTest
{
    [TestClass]
    public class TriangleTest
    {
        const double _expected_true_sideA = 3;
        const double _expected_true_sideB = 4;
        const double _expected_true_sideC = 5;


        [TestMethod]
        [DataRow(-3, 4, 5)]
        [DataRow(3, -4, 5)]
        [DataRow(3, 4, -5)]
        [DataRow(0, 4, -5)]
        [DataRow(3, 4, 0)]
        [DataRow(3, 0, -5)]
        public void Triangle_WrongArguments_Error(double variableSideA, double variableSideB, double variableSideC)
        {
            try
            {
                new Mindbox.Triangle(variableSideA, variableSideB, variableSideC);
                Assert.Fail($"{nameof(Mindbox.Triangle)} without error");
            }
            catch
            {

            }
        }

        [TestMethod]
        public void Triangle_TrueArguments_WithoutError()
        {
            try
            {
                var triangle = new Mindbox.Triangle(_expected_true_sideA, _expected_true_sideB, _expected_true_sideC);
                triangle.ShowFigure();
            }
            catch
            {
                Assert.Fail($"{nameof(Mindbox.Triangle)} with error");
            }
        }

        [TestMethod]
        public void Triangle_CheckIsRectangular_TrueAnswer()
        {
            try
            {
                var triangle = new Mindbox.Triangle(_expected_true_sideA, _expected_true_sideB, _expected_true_sideC);
                triangle.ShowFigure();

                if (!(triangle.IsRectangular == true))
                {
                    Assert.Fail($"{triangle.IsRectangular}");
                }
                triangle = new Mindbox.Triangle(6, 8, 10);
                if (!(triangle.IsRectangular == true))
                {
                    Assert.Fail($"{triangle.IsRectangular}");
                }
                triangle = new Mindbox.Triangle(12, 5, 13);
                if (!(triangle.IsRectangular == true))
                {
                    Assert.Fail($"{triangle.IsRectangular}");
                }
            }
            catch
            {
                Assert.Fail($"{nameof(Mindbox.Triangle)} with error");
            }
        }

        [TestMethod]
        public void Triangle_CheckIsRectangular_FalseAnswer()
        {
            try
            {
                var triangle = new Mindbox.Triangle(1, 1, 1);
                if (!(triangle.IsRectangular == false))
                {
                    Assert.Fail($"{triangle.IsRectangular}");
                }
                triangle = new Mindbox.Triangle(22, 10, 60);
                if (!(triangle.IsRectangular == false))
                {
                    Assert.Fail($"{triangle.IsRectangular}");
                }
                triangle = new Mindbox.Triangle(4, 1, 1);
                if (!(triangle.IsRectangular == false))
                {
                    Assert.Fail($"{triangle.IsRectangular}");
                }
                triangle = new Mindbox.Triangle(22, 44, 60);
                if (!(triangle.IsRectangular == false))
                {
                    Assert.Fail($"{triangle.IsRectangular}");
                }
            }
            catch
            {
                Assert.Fail($"{nameof(Mindbox.Triangle)} with error");
            }

        }
    }
}
