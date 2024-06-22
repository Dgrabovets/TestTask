namespace SquaresLib
{
    #region Prototyping

    public abstract class Shape
    {
        public Shape(string NameOfFigure)
        {
            this.NameOfFigure = NameOfFigure;
        }

        public string NameOfFigure { get; private set; }

        public abstract double GetSquare();
    }

    public static class ShapePrototyping
    {
        public static double GetSquare(Shape shape) => shape.GetSquare();
    }

    #endregion

    public class Triangle : Shape
    {
        public Triangle(string NameOfFigure, double FirstSide, double SecondSide, double ThirdSide) : base(NameOfFigure)
        {
            if (FirstSide < 0 || SecondSide < 0 || ThirdSide < 0) { throw new ArgumentException("Wrong input values, sides must be positive values!"); }
            else if (FirstSide > (SecondSide + ThirdSide) || SecondSide > (FirstSide + ThirdSide) || ThirdSide > (FirstSide + SecondSide)) { throw new ArgumentException("Wrong input values, one of triangle side is greater than summary of two others!"); }
            else
            {
                this.FirstSide = FirstSide;
                this.SecondSide = SecondSide;
                this.ThirdSide = ThirdSide;
            }
        }

        public override double GetSquare()
        {
            double halfOfPerimetre = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Round(Math.Sqrt(halfOfPerimetre * (halfOfPerimetre - FirstSide) * (halfOfPerimetre - SecondSide) * (halfOfPerimetre - ThirdSide)), 2);
        }

        public bool IsRectangular()
        {
            bool IsRectangularState = FirstSide == Math.Sqrt(Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2)) || (SecondSide == Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2))) || (ThirdSide == Math.Sqrt(Math.Pow(SecondSide, 2) + Math.Pow(FirstSide, 2)));

            return IsRectangularState;
        }

        public double FirstSide { get; private set; }

        public double SecondSide { get; private set; }

        public double ThirdSide { get; private set; }
    }

    public class Circle : Shape
    {
        public Circle(string NameOfFigure, double Radius) : base(NameOfFigure)
        {
            this.Radius = Radius;
        }

        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public double Radius { get; private set; }
    }
}
