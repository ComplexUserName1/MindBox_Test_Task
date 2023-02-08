using System;
using Xunit;
using Shapes;

namespace TestShapes
{
    public class TestTriangleArea
    {
        [Fact]
        public void IsTriangleAreaCorrect()
        {
            Assert.Equal(3.799671038392666, ShapesUtils.GetTriangleAreaBySides(2, 5, 4));
            Assert.Equal(9.921567416492215, ShapesUtils.GetTriangleAreaBySides(4, 5, 6));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 2, 4));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(4, 1, 2));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(2, 4, 1));

            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(-1, 1, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, -1, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 1, -1));

            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(0, 1, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 0, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 1, 0));
        }

        [Fact]
        public void IsRight_Correct()
        {
            Assert.False(new Triangle(3, 3, 3).IsRight);
            Assert.True(new Triangle(3, 5, 4).IsRight);
        }
    }
}
