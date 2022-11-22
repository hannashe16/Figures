using System;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point rectangleTopLeft = new Point(2,4);
            Point rectangleBottomRight = new Point(6,1);
            Rectangle rectangle = new Rectangle(rectangleTopLeft, rectangleBottomRight);
            double rectangleArea = rectangle.GetArea();

            Point squareTopLeft = new Point(2, 4);
            Point squareBottomRight = new Point(5,1);
            Square square = new Square(squareTopLeft, squareBottomRight);
            double squareArea = square.GetArea();

            Point trianglePoint1 = new Point(2, 4);
            Point trianglePoint2 = new Point(4, 5);
            Point trianglePoint3 = new Point(1, 1);

            Point trianglePoint4 = new Point(0, 4);
            Point trianglePoint5 = new Point(4, 6);
            Point trianglePoint6 = new Point(5, 5);

            Triangle triangle1 = new Triangle(trianglePoint1, trianglePoint2, trianglePoint3);
            Triangle triangle2 = new Triangle(trianglePoint4, trianglePoint5, trianglePoint6);

            double triangleArea1 = triangle1.GetArea();
            double triangleArea2 = triangle2.GetArea();
            
            Point circleCenter = new Point(3, 3);
            Point circlePoint = new Point(3, 2);
            Circle circle = new Circle(circleCenter, circlePoint);
            double circleArea = circle.GetArea();

            Figure[] figures = new Figure[4];
            figures[0] = square;
            figures[1] = circle;
            figures[2] = triangle1;
            figures[3] = triangle2;

            double commonArea = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                commonArea += figures[i].GetArea();
            }
            Console.WriteLine("Common area of square, circle, triangle1 and triangle2 is:" + commonArea);
        }      
    }
}
