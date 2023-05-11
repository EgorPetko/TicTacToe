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
    
    public class GameCage
    {
        public Control CageControl;
        public GameCageState CageState { get; set; }
        public GameCage(GameCageState gameCageState, Control control)
        {
            CageControl = control;
            CageState = gameCageState; 
        }
        public GameCage(Control control)
        {
            CageControl = control;
            CageState = new NothingState();
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
        }
    }
    public class СircleState : GameCageState
    {
        public override void ClearCage(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.CageState = new NothingState();
        }
    }
    public class NothingState : GameCageState
    {
        public override void DoCross(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.CageState = new CrossState();
        }
        public override void DoСircle(GameCage gameButton)
        {
            Console.WriteLine("thing");
            gameButton.CageState = new СircleState();
        }
    }

}