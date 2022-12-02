using System;

namespace Figures
{
    internal class Square: Figure
    {
        public Point TopLeft { get; set; }
        public double Size { get; set; }

        public Square(Point topLeft, double size, OutlineFigureSettings outlineSquareSettings, FillerFigureSettings fillerSquareSettings): base(outlineSquareSettings, fillerSquareSettings)
        {
            TopLeft = topLeft;
            Size = size;
        }

        public override double GetArea()
        {
            double size = 0,  squareArea = 0;           
            return squareArea = Math.Pow(size, 2);
        }

        public override void MoveFigureHorisontallly(double increment)
        {
            TopLeft.X += increment;
        }

        public override void MoveFigureVertically(double increment)
        {
            TopLeft.Y += increment;
        }

        public override void MoveFigureTo(Point newPoint)
        {
            TopLeft.X = newPoint.X;
            TopLeft.Y = newPoint.Y;
        }
        public override bool Equals(object obj)
        {
            if (obj is Square)
            {
                Square square = obj as Square;
                return (square.Size == Size) &&
                    TopLeft.Equals(square.TopLeft) &&
                    base.Equals(obj);
            }
            return false;
        }
    }
}
