using System;
using System.Collections.Generic;

namespace Figures
{
    internal class Square: Figure
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Square(Point topLeft, Point bottomRight):base(topLeft, bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public override double GetArea()
        {
            double squareSide = 0,  squareArea = 0;
            squareSide = BottomRight.X - TopLeft.X;
            return squareArea = Math.Pow(squareSide, 2);
        }

        public override List<Point> GetListOfPoints()
        {
            List<Point> pointsOfSquare = new List<Point>();
            pointsOfSquare.Add(TopLeft);
            pointsOfSquare.Add(BottomRight);
            pointsOfSquare.Add(new Point(BottomRight.X, TopLeft.Y));
            pointsOfSquare.Add(new Point(TopLeft.X, BottomRight.Y));
            return pointsOfSquare;
        }
    }
}
