using System.Collections.Generic;

namespace Figures
{
    internal class Rectangle: Figure
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle(Point topLeft, Point bottomRight):base(topLeft, bottomRight) 
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public override double GetArea()
        {
            double rectangleLengh = 0, rectangleWidth = 0, rectangleArea = 0;
            rectangleLengh = BottomRight.X - TopLeft.X;
            rectangleWidth = TopLeft.Y - BottomRight.Y;
            return rectangleArea = rectangleLengh * rectangleWidth;
        }

        public override List<Point> GetListOfPoints()
        {
            List<Point> pointsOfRectangle = new List<Point>();
            pointsOfRectangle.Add(TopLeft);
            pointsOfRectangle.Add(BottomRight);
            pointsOfRectangle.Add(new Point(BottomRight.X, TopLeft.Y));
            pointsOfRectangle.Add(new Point(TopLeft.X, BottomRight.Y));
            return pointsOfRectangle;
        }
    }
}
