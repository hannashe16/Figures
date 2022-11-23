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
    }
}
