namespace SquaresLib.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void GetSquare()
        {
            Triangle triangle = new Triangle("Triangle", 4, 4, 2);
            double expected = 3.87;

            double square = triangle.GetSquare();

            Assert.Equal(expected, square);
        }

        [Fact]
        public void IsRect()
        {
            Triangle triangle = new Triangle("Triangle", 2, 3, 4);

            bool result = triangle.IsRectangular();

            Assert.False(result);
        }
    }

    public class CircleTest
    {
        [Fact]
        public void GetSquare()
        {
            Circle circle = new Circle("Circle", 14);
            double expected = 615.75;

            double square = circle.GetSquare();

            Assert.Equal(expected, square);
        }
    }
}