namespace Figures
{
    internal class Rectangle: Figure, IFigureMover
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle(Point topLeft, Point bottomRight) 
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

        public void MoveFigureHorisontallly(double increment)
        {
            TopLeft.X += increment;
            BottomRight.X += increment;
        }

        public void MoveFigureVertically(double increment)
        {
            TopLeft.Y += increment;
            BottomRight.Y += increment;
        }
        public void MoveFigureTo(Point newPoint)
        {
            double rectangleLengh = 0, rectangleWidth = 0;
            rectangleLengh = BottomRight.X - TopLeft.X;
            rectangleWidth = TopLeft.Y - BottomRight.Y;
            TopLeft.X = newPoint.X;
            TopLeft.Y = newPoint.Y;           
            BottomRight.X = newPoint.X + rectangleLengh;
            BottomRight.Y = newPoint.Y - rectangleWidth;
        }
    }
}
