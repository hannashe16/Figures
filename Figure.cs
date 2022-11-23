namespace Figures
{
    internal abstract class Figure
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Figure(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public virtual double GetArea()
        {
            double rectangleLengh = 0, rectangleWidth = 0, rectangleArea = 0;
            rectangleLengh = BottomRight.X - TopLeft.X;
            rectangleWidth = TopLeft.Y - BottomRight.Y;
            return rectangleArea = rectangleLengh * rectangleWidth;
        }
    }
}
