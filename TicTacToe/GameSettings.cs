namespace GameNamespace
{
    public class GameSettings
    {
        public NamePlayer WhoFirst { get; set; }
        public Rate GameField { get; set; }
        public Rate MaxGameField { get; set; }

        public int WinStrLength { get; set; }
        public int Indents { get; set; }

        public GameSettings()
        {
            MaxGameField = new Rate(5, 5);
            GameField = new Rate(3, 3);
            WinStrLength = 3;
            Indents = 5;
            WhoFirst = NamePlayer.Cross;
        }
        public GameSettings(Rate MaxGameField)
        {
            this.MaxGameField = new Rate(MaxGameField.Width, MaxGameField.Height);
            GameField = new Rate(3, 3);
            WinStrLength = 3;
            Indents = 5;
            WhoFirst = NamePlayer.Cross;
        }
        public GameSettings(GameSettings gameSettings)
        {
            GameField = new Rate(gameSettings.GameField.Width, gameSettings.GameField.Height);
            MaxGameField = new Rate(gameSettings.MaxGameField.Width, gameSettings.MaxGameField.Height);
            //(MaxGameField.Width, MaxGameField.Height) = (gameSettings.MaxGameField.Width, gameSettings.MaxGameField.Height);
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
        /*public Rate(Rate rate)
        {
            this.Width = rate.Width;
            this.Height = rate.Height;
        }*/
        public int Width { get; set;  }
        public int Height { get; set; }

    }
    public enum NamePlayer{
        Cross,
        Сircle,
        Noting
    }
    
}
