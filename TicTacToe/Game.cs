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

        private int[,] logicMatrix;
        private Dictionary<object, (int, int)> cagesDict = new Dictionary<object, (int, int)>();
        public Dictionary<object, GameCage> gameCageByObject = new Dictionary<object, GameCage>();
        public Game(Form1 form, List<Control> cages)
        {
            //this.gameState = gameState;
            this.form = form;
            settings = new GameSettings();
            gameState = new WinWindow();
            gameState.NextTurn(this,null);
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
            NextTurn(sender);
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
        public virtual void NextTurn(object obj)
        {
            gameState.NextTurn(this,obj);
        }
        public virtual void Win()
        {
            gameState.Win(this,new object());
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
            if (!game.CheckLogicMatrixByObject(obj)) return;
            GameCage gameCage = game.gameCageByObject[obj];
            gameCage.CageControl.BackColor = Color.Black;
            game.cangeLogicMatrics(obj, NamePlayer.Cross);
            game.gameState = new TurnСircle();

        }
        public override void Win(Game game, object obj)
        {
            game.gameState = new WinWindow();
        }

    }
    public class TurnСircle : GameState
    {
        public override void NextTurn(Game game, object obj)
        {
            if (!game.CheckLogicMatrixByObject(obj)) return;
            GameCage gameCage = game.gameCageByObject[obj];
            gameCage.CageControl.BackColor = Color.Blue;
            game.cangeLogicMatrics(obj, NamePlayer.Сircle);
            game.gameState = new TurnCross();
        }
        public override void Win(Game game, object obj)
        {
            game.gameState = new WinWindow();
        }
    }
    public class WinWindow : GameState
    {
        public override void NextTurn(Game game, object obj)
        {
            if (game.settings.WhoFirst == NamePlayer.Cross) game.gameState = new TurnCross();
            else
            if (game.settings.WhoFirst == NamePlayer.Сircle) game.gameState = new TurnСircle();
            else
                game.form.Test("result null!!!");

        }

    }
}