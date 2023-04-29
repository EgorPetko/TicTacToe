using System;
using TicTacToe;
namespace GamePlayButtonNamespace
{
    public class GameButton
    {
        public Form1 form;
        public GameButtonState buttonState { get; set; }
        public GameButton(GameButtonState gameButtonState, Form1 form)
        {
            this.buttonState = gameButtonState;
            this.form = form;
        }

        public void ClearButton()
        {
            buttonState.ClearButton(this);
        }
        public void DoCross()
        {
            buttonState.DoCross(this);

        }
        public void DoСircle()
        {
            buttonState.DoСircle(this);
        }
    }
    public class GameButtonState
    {
        public virtual void ClearButton(GameButton gameButton)
        {
            Console.WriteLine("nothing");
        }
        public virtual void DoCross(GameButton gameButton)
        {
            Console.WriteLine("nothing");
        }
        public virtual void DoСircle(GameButton gameButton)
        {
            Console.WriteLine("nothing");
        }
    }
    public class CrossState : GameButtonState
    {
        public override void ClearButton(GameButton gameButton)
        {
            Console.WriteLine("thing");
            gameButton.buttonState = new NothingState();
        }
    }
    public class СircleState : GameButtonState
    {
        public override void ClearButton(GameButton gameButton)
        {
            Console.WriteLine("thing");
            gameButton.buttonState = new NothingState();
        }
    }
    public class NothingState : GameButtonState
    {
        public override void DoCross(GameButton gameButton)
        {
            Console.WriteLine("thing");
            gameButton.buttonState = new CrossState();
        }
        public override void DoСircle(GameButton gameButton)
        {
            Console.WriteLine("thing");
            gameButton.buttonState = new СircleState();
        }
    }

}