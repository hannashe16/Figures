using System.Collections.Generic;

namespace Figures
{
    internal abstract class Figure
    {
        public Figure(Point topLeft, Point bottomRight)
        {}

        public abstract double GetArea();
        public abstract List<Point> GetListOfPoints();
        public virtual Point MoveRight(Point point, double increment)
        {
            double xMovedRightPoint = point.X + increment;
            return new Point(xMovedRightPoint, point.Y);
        }

        public virtual Point MoveLeft(Point point, double increment)
        { 
            double xMovedLeftPoint = point.X - increment;
            return new Point(xMovedLeftPoint, point.Y);
        }

        public virtual Point MoveUp(Point point, double increment)
        {
            double yMovedUpPoint = point.Y + increment;
            return new Point(point.X, yMovedUpPoint);
        }

        public virtual Point MoveDown(Point point, double increment)
        {
            double yMovedDownPoint = point.Y - increment;
            return new Point(point.X, yMovedDownPoint);
        }
    }
}
