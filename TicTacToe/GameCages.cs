using System;
using System.Windows.Forms;
using TicTacToe;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameNamespace;
using System.Drawing;

namespace GamePlayButtonNamespace
{
    public class GameCages
    {
        public Form1 form;
        public GameSettings settings;
        public List<Control> cages;
        public int[,] logicMatrix;
        public List<GameCage> Cages;
        private Dictionary<Control, (int, int)> cagesDict = new Dictionary<Control, (int, int)>();
        public GameCages(GameCageState gameCageState, Form1 form, GameSettings settings, List<Control> cages)
        {
            //this.cageState = gameCageState;
            this.form = form;
            this.settings = settings;
            this.cages = cages;
            logicMatrix = new int[settings.GameField.Width, settings.GameField.Height];
            int number = 0;
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                for(int j=0; j < settings.GameField.Width; j++)
                {
                    if (cages.Count <= number) return;
                    logicMatrix[i, j] = 0;
                    cages[number].Click += Cage_Click;
                    cagesDict[cages[number++]] = (i, j);
                }
            }
            //Cages = new List<GameCage>();
            //GameCage C = new GameCage();
        }
        public void Cage_Click(object sender, EventArgs e)
        {

        }
        public void ReSize()
        {
            Rate sizePanel = new Rate(form.panelCages.Width, form.panelCages.Height);
    
            int widthCage = (sizePanel.Width - (settings.GameField.Width + 1) * settings.Indents)/settings.GameField.Width;
            int heightCage = (sizePanel.Height - (settings.GameField.Height + 1) * settings.Indents)/settings.GameField.Height;
            int x = 0, y = 0;
            int number = 0;
            //form.Test(heightCage.ToString() + " " + sizePanel.Height.ToString());
            for (int i = 0; i < settings.GameField.Height; i++)
            {
                //form.Test("aa");
                y += settings.Indents;
                for (int j = 0; j < settings.GameField.Width; j++)
                {

                    x += settings.Indents;
                    if (cages.Count <= number) return;
                    
                    cages[number].Location= new Point(x, y);
                    cages[number++].Size = new Size(widthCage, heightCage);
                   x += widthCage;
                }
                //form.Test(y.ToString());
                y += heightCage;
                x = 0;
            }
        }

       

    }
    public class GameCageState
    {
        public virtual void ClearCage(GameCage gameButton)
        {
            Console.WriteLine("nothing");
        }
        public virtual void DoCross(GameCage gameButton)
        {
            Console.WriteLine("nothing");
        }
        public virtual void DoСircle(GameCage gameButton)
        {
            Console.WriteLine("nothing");
        }
    }
    public class CrossState : GameCageState
    {
        public override void ClearCage(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.cageState = new NothingState();
        }
    }
    public class СircleState : GameCageState
    {
        public override void ClearCage(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.cageState = new NothingState();
        }
    }
    public class NothingState : GameCageState
    {
        public override void DoCross(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.cageState = new CrossState();
        }
        public override void DoСircle(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.cageState = new СircleState();
        }
    }
    public class GameCage
    {
        Control cageControl;
        public GameCageState cageState { get; set; }
        /*public GameCage(GameCageState gameCageState, Control control)
        {

        }*/
        public void ClearCage()
        {
            cageState.ClearCage(this);
        }
        public void DoCross()
        {
            cageState.DoCross(this);

        }
        public void DoСircle()
        {
            cageState.DoСircle(this);
        }
    }
    /*public class PosSize
    {
        public int height;
        public int wedth;
        public int x;
        public int y;
    }*/
}