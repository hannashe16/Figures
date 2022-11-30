using System;

namespace Figures
{
    internal class Square: Figure, IFigureMover
    {
        public Point TopLeft { get; set; }
        public double Size { get; set; }
        public Square(Point topLeft, double size)//:base()
        {
            TopLeft = topLeft;
            Size = size;
        }

        public override double GetArea()
        {
            double size = 0,  squareArea = 0;           
            return squareArea = Math.Pow(size, 2);
        }

        public void MoveFigureHorisontallly(double increment)
        {
            TopLeft.X += increment;
        }

        public void MoveFigureVertically(double increment)
        {
            TopLeft.Y += increment;
        }

        public void MoveFigureTo(Point newPoint)
        {
            TopLeft.X = newPoint.X;
            TopLeft.Y = newPoint.Y;
        }
    }
}
