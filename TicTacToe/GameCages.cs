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
   /* public delegate void Update(Image image);*/
    
    public class GameCage
    {
        /*public Update UpCross;
        public Update UpCircle;
        public Update UpNoting;*/
        public Image imageCross;
        public Image imageCircle;
        public Image imageNothing;

        public Control CageControl;
        public GameCageState CageState { get; set; }
        public NamePlayer whoseCage = NamePlayer.Noting;
        public GameCage(GameCageState gameCageState, Control control)
        {
            CageControl = control;
            CageState = gameCageState; 
        }
        public GameCage(Control control,Image imageCross, Image imageCircle, Image imageNothing)
        {
            CageControl = control;
            CageState = new NothingState();
            this.imageCross = imageCross;
            this.imageCircle = imageCircle;
            this.imageNothing = imageNothing;
            CageControl.BackgroundImage = imageNothing;
        }
        public GameCage(Control control)
        {
            CageControl = control;
            CageState = new NothingState();
            CageControl.BackColor = Color.Black;
        }
        public void ClearCage()
        {
            CageState.ClearCage(this);
            
        }
        public void DoCross()
        {
            CageState.DoCross(this);

        }
        public void DoСircle()
        {
            CageState.DoСircle(this);
        }
    }
    public class PosSize
    {
        public int height;
        public int wedth;
        public int x;
        public int y;
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
            gameButton.CageState = new NothingState();
            gameButton.CageControl.BackgroundImage = gameButton.imageNothing;
            //gameButton.CageControl.BackColor = Color.Black;
            gameButton.whoseCage = NamePlayer.Noting;
        }
    }
    public class СircleState : GameCageState
    {
        public override void ClearCage(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.CageState = new NothingState();
            gameButton.CageControl.BackgroundImage = gameButton.imageNothing;
            //gameButton.CageControl.BackColor = Color.Black;
            gameButton.whoseCage = NamePlayer.Noting;
        }
    }
    public class NothingState : GameCageState
    {
        public override void DoCross(GameCage gameButton)
        {
            //gameButton.CageControl.BackColor = Color.White;
            gameButton.CageState = new CrossState();
            gameButton.CageControl.BackgroundImage = gameButton.imageCross;
            gameButton.whoseCage = NamePlayer.Cross;
        }
        public override void DoСircle(GameCage gameButton)
        {
            //gameButton.CageControl.BackColor = Color.Black;
            gameButton.CageState = new СircleState();
            gameButton.CageControl.BackgroundImage = gameButton.imageCircle;
            gameButton.whoseCage = NamePlayer.Сircle;
        }
    }

}