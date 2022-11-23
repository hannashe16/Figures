using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            Point squareBottomRight = new Point(5, 1);
            Square square = new Square(squareTopLeft, squareBottomRight);

           
            Point trianglePoint1 = new Point(2, 4);
            Point trianglePoint2 = new Point(4, 5);
            Point trianglePoint3 = new Point(1, 1);
            Triangle triangle1 = new Triangle(trianglePoint1, trianglePoint2, trianglePoint3);

            Point trianglePoint4 = new Point(0, 4);
            Point trianglePoint5 = new Point(4, 6);
            Point trianglePoint6 = new Point(5, 5);
            Triangle triangle2 = new Triangle(trianglePoint4, trianglePoint5, trianglePoint6);


            Point circleCenter = new Point(3, 3);
            Point circlePoint = new Point(3, 2);
            Circle circle = new Circle(circleCenter, circlePoint);

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
           
            // List of Points moved square
            List<Point> pointsOfSquareMovedRight = new List<Point>();
            List<Point> pointsOfSquareMovedLeft = new List<Point>();
            List<Point> pointsOfSquareMovedUp = new List<Point>();
            List<Point> pointsOfSquareMovedDown = new List<Point>();
            foreach (Point point in square.GetListOfPoints())
            {
                pointsOfSquareMovedRight.Add(square.MoveRight(point, 1));
                pointsOfSquareMovedLeft.Add(square.MoveLeft(point, 3));
                pointsOfSquareMovedUp.Add(square.MoveUp(point, 5));
                pointsOfSquareMovedDown.Add(square.MoveDown(point, 2));
            }
            Console.WriteLine("Square moved right: " + pointsOfSquareMovedRight +
                "\nSquare moved left: " + pointsOfSquareMovedLeft +
                "\nSquare moved up: " + pointsOfSquareMovedUp +
                "\nSquare moved down: " + pointsOfSquareMovedDown);

            // List of Points moved Rectangle
            List<Point> pointsOfRectangleMovedRight = new List<Point>();
            List<Point> pointsOfRectangleMovedLeft = new List<Point>();
            List<Point> pointsOfRectangleMovedUp = new List<Point>();
            List<Point> pointsOfRectangleMovedDown = new List<Point>();
            foreach (Point point in rectangle.GetListOfPoints())
            {
                pointsOfRectangleMovedRight.Add(rectangle.MoveRight(point, 2));
                pointsOfRectangleMovedLeft.Add(rectangle.MoveLeft(point, 3));
                pointsOfRectangleMovedUp.Add(rectangle.MoveUp(point, 1));
                pointsOfRectangleMovedDown.Add(rectangle.MoveDown(point, 4.5));
            }
            Console.WriteLine("Rectangle moved right: " + pointsOfRectangleMovedRight +
                "\nRectangle moved left: " + pointsOfRectangleMovedLeft +
                "\nRectangle moved up: " + pointsOfRectangleMovedUp +
                "\nRectangle moved down: " + pointsOfRectangleMovedDown);

            //List of Points moved Circle
            List<Point> pointsOfCircleMovedRight = new List<Point>();
            List<Point> pointsOfCircleMovedLeft = new List<Point>();
            List<Point> pointsOfCircleMovedUp = new List<Point>();
            List<Point> pointsOfCircleMovedDown = new List<Point>();
            foreach (Point point in circle.GetListOfPoints())
            {
                pointsOfCircleMovedRight.Add(circle.MoveRight(point, 5));
                pointsOfCircleMovedLeft.Add(circle.MoveLeft(point, 6));
                pointsOfCircleMovedUp.Add(circle.MoveUp(point, 7));
                pointsOfCircleMovedDown.Add(circle.MoveDown(point, 8));
            }
            Console.WriteLine("Circle moved right: " + pointsOfCircleMovedRight +
                "\nCircle moved left: " + pointsOfCircleMovedLeft +
                "\nCircle moved up: " + pointsOfCircleMovedUp +
                "\nCircle moved down: " + pointsOfCircleMovedDown);

            //List of Points moved Triangle
            List<Point> pointsOfTriangleMovedRight = new List<Point>();
            List<Point> pointsOfTriangleMovedLeft = new List<Point>();
            List<Point> pointsOfTriangleMovedUp = new List<Point>();
            List<Point> pointsOfTriangleMovedDown = new List<Point>();
            foreach (Point point in triangle1.GetListOfPoints())
            {
                pointsOfTriangleMovedRight.Add(triangle1.MoveRight(point, 1));
                pointsOfTriangleMovedLeft.Add(triangle1.MoveLeft(point, 9));
                pointsOfTriangleMovedUp.Add(triangle1.MoveUp(point, 6));
                pointsOfTriangleMovedDown.Add(triangle1.MoveDown(point, 4.87));
            }
            Console.WriteLine("Triangle moved right: " + pointsOfTriangleMovedRight + 
                "\nTriangle moved left: " + pointsOfTriangleMovedLeft + 
                "\nTriangle moved up: " + pointsOfTriangleMovedUp + 
                "\nTriangle moved down: " + pointsOfTriangleMovedDown);
        }
    }
}
