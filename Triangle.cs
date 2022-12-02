using System;

namespace Figures
{
    internal class Triangle: Figure
    {
        public Point Apex1 { get; set; }
        public Point Apex2 { get; set; }
        public Point Apex3 { get; set; }

        public Triangle (Point apex1, Point apex2, Point apex3, OutlineFigureSettings outlineTriangleSettings, FillerFigureSettings fillerTriangleSettings): base(outlineTriangleSettings, fillerTriangleSettings)
        {
            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;
        }

        public override double GetArea()
        {
            double sideApex12 = 0, sideApex23 = 0, sideApex13 = 0, triangleArea = 0;
            sideApex12 = Math.Sqrt(Math.Pow((Apex2.X - Apex1.X), 2) + Math.Pow((Apex2.Y - Apex1.Y), 2));
            sideApex23 = Math.Sqrt(Math.Pow((Apex2.X - Apex3.X), 2) + Math.Pow((Apex2.Y - Apex3.Y), 2));
            sideApex13 = Math.Sqrt(Math.Pow((Apex1.X - Apex3.X), 2) + Math.Pow((Apex1.Y - Apex3.Y), 2));

            double halfPerimeter = (sideApex12 + sideApex23 + sideApex13) / 2;
            return triangleArea =
                Math.Sqrt(halfPerimeter * (halfPerimeter - sideApex12) * (halfPerimeter - sideApex23) * (halfPerimeter - sideApex13));
        }

        public override void MoveFigureHorisontallly(double increment)
        {
            Apex1.X += increment;
            Apex2.X += increment;
            Apex3.X += increment;
        }

        public override void MoveFigureVertically(double increment)
        {
            Apex1.Y += increment;
            Apex2.Y += increment;
            Apex3.Y += increment;
        }

        public override void MoveFigureTo(Point newPoint)
        {
            Apex1.X = newPoint.X;
            Apex1.Y = newPoint.Y;
            // как перенести остальные вершины?
        }
    }
}
