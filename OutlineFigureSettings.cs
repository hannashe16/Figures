namespace Figures
{
    internal class OutlineFigureSettings
    {
        public string OutlinePattern { get; set; }
        public string OutlineColor { get; set; }

        public OutlineFigureSettings(string outlinePattern, string outlineColor)
        {
            OutlinePattern = outlinePattern;
            OutlineColor = outlineColor;
        }

        public override bool Equals(object obj)
        {
            if (obj is OutlineFigureSettings)
            {
                OutlineFigureSettings outlineFigureSettings = obj as OutlineFigureSettings;
                return outlineFigureSettings.OutlinePattern == OutlinePattern &&
                    outlineFigureSettings.OutlineColor == OutlineColor;
            }
            return false;
        }
    }
}
