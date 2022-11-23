using System;

namespace Figures
{
    internal class Circle: Figure
    {
        public Point CircleCenter { get; set; }
        public Point CirclePoint { get; set; }
        public Circle(Point circleCenter, Point circlePoint) :base(circleCenter, circlePoint)
        {
            CircleCenter = circleCenter;
            CirclePoint = circlePoint;
        }

        public override double GetArea()
        {
            double radius = 0, circleArea = 0;
            radius = Math.Sqrt(Math.Pow((CircleCenter.X - CirclePoint.X), 2) + Math.Pow((CircleCenter.Y - CirclePoint.Y), 2));
            return circleArea = Math.PI * Math.Pow(radius, 2);
        }
    }
}
