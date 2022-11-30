namespace Figures
{
    internal interface IFigureMover
    {
        void MoveFigureHorisontallly(double increment);
        void MoveFigureVertically(double increment);
        void MoveFigureTo(Point newPoint);
    }
}
