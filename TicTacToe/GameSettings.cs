namespace GameNamespace
{
    public class GameSettings
    {
        public NamePlayer WhoFirst { get; set; }
        public Rate GameField { get; set; }
        public int WinStrLength { get; set; }
        public int Indents { get; set; }

        public GameSettings()
        {
            GameField = new Rate(3, 3);
            WinStrLength = 3;
            Indents = 5;
            WhoFirst = NamePlayer.Cross;
        }
        public GameSettings(GameSettings gameSettings)
        {
            GameField = gameSettings.GameField;
            WinStrLength = gameSettings.WinStrLength;
            Indents = gameSettings.Indents;
            WhoFirst = gameSettings.WhoFirst;
        }
    }
    public class Rate
    {
        public Rate(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width { get; set;  }
        public int Height { get; set; }

    }
    public enum NamePlayer{
        Cross,
        Сircle,
        Noting
    }
    
}
