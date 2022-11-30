using System;
using System.Collections.Generic;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(new Point(2, 4), new Point(6, 1));

            double squareSize = 2;
            Square square = new Square(new Point(2, 4), squareSize);

            Triangle triangle1 = new Triangle(new Point(2, 4), new Point(4, 5), new Point(1, 1));
            Triangle triangle2 = new Triangle(new Point(0, 4), new Point(4, 6), new Point(5, 5));

            double radius = 1;
            Circle circle = new Circle(new Point(3, 3), radius);

            List<Figure> figures = new List<Figure>();
            figures.Add(square);
            figures.Add(circle);
            figures.Add(triangle1);
            figures.Add(triangle2);

            double commonArea = 0;
            foreach (Figure figure in figures)
            {
                commonArea += figure.GetArea();
            }
            Console.WriteLine("Common area of square, circle, triangle1 and triangle2 is:" + commonArea);

            // moved figures
            square.MoveFigureVertically(2);
            circle.MoveFigureTo(new Point(5, 5));
            rectangle.MoveFigureHorisontallly(3);
            triangle1.MoveFigureTo(new Point(5, 1));
        }
    }
}
