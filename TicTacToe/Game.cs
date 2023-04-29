using System;
using TicTacToe;
using GamePlayButtonNamespace;

namespace GameNamespace
{
    public class Game
    {
        public Form1 form;
        public GameState gameState { get; set; }
        public Game(GameState gameState, Form1 form)
        {
            this.gameState = gameState;
            this.form = form;
        }

        public void StartGame()
        {
            gameState.StartGame(this);
        }
        public void EndGame()
        {
            gameState.EndGame(this);
        }
    }
    public class GameState
    {
        public virtual void StartGame(Game game)
        {
            Console.WriteLine("nothing");
        }
        public virtual void EndGame(Game game)
        {
            Console.WriteLine("nothing");
        }
    }
    public class MainMenuState : GameState
    {
        public override void StartGame(Game game)
        {
            Console.WriteLine("thing");
            game.form.CloseMainMenu();
            game.form.OpenGameMenu();
            game.gameState = new PlayGameState();
        }
    }
    public class PlayGameState : GameState
    {
        public override void EndGame(Game game)
        {
            Console.WriteLine("thing");
            game.form.OpenMainMenu();
            game.form.CloseGameMenu();
            game.gameState = new MainMenuState();

        }
    }

}
namespace GamePlayButtonNamespace
{
    /*
    public class GameState
    {
        public virtual void StartGame(Game game)
        {
            Console.WriteLine("nothing");
        }
        public virtual void EndGame(Game game)
        {
            Console.WriteLine("nothing");
        }
    }
    public class MainMenuState : GameState
    {
        public override void StartGame(Game game)
        {
            Console.WriteLine("thing");
            game.form.CloseMainMenu();
            game.form.OpenGameMenu();
            game.gameState = new PlayGameState();
        }
    }
    public class PlayGameState : GameState
    {
        public override void EndGame(Game game)
        {
            Console.WriteLine("thing");
            game.form.OpenMainMenu();
            game.form.CloseGameMenu();
            game.gameState = new MainMenuState();

        }
    }*/

}