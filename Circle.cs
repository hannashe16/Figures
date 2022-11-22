using System;

namespace Figures
{
    internal class Circle: Figure
    {
        public Circle(Point bottomRight, Point topLeft) :base(topLeft, bottomRight)
        {}

        public override double GetArea()
        {
            double radius = 0, circleArea = 0;
            radius = Math.Sqrt(Math.Pow((TopLeft.X - BottomRight.X), 2) + Math.Pow((BottomRight.Y - TopLeft.Y), 2));
            return circleArea = Math.PI * Math.Pow(radius, 2);
        }
    }
}
