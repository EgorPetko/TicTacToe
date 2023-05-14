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

        public List<GameCage> gameCages = new List<GameCage>();
        public GameSettings settings;
        public GameState gameState { get; set; }
        public NamePlayer namePlayer { get; set; }
        private int[,] logicMatrix;
        private Dictionary<object, (int, int)> cagesDict = new Dictionary<object, (int, int)>();
        public Dictionary<object, GameCage> gameCageByObject = new Dictionary<object, GameCage>();
        public Game(Form1 form, List<Control> cages, GameSettings settings)
        {
            //this.gameState = gameState;
            this.form = form;
            this.settings = settings;
            gameState = new WinWindow();
            namePlayer = NamePlayer.Noting;
            //gameState.NextTurn(this,null);
            GameCagesConstruct(cages);

        }
        public void GameCagesConstruct(List<Control> cages)
        {
            logicMatrix = new int[5, 5];
            int number = 0;
            gameCages.Clear();
            //gameCages = new List<GameCage>();
            //form.Test(settings.GameField.Width.ToString() + " " + settings.GameField.Height.ToString());
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                for (int j = 0; j < settings.GameField.Width; j++)
                {
                    //form.Test(i.ToString() + " " + j.ToString());
                    if (cages.Count <= number) return;
                    logicMatrix[i, j] = 0;
                    cages[number].Click += Cage_Click;
                    cages[number].BackgroundImageLayout = ImageLayout.Stretch;
                    cages[number].Text = "";
                    cages[number].Visible = true;
                    var listImage = form.getImages();
                    GameCage gameCage = new GameCage(cages[number], listImage[0], listImage[1], listImage[2]);
                    gameCages.Add(gameCage);
                    gameCageByObject[cages[number]] = gameCage;
                    cagesDict[cages[number++]] = (i, j);
                }
            }
            while (!(cages.Count <= number))
            {
                cages[number++].Visible = false;
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
                //form.Test("win" + whoWin.ToString());
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
            Rate sizePanel = new Rate(form.panelCages.Width, form.panelCages.Height );

            int widthCage = (sizePanel.Width - (settings.GameField.Width + 1) * settings.Indents) / settings.GameField.Width;
            int heightCage = (sizePanel.Height - (settings.GameField.Height + 1) * settings.Indents) / settings.GameField.Height;
            int x = 0, y = 0;
            int number = 0;
            //form.Test(settings.GameField.Width.ToString() + " " + settings.GameField.Height.ToString());
            int sh = 0;
            form.Test(form.panelCages.Width.ToString() + " " + form.panelCages.Height.ToString());
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                y += settings.Indents;
                for (int j = 0; j < settings.GameField.Width; j++)
                {

                    x += settings.Indents;
                    if (gameCages.Count <= number) {form.Test("ReSize"); return; }
                    sh++;
                    gameCages[number].CageControl.Location = new Point(x, y);
                    form.Test(sh.ToString() + " " + x.ToString() + " x y " + y.ToString() + " " + gameCages[number].CageControl.ToString());
                    //form.Test();
                    gameCages[number].CageControl.Visible = true;
                    gameCages[number++].CageControl.Size = new Size(widthCage, heightCage);
                    x += widthCage;
                }
                y += heightCage;
                x = 0;
            }
            while (!(gameCages.Count <= number))
            {
                gameCages[number++].CageControl.Visible = false;
            }
        }
        public NamePlayer WhoWin(object obj)
        {
            NamePlayer whoPlay;
            var IJ = cagesDict[obj];
            int I = IJ.Item1, J = IJ.Item2;
            int w = logicMatrix[I, J],dl = settings.WinStrLength;

            if (w == 2) whoPlay = NamePlayer.Сircle;
            else
            if (w == 1) whoPlay = NamePlayer.Cross;
            else whoPlay = NamePlayer.Noting;
            int sh = 0;
            /*string str = "";
            foreach (int to in logicMatrix)
            {
                str += to.ToString() + " ";
            }
            form.Test(str);*/
            if (detour(1, 1, I, J) || detour(-1, 1, I, J) || detour(1, 0, I, J) || detour(0, 1, I, J)) return whoPlay;


            return NamePlayer.Noting;

            bool detour(int AddI = 0 ,int AddJ = 0, int i = 0,int j = 0)
            {
                int Sh = 0;
                //sh++;
                while (i - AddI >= 0 && j - AddJ >= 0 && j - AddJ < settings.GameField.Width && i - AddI < settings.GameField.Height) 
                {
                    i -= AddI;
                    j -= AddJ;
                }
                //form.Test(i.ToString() + " " + j.ToString());
                //sh++;
                while (i >= 0 && j >= 0 && j < settings.GameField.Width && i < settings.GameField.Height) 
                {
                    //form.Test(i.ToString() + " " + j.ToString());
                    //form.Test(sh.ToString());
                    if (logicMatrix[i, j] == w) Sh++;
                    else if (Sh < dl)
                    {
                        Sh = 0;
                    }
                    i += AddI;
                    j += AddJ;
                }
                if (Sh >= dl) return true;
                return false;
            }
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
        public void again()
        {
            int number = 0;
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                for (int j = 0; j < settings.GameField.Width; j++)
                {
                    if (gameCages.Count <= number) return;
                    logicMatrix[i, j] = 0;
                    //form.Test(gameCages.Count.ToString() + " " + number.ToString());
                    gameCages[number++].ClearCage();

                }
            }
            gameState = new WinWindow();
            form.clearLable();
        }
        public void updateScore(NamePlayer whoWin)
        {
            if(whoWin == NamePlayer.Сircle)
            {
                form.addlable1();
            }
            if (whoWin == NamePlayer.Cross)
            {
                form.addlable2();
            }
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
            //gameCage.CageControl.BackColor = Color.White;
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
            //gameCage.CageControl.BackColor = Color.Blue;
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