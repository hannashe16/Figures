using System;

namespace Figures
{
    internal class Circle: Figure
    {
        public Point CircleCenter { get; set; }
        double Radius { get; set; }

        public Circle(Point circleCenter, double radius, OutlineFigureSettings outlineCircleSettings, FillerFigureSettings fillerCircleSettings): base(outlineCircleSettings, fillerCircleSettings)
        {
            CircleCenter = circleCenter;
            Radius = radius;
        }

        public override double GetArea()
        {
            double radius = 0, circleArea = 0;
            return circleArea = Math.PI * Math.Pow(radius, 2);
        }
        public override void MoveFigureHorisontallly(double increment)
        {
            CircleCenter.X += increment;
        }
        public override void MoveFigureVertically(double increment)
        {
            CircleCenter.Y += increment;
        }
        public override void MoveFigureTo(Point newPoint)
        {
            CircleCenter.X = newPoint.X;
            CircleCenter.Y = newPoint.Y;
        }
        public override bool Equals(object obj)
        {
            if (obj is Circle)
            {
                Circle circle = obj as Circle;
                return (circle.Radius == Radius) &&
                    CircleCenter.Equals(circle.CircleCenter) &&
                    base.Equals(obj);
            }
            return false;
        }
    }
}
