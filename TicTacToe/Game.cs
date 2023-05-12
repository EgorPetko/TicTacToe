using System;
using TicTacToe;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePlayButtonNamespace;
using System.Windows.Forms;
using System.Drawing;

namespace GameNamespace
{
    public class Game
    {
        public Form1 form;

        public List<GameCage> gameCages;
        public GameSettings settings;
        public GameState gameState { get; set; }
        public NamePlayer namePlayer { get; set; }
        private int[,] logicMatrix;
        private Dictionary<object, (int, int)> cagesDict = new Dictionary<object, (int, int)>();
        public Dictionary<object, GameCage> gameCageByObject = new Dictionary<object, GameCage>();
        public Game(Form1 form, List<Control> cages)
        {
            //this.gameState = gameState;
            this.form = form;
            settings = new GameSettings();
            gameState = new WinWindow();
            namePlayer = NamePlayer.Noting;
            //gameState.NextTurn(this,null);
            GameCagesConstruct(cages);

        }
        private void GameCagesConstruct(List<Control> cages)
        {
            logicMatrix = new int[settings.GameField.Width, settings.GameField.Height];
            int number = 0;
            gameCages = new List<GameCage>();
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                for (int j = 0; j < settings.GameField.Width; j++)
                {
                    if (cages.Count <= number) return;
                    logicMatrix[i, j] = 0;
                    cages[number].Click += Cage_Click;
                    GameCage gameCage = new GameCage(cages[number]);
                    gameCages.Add(gameCage);
                    gameCageByObject[cages[number]] = gameCage;
                    cagesDict[cages[number++]] = (i, j);
                }
            }
            
            /*foreach (Control to in cages)
            {
                gameCages.Add(new GameCage(to));
            }*/
        }
        public void Cage_Click(object sender, EventArgs e)
        {
            var ob = new WinWindow();
            //form.Test(ob.ToString() + " " + gameState.ToString());
            if(gameState.ToString() == ob.ToString()) NextTurn(sender);
            NextTurn(sender);
            NamePlayer whoWin = WhoWin(sender);

            if (NamePlayer.Noting != whoWin)
            {
                Win();
                form.Test("win" + whoWin.ToString());
            }
            else
            {
                bool fl = true;
                foreach(int to in logicMatrix)
                {
                    if (to == 0) fl = false;
                }
                if (fl)
                {
                    clear();
                }
            }

        }
        public bool CheckLogicMatrixByObject(object obj)
        {
            if (logicMatrix[cagesDict[obj].Item1, cagesDict[obj].Item2] == 0) return true;
            return false;
        }
        public void cangeLogicMatrics(object obj,NamePlayer whoPalyer)
        {
            int an = 1;
            if (whoPalyer == NamePlayer.Сircle) an = 2;
            logicMatrix[cagesDict[obj].Item1, cagesDict[obj].Item2] = an;
        }
        public void ReSize()
        {
            Rate sizePanel = new Rate(form.panelCages.Width, form.panelCages.Height);

            int widthCage = (sizePanel.Width - (settings.GameField.Width + 1) * settings.Indents) / settings.GameField.Width;
            int heightCage = (sizePanel.Height - (settings.GameField.Height + 1) * settings.Indents) / settings.GameField.Height;
            int x = 0, y = 0;
            int number = 0;
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                y += settings.Indents;
                for (int j = 0; j < settings.GameField.Width; j++)
                {

                    x += settings.Indents;
                    if (gameCages.Count <= number) return;

                    gameCages[number].CageControl.Location = new Point(x, y);
                    gameCages[number++].CageControl.Size = new Size(widthCage, heightCage);
                    x += widthCage;
                }
                y += heightCage;
                x = 0;
            }
        }
        public NamePlayer WhoWin(object obj)
        {
            NamePlayer whoPlay;
            var IJ = cagesDict[obj];
            int I = IJ.Item1, J = IJ.Item2;
            int w = logicMatrix[I, J],dl = settings.WinStrLength;
            int i = I, j = J,sh = 0;
            if (w == 2) whoPlay = NamePlayer.Сircle;
            else
            if (w == 1) whoPlay = NamePlayer.Cross;
            else whoPlay = NamePlayer.Noting;

            while (i>0&&j>0)
            {
                i--;
                j--;
            }

            while (j < settings.GameField.Width && i < settings.GameField.Height&& logicMatrix[i, j] == w) 
            {
                sh++;
                i++;
                j++;
            }
            if (sh >= dl) return whoPlay;
            i = I; j = J; sh = 0;
            while (i < settings.GameField.Height - 1 && j > 0)
            {
                i++;
                j--;
            }
            while (j < settings.GameField.Width&& i >= 0 && logicMatrix[i, j] == w)
            {
                sh++;
                i--;
                j++;
            }
            if (sh >= dl) return whoPlay;
            i = I; j = J; sh = 0;
            while (i > 0)
            {
                i--;
            }
            while (i < settings.GameField.Height&& logicMatrix[i, j] == w)
            {
                sh++;
                i++;
            }
            if (sh >= dl) return whoPlay;
            i = I; j = J; sh = 0;
            while (j > 0)
            {
                j--;
            }
            while (j < settings.GameField.Width && logicMatrix[i, j] == w)
            {
                sh++;
                j++;
            }
            if (sh >= dl) return whoPlay;
            return NamePlayer.Noting;
        } 
        public void NextTurn(object obj)
        {
            gameState.NextTurn(this,obj);
        }
        public void Win()
        {
            gameState.Win(this,new object());
        }

        public void clear()
        {
            int number = 0;
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                for (int j = 0; j < settings.GameField.Width; j++)
                {
                    if (gameCages.Count <= number) return;
                    logicMatrix[i, j] = 0;
                    gameCages[number++].ClearCage();

                }
            }
            gameState = new WinWindow();
        }
        public void updateScore(NamePlayer whoWin)
        {

        }

    }
    public class GameState
    {
        public virtual void NextTurn(Game game,object obj)
        {
            Console.WriteLine("nothing");
        }
        public virtual void Win(Game game, object obj )
        {
            Console.WriteLine("nothing");
        }

    }

    public class TurnCross : GameState 
    {
        public override void NextTurn(Game game,object obj)
        {
            //game.form.Test("TurnCross");

            //if (!game.CheckLogicMatrixByObject(obj)) return;
            GameCage gameCage = game.gameCageByObject[obj];
            //game.form.Test(obj.ToString() + " " + gameCage.CageControl.ToString() + " " + gameCage.CageState.ToString());
            if (gameCage.whoseCage != NamePlayer.Noting ) return;
            gameCage.DoСircle();
            gameCage.CageControl.BackColor = Color.White;
            game.cangeLogicMatrics(obj, NamePlayer.Cross);
            game.gameState = new TurnСircle();
        }
        public override void Win(Game game, object obj)
        {
            game.gameState = new WinWindow();
            game.clear();
            game.updateScore(NamePlayer.Cross);
        }

    }
    public class TurnСircle : GameState
    {
        public override void NextTurn(Game game, object obj)
        {
            //game.form.Test("TurnСircle");

            //if (!game.CheckLogicMatrixByObject(obj)) return;
            GameCage gameCage = game.gameCageByObject[obj];
            //game.form.Test(obj.ToString() + " " + gameCage.CageControl.ToString());
            if (gameCage.whoseCage != NamePlayer.Noting) return;
            gameCage.DoCross();
            gameCage.CageControl.BackColor = Color.Blue;
            game.cangeLogicMatrics(obj, NamePlayer.Сircle);
            game.gameState = new TurnCross();

        }
        public override void Win(Game game, object obj)
        {
            game.gameState = new WinWindow();
            game.clear();
            game.updateScore(NamePlayer.Сircle);
        }
    }
    public class WinWindow : GameState
    {
        public override void NextTurn(Game game, object obj)
        {
            if (game.settings.WhoFirst == NamePlayer.Cross)
            {
                game.gameState = new TurnCross();
            }
            else
            if (game.settings.WhoFirst == NamePlayer.Сircle) 
            { 
                game.gameState = new TurnСircle(); 
            }
            else
                game.form.Test("result null!!!");
            
        }

    }
}