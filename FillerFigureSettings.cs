namespace Figures
{
    internal class FillerFigureSettings
    {
        public string FillerPattern { get; set; }
        public string FillerColor { get; set; }
        public FillerFigureSettings(string fillerPattern, string fillerColor)
        {
            FillerPattern = fillerPattern;
            FillerColor = fillerColor;
        }
        public override bool Equals(object obj)
        {            
            if (obj is FillerFigureSettings)
            {
                FillerFigureSettings fillerFigureSettings = obj as FillerFigureSettings;
                return fillerFigureSettings.FillerPattern == FillerPattern &&
                    fillerFigureSettings.FillerColor == FillerColor;
            }
            return false;
        }
    }   
}
