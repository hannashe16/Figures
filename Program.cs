using System;
using System.Collections.Generic;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point rectangleTopLeft = new Point(2,4);
            Point rectangleBottomRight = new Point(6,1);
            Rectangle rectangle = new Rectangle(rectangleTopLeft, rectangleBottomRight);

            Point squareTopLeft = new Point(2, 4);
            Point squareBottomRight = new Point(5,1);

            Point trianglePoint1 = new Point(2, 4);
            Point trianglePoint2 = new Point(4, 5);
            Point trianglePoint3 = new Point(1, 1);

            Point trianglePoint4 = new Point(0, 4);
            Point trianglePoint5 = new Point(4, 6);
            Point trianglePoint6 = new Point(5, 5);
            
            Point circleCenter = new Point(3, 3);
            Point circlePoint = new Point(3, 2);

            List<Figure> figures = new List<Figure>();
            figures.Add(new Square(squareTopLeft, squareBottomRight));
            figures.Add(new Circle(circleCenter, circlePoint));
            figures.Add(new Triangle(trianglePoint1, trianglePoint2, trianglePoint3));
            figures.Add(new Triangle(trianglePoint4, trianglePoint5, trianglePoint6));

            double commonArea = 0;
            foreach (Figure figure in figures)
            {
                commonArea += figure.GetArea();
            }

            Console.WriteLine("Common area of square, circle, triangle1 and triangle2 is:" + commonArea);
        }      
    }
}
