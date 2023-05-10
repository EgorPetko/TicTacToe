using System;
using TicTacToe;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePlayButtonNamespace;
using System.Windows.Forms;

namespace GameNamespace
{
    public class Game
    {
        public Form1 form;
        public GameCages gameCages;
        public GameSettings Settings;
        public GameState gameState { get; set; }
        public Game(GameState gameState, Form1 form, List<Control> cages)
        {
            this.gameState = gameState;
            this.form = form;
            
            Settings = new GameSettings();
            gameCages = new GameCages(new NothingState(), form, Settings, cages);
        }
        /*public Game(GameState gameState, Form1 form , List<Control> cages, int widht,int height,int winStrLength)
        {
            this.gameState = gameState;
            this.form = form;
            Settings = new GameSettings(widht, height, winStrLength);!!!!!!!!!!!!!!
            gameCages = new GameCages(new NothingState(), form, Settings, cages);
        }*/
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
            game.gameCages.ReSize();
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
