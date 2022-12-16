using System;
using System.Collections.Generic;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(new Point(2, 4), new Point(6, 1), new OutlineFigureSettings("dotted line", "blue"), new FillerFigureSettings("gradient", "white"));

            double squareSize = 2;
            var square = new Square(new Point(2, 4), squareSize, new OutlineFigureSettings("bold line", "red"), new FillerFigureSettings("texture", "red"));

            var triangle1 = new Triangle(new Point(2, 4), new Point(4, 5), new Point(1, 1), new OutlineFigureSettings("thin lineline", "yellow"), new FillerFigureSettings("picture", "red"));
            var triangle2 = new Triangle(new Point(0, 4), new Point(4, 6), new Point(5, 5), new OutlineFigureSettings("dotted line", "purple"), new FillerFigureSettings("no fill", "red"));

            double radius = 1;

            var circle = new Circle(new Point(3, 3), radius, new OutlineFigureSettings("double line", "pink"), new FillerFigureSettings("gradient", "brown"));

            List<Figure> figures = new List<Figure>();
            figures.Add(square);
            figures.Add(circle);
            figures.Add(triangle1);
            figures.Add(triangle2);
            figures.Add(rectangle);

            double commonArea = 0;
            foreach (var figure in figures)
            {
                commonArea += figure.GetArea();
                //(figure as IFigureMover) или через figure.Moveto если по моему
                //figure.MoveFigureVertically(2);
            }
            Console.WriteLine("Common area of square, circle, triangle1 and triangle2 is:" + commonArea);

            // moved figures
            square.MoveFigureVertically(2);
            //circle.MoveFigureTo(new Point(5, 5));
            rectangle.MoveFigureHorisontallly(3);
            triangle1.MoveFigureTo(new Point(5, 1));

            // isEqual
            var circle1 = new Circle(new Point(0, 0), 1, new OutlineFigureSettings("bold line", "red"), new FillerFigureSettings("gradient", "white"));
            var circle2 = new Circle(new Point(0, 0), 1, new OutlineFigureSettings("bold line", "red"), new FillerFigureSettings("gradient", "white"));
            bool res = circle1.Equals(circle2);

            var triangle5 = new Triangle(new Point(2, 7), new Point(4, 5), new Point(1, 1), new OutlineFigureSettings("thin lineline", "black"), new FillerFigureSettings("picture", "black"));
            var triangle6 = new Triangle(new Point(2, 7), new Point(4, 5), new Point(1, 1), new OutlineFigureSettings("thin lineline", "black"), new FillerFigureSettings("picture", "black"));
            bool res2 = triangle5.Equals(triangle6);

            var rectangle1 = new Rectangle(new Point(2, 4), new Point(6, 0), new OutlineFigureSettings("dotted line", "blue"), new FillerFigureSettings("gradient", "white"));
            var rectangle2 = new Rectangle(new Point(2, 4), new Point(6, 0), new OutlineFigureSettings("dotted line", "blue"), new FillerFigureSettings("gradient", "white"));
            bool res3 = rectangle1.Equals(rectangle2);

            var square1 = new Square(new Point(2, 4), 6, new OutlineFigureSettings("bold line", "red"), new FillerFigureSettings("texture", "black"));
            var square2 = new Square(new Point(2, 4), 6, new OutlineFigureSettings("bold line", "red"), new FillerFigureSettings("texture", "black"));
            bool res4 = square1.Equals(square2);

            var redFigures = GetFiguresListByCondition(figures, figure => figure.FillerFigureSettings.FillerColor == "red");
        }

        static List<Figure> GetFiguresListByCondition(List<Figure> figuresList, Func<Figure, bool> condition)
        {
            List<Figure> RedFiguresList = new List<Figure>();
            foreach (var item in figuresList)
            {
                if (condition(item))
                {
                    RedFiguresList.Add(item);
                }
            }
            return RedFiguresList;
        }
    }
}

