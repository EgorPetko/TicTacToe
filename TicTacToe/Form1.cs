using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameNamespace;
using GamePlayButtonNamespace;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Game game;
        public ProgramState programState { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            List<Control> Cages = new List<Control>();
            foreach (Control con in panelCages.Controls)
            {
                Cages.Add(con);
            }
            game = new Game(this, Cages);
            panelMain.Size = this.Size;
            panelGame.Visible = false;
            var button = new Button();
            panelGame.Dock = DockStyle.Fill;
            //Cages = panelCages.Controls.ToString;
            /*foreach (var cage in panelCages.Controls)
            {
                Cages.Add(cage);
            }*/
            //panelCages.Controls.Cast();
            //Test(panelCages.Controls.ToString());

            game.ReSize();
            programState = new MainMenuState();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
            game.clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //CloseForm();
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = trueClose();
        }
        private bool trueClose()
        {
            var result = MessageBox.Show("Вы действительно хотите закрыть программу?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) return false;
            return true;
        }

        public void CloseMainMenu()
        {
            panelMain.Visible = false;
        }
        public void CloseGameMenu()
        {
            panelGame.Visible = false;
        }
        public void OpenMainMenu()
        {
            panelMain.Visible = true;
        }
        public void OpenGameMenu()
        {
            panelGame.Visible = true;
        }
        public void Test(string s)
        {
            MessageBox.Show(s);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCages_Resize(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
            if (game == null) return;
            
            if (game.gameCages != null)
            {
                //Test("sd");
                game.ReSize();

            }
        }
        public void StartGame()
        {
            programState.StartGame(this);
        }
        public void EndGame()
        {
            programState.EndGame(this);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            game.clear();
            //game.gameState = new WinWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var ob = new NothingState();
            //this.Test("" + game.gameState.ToString() + " " + ob.ToString());
            if (!(game.gameState is WinWindow))
            {
                StartGame();
            }
        }
    }

    public class ProgramState
    {
        public virtual void StartGame(Form1 form)
        {
            Console.WriteLine("nothing");
        }
        public virtual void EndGame(Form1 form)
        {
            Console.WriteLine("nothing");
        }
    }
    public class MainMenuState : ProgramState
    {
        public override void StartGame(Form1 form)
        {
            Console.WriteLine("thing");

            form.CloseMainMenu();
            form.OpenGameMenu();
            form.game.ReSize();
            form.programState = new PlayGameState();
        }
    }
    public class PlayGameState : ProgramState
    {
        public override void EndGame(Form1 form)
        {
            Console.WriteLine("thing");
            form.OpenMainMenu();
            form.CloseGameMenu();
            form.programState = new MainMenuState();

        }
    }
}

