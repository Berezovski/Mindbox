using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureTest
{
    [TestClass]
    public class CircleTest
    {
        const double _expected_true_raduis = 2;

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Circle_WrongArguments_Error(double wrongRadius)
        {
            try
            {
                new Mindbox.Circle(wrongRadius);
                Assert.Fail($"{nameof(Mindbox.Circle)} without error");
            }
            catch
            {

            }
        }

        [TestMethod]
        public void Circle_TrueArguments_WithoutError()
        {
            try
            {
                Mindbox.Figure circ = new Mindbox.Circle(_expected_true_raduis);
                circ.ShowFigure();
            }
            catch
            {
                Assert.Fail($"{nameof(Mindbox.Circle)} with error");
            }

        }
    }
}
