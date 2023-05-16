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
        List<Control> Cages;
        public ProgramState programState { get; set; }
        string fileName = "D:\\Projects\\TicTacToe\\TicTacToe\\Setting.json";
        //string fileTest = "D:\\Projects\\TicTacToe\\TicTacToe\\Test.json";
        public Form1()
        {
            InitializeComponent();
            //Test("wtf");
            //string str = File.ReadAllText(fileName);
            Button buttons = new Button();
            //CloseMainMenu();
            //panelGame.Controls.Add(buttons);
            GameSettings setting = JsonSerializer.Deserialize<GameSettings>(File.ReadAllText(fileName));
            
            if(setting.WhoFirst == NamePlayer.Cross)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
            //Test("wtf");
            textBox1.Text = setting.GameField.Width.ToString();
            textBox2.Text = setting.GameField.Height.ToString();
            textBox3.Text = setting.WinStrLength.ToString();
            //Test(str);
            Cages = new List<Control>();
            foreach (Control con in panelCages.Controls)
            {
                Cages.Add(con);
            }

            gameSettings = new GameSettings(setting);
            game = new Game(this, Cages,setting);
            //Test("wtf");
            panelMain.Size = this.Size;
            panelGame.Visible = false;
            panelSetting.Visible = false;
            button4.Visible = false;
            swap(button4, button1);
            swap(button4, button3);
            var button = new Button();
            panelGame.Dock = DockStyle.Fill;
            panelSetting.Dock = DockStyle.Fill;
            panelMain.Dock = DockStyle.Fill;
            addCages();
            game.ReSize();
            programState = new MainMenuState();
            //Test("wtf");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            game.again();
            StartGame();
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
            if (result != DialogResult.OK) return true;
            if (game != null)
            {
                //if (game.NeedSave != game.settings) Test("norm");
                //if (game.NeedSave != game.settings) Test("norm");
                //if (game.NeedSave != gameSettings) Test("norm+");
                //else Test("not");
                string str = JsonSerializer.Serialize(game.NeedSave);

                File.WriteAllText(fileName, str);
                /*str = JsonSerializer.Serialize(game.settings);
                Test(str);
                str = JsonSerializer.Serialize(gameSettings);
                Test(str);
                str = JsonSerializer.Serialize(game.NeedSave);
                Test(str);*/
            }
            return false;
        }

        public void CloseMainMenu()
        {
            panelMain.Visible = false;
        }
        public void CloseGameMenu()
        {
            //addCages();
            panelGame.Visible = false;
        }
        public void CloseSettingMenu()
        {
            panelSetting.Visible = false;
        }
        public void OpenMainMenu()
        {
            //addCages();
            panelMain.Visible = true;
            if ((!(game.gameState is WinWindow) || (label1.Text != label2.Text || label1.Text != "0")))
            {
                if (button4.Visible == true) return;
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
            //addCages();
            panelGame.Visible = true;
        }
        public void OpenSettingMenu()
        {
            updatePanelSettings(game.NeedSave);
            panelSetting.Visible = true;
        }
        public void addCages()
        {
            //if (Cages.Count >= game.settings.GameField.Width * game.settings.GameField.Height) return;
            while (Cages.Count < game.settings.GameField.Width * game.settings.GameField.Height)
            {
                Button buttons = new Button();
                buttons.Visible = true;
                buttons.BackColor = Color.LightGray;
                buttons.ForeColor = Color.DarkGray;
                buttons.Location = new Point(10, 10);
                buttons.Text = "Привет";

                panelCages.Controls.Add(buttons);
                Cages.Add(buttons);

            }
            game.GameCagesConstruct(Cages);
            //game.gameState = new WinWindow();

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
            game.clear();
            addCages();
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
            //Test("wtf");
            game.NeedSave = new GameSettings(gameSettings);
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
            if (game == null) return;
            bool fl = int.TryParse(textBox1.Text,out int kol);
            if (!fl) return;
            if (kol > 0 && kol <= game.NeedSave.MaxGameField.Width)
            {
                gameSettings.GameField.Width = kol;
            }
            else if (kol > game.NeedSave.MaxGameField.Width)
            {
                textBox1.Text = game.NeedSave.MaxGameField.Width.ToString();
            }
            else
            {
                textBox1.Text = "1";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (game == null) return;
            bool fl = int.TryParse(textBox2.Text, out int kol);
            if (!fl) return;
            if (kol > 0 && kol <= game.NeedSave.MaxGameField.Height)
            {
                gameSettings.GameField.Height = kol;
            }
            else if (kol > game.NeedSave.MaxGameField.Height)
            {
                textBox2.Text = game.NeedSave.MaxGameField.Height.ToString();
            }
            else
            {
                textBox2.Text = "1";
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (game == null) return;
            bool fl = int.TryParse(textBox3.Text, out int kol);
            if (!fl) return;
            int MaxGameField = Math.Max(game.NeedSave.GameField.Width, game.NeedSave.GameField.Height);
            if (kol > 0 && kol <=MaxGameField)
            {
                gameSettings.WinStrLength = kol;
            }
            else if (kol > MaxGameField)
            {
                textBox3.Text = MaxGameField.ToString();
            }
            else
            {
                textBox3.Text = "1";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            //Test("wtf");
            game.NeedSave = new GameSettings(game.settings.MaxGameField);
            //game.NeedSave = new GameSettings();
            //Test("wtf");
            gameSettings = new GameSettings(game.NeedSave);
            //Test("wtf");
            updatePanelSettings(game.NeedSave);
            //Test("wtf");
        }
        private void updatePanelSettings(GameSettings settings)
        {
            //if (settings == null) return;

            if(settings.WhoFirst == NamePlayer.Cross)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
            textBox1.Text = settings.GameField.Width.ToString();
            textBox2.Text = settings.GameField.Height.ToString();
            textBox3.Text = settings.WinStrLength.ToString();
            /////////////+-asd ;lkjhgfdsa
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            game.again();
            EndGame();
            StartGame();
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

