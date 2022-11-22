using System;

namespace Figures
{
    internal class Triangle: Figure
    {       
        public Point Apex3 { get; set; }

        public Triangle (Point topLeft, Point bottomRight, Point apex3):base(topLeft, bottomRight)
        {
            Apex3 = apex3;
        }

        public override double GetArea()
        {
            double sideApex12 = 0, sideApex23 = 0, sideApex13 = 0, triangleArea = 0;
            sideApex12 = Math.Sqrt(Math.Pow((BottomRight.X - TopLeft.X), 2) + Math.Pow((BottomRight.Y - TopLeft.Y), 2));
            sideApex23 = Math.Sqrt(Math.Pow((BottomRight.X - Apex3.X), 2) + Math.Pow((BottomRight.Y - Apex3.Y), 2));
            sideApex13 = Math.Sqrt(Math.Pow((TopLeft.X - Apex3.X), 2) + Math.Pow((TopLeft.Y - Apex3.Y), 2));

            double halfPerimeter = (sideApex12 + sideApex23 + sideApex13) / 2;
            return triangleArea =
                Math.Sqrt(halfPerimeter * (halfPerimeter - sideApex12) * (halfPerimeter - sideApex23) * (halfPerimeter - sideApex13));
        }  
    }
}
