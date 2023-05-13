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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Game game;
        public ProgramState programState { get; set; }
        string fileName = "D:\\Projects\\TicTacToe\\TicTacToe\\Setting.json";
        public Form1()
        {
            InitializeComponent();
            //string str = File.ReadAllText(fileName);
            GameSettings setting = JsonSerializer.Deserialize<GameSettings>(File.ReadAllText(fileName));
            //Test(str);
            List<Control> Cages = new List<Control>();
            foreach (Control con in panelCages.Controls)
            {
                Cages.Add(con);
            }
            game = new Game(this, Cages,setting);
            panelMain.Size = this.Size;
            panelGame.Visible = false;
            panelSetting.Visible = false;
            button4.Visible = false;
            swap(button4, button1);
            swap(button4, button3);
            var button = new Button();
            panelGame.Dock = DockStyle.Fill;
            panelSetting.Dock = DockStyle.Fill;

            game.ReSize();
            programState = new MainMenuState();
            //game.settings.Indents = 4;
            gameSettings = game.settings;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
            game.again();
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
        public void CloseSettingMenu()
        {
            panelSetting.Visible = false;
        }
        public void OpenMainMenu()
        {
            panelMain.Visible = true;
            if ((!(game.gameState is WinWindow) || (label1.Text != label2.Text || label1.Text != "0"))&& button4.Visible == false)
            {
                button4.Visible = true;
                swap(button4, button3);
                swap(button4, button1);

            }
            else if(button4.Visible == true)
            {
                button4.Visible = false;
                swap(button4, button1);
                swap(button4, button3);
            }
        }
        public void OpenGameMenu()
        {
            panelGame.Visible = true;
        }
        public void OpenSettingMenu()
        {
            panelSetting.Visible = true;
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
        public void StartSetting()
        {
            programState.StartSetting(this);
        }
        public void EndSetting()
        {
            programState.EndSetting(this);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            game.again();
            //game.gameState = new WinWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var ob = new NothingState();
            //this.Test("" + game.gameState.ToString() + " " + ob.ToString());
            if (!(game.gameState is WinWindow)||(label1.Text != label2.Text || label1.Text != "0"))
            {
                StartGame();
            }
            //var Tn = imageList2.Images[0];
        }
        public void clearLable()
        {
            label1.Text = "0";
            label2.Text = "0";
        }
        public void addlable1()
        {
            int sh = int.Parse(label1.Text);
            sh++;
            label1.Text = sh.ToString();
        }
        public void addlable2()
        {
            int sh = int.Parse(label2.Text);
            sh++;
            label2.Text = sh.ToString();
            
        }
        public List<Image> getImages() 
        {
            List<Image> list = new List<Image>();
            foreach(Image img in imageList2.Images)
            {
                list.Add(img);
            }
            return list;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartSetting();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            EndSetting();
        }
        
        public void swap(Control control1, Control control2)
        {
            (control1.Location, control2.Location) = (control2.Location, control1.Location);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //game.settings
            string str = JsonSerializer.Serialize(game.settings);
            File.WriteAllText(fileName, str);

        }
        GameSettings gameSettings = new GameSettings();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gameSettings.WhoFirst = NamePlayer.Сircle;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gameSettings.WhoFirst = NamePlayer.Cross;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool fl = int.TryParse(textBox1.Text,out int kol);
            if (!fl) return;
            if (kol > 0 && kol < 5)
            {
                gameSettings.GameField.Width = kol;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool fl = int.TryParse(textBox1.Text, out int kol);
            if (!fl) return;
            if (kol > 0 && kol < 5)
            {
                gameSettings.GameField.Height = kol;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool fl = int.TryParse(textBox1.Text, out int kol);
            if (!fl) return;
            if (kol > 0 && kol < 5)
            {
                gameSettings.WinStrLength = kol;
            }
        }
    }

    public class ProgramState
    {
        public virtual void StartGame(Form1 form)
        {

        }
        public virtual void EndGame(Form1 form)
        {

        }
        public virtual void EndSetting(Form1 form)
        {

        }
        public virtual void StartSetting(Form1 form)
        {

        }
    }
    public class MainMenuState : ProgramState
    {
        public override void StartGame(Form1 form)
        {
            form.CloseMainMenu();
            form.OpenGameMenu();
            form.game.ReSize();
            form.programState = new PlayGameState();
        }
        public override void StartSetting(Form1 form)
        {
            /*form.CloseMainMenu();
            form.OpenGameMenu();
            
            form.game.ReSize();*/
            form.OpenSettingMenu();
            form.CloseMainMenu();
            form.programState = new SettingGameState();
        }
    }
    public class PlayGameState : ProgramState
    {
        public override void EndGame(Form1 form)
        {
            form.OpenMainMenu();
            form.CloseGameMenu();
            form.programState = new MainMenuState();

        }
    }
    public class SettingGameState : ProgramState
    {
        public override void EndSetting(Form1 form)
        {
            form.OpenMainMenu();
            form.CloseSettingMenu();
            form.programState = new MainMenuState();
        }
    }
}

