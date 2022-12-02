namespace Figures
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                Point point = obj as Point;
                return point.X == X && point.Y == Y;
            }
            return false;
        }
    }
}
