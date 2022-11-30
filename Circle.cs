using System;

namespace Figures
{
    internal class Circle: Figure, IFigureMover
    {
        public Point CircleCenter { get; set; }
        double Radius { get; set; }
        public Circle(Point circleCenter, double radius)
        {
            CircleCenter = circleCenter;
            Radius = radius;
        }

        public override double GetArea()
        {
            double radius = 0, circleArea = 0;
            return circleArea = Math.PI * Math.Pow(radius, 2);
        }
        public void MoveFigureHorisontallly(double increment)
        {
            CircleCenter.X += increment;
        }
        public void MoveFigureVertically(double increment)
        {
            CircleCenter.Y += increment;
        }
        public void MoveFigureTo(Point newPoint)
        {
            CircleCenter.X = newPoint.X;
            CircleCenter.Y = newPoint.Y;
        }
    }
}
