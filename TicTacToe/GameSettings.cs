namespace GameNamespace
{
    public class GameSettings
    {
        public NamePlayer WhoFirst = new NamePlayer();
        public Rate GameField;
        public int WinStrLength;
        public int Indents;
        public GameSettings(int width = 3 , int height = 3, int winStrLength = 3, int indents = 5)
        {
            GameField = new Rate(width, height);
            WinStrLength = winStrLength;
            Indents = indents;
            WhoFirst = NamePlayer.Cross;
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
        Сircle
    }
}
