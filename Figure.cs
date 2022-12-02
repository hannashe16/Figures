namespace Figures
{
    internal abstract class Figure: IFigureMover
    {
        public OutlineFigureSettings OutlineFigureSettings { get; set; }
        public FillerFigureSettings FillerFigureSettings { get; set; }
        public Figure(OutlineFigureSettings outlineFigureSettings, FillerFigureSettings fillerFigureSettings)
        {
            OutlineFigureSettings = outlineFigureSettings;
            FillerFigureSettings = fillerFigureSettings;
        }
        public abstract double GetArea();

        public abstract void MoveFigureHorisontallly(double increment);

        public abstract void MoveFigureVertically(double increment);

        public abstract void MoveFigureTo(Point newPoint);
        public override bool Equals(object obj)
        {
            if (obj is Figure)
            {
                Figure figure = obj as Figure;
                return figure.OutlineFigureSettings == OutlineFigureSettings &&
                    figure.FillerFigureSettings == FillerFigureSettings &&                  
                    OutlineFigureSettings.Equals(obj) &&
                    FillerFigureSettings.Equals(obj);
            }
            return false;
        }

        //добавить параметры:  цвет контура, формат линии контура, цвет закраски, паттерн закраски (градиент и т д) (стринг) - отдельными классами
        //переопределить для всех классов переопределить метод equals на сравнение фигур
    }
}
