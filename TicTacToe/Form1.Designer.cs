namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelCages = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panelSetting = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.panelCages.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelMain.Controls.Add(this.button4);
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.button2);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(314, 527);
            this.panelMain.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(66, 118);
            this.button4.MinimumSize = new System.Drawing.Size(185, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 74);
            this.button4.TabIndex = 3;
            this.button4.Text = "Продолжить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(66, 278);
            this.button3.MinimumSize = new System.Drawing.Size(185, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(66, 198);
            this.button1.MinimumSize = new System.Drawing.Size(185, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Настройки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(66, 38);
            this.button2.MinimumSize = new System.Drawing.Size(185, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 74);
            this.button2.TabIndex = 0;
            this.button2.Text = "Начать новую игру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelGame
            // 
            this.panelGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelGame.Controls.Add(this.panelCages);
            this.panelGame.Controls.Add(this.panel1);
            this.panelGame.Location = new System.Drawing.Point(320, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(851, 387);
            this.panelGame.TabIndex = 3;
            // 
            // panelCages
            // 
            this.panelCages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCages.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCages.Controls.Add(this.button8);
            this.panelCages.Controls.Add(this.button7);
            this.panelCages.Controls.Add(this.button11);
            this.panelCages.Controls.Add(this.button6);
            this.panelCages.Controls.Add(this.button9);
            this.panelCages.Controls.Add(this.button10);
            this.panelCages.Controls.Add(this.button12);
            this.panelCages.Controls.Add(this.button13);
            this.panelCages.Controls.Add(this.button5);
            this.panelCages.Location = new System.Drawing.Point(251, 3);
            this.panelCages.Name = "panelCages";
            this.panelCages.Size = new System.Drawing.Size(590, 381);
            this.panelCages.TabIndex = 10;
            this.panelCages.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panelCages.Resize += new System.EventHandler(this.panelCages_Resize);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.Location = new System.Drawing.Point(147, 179);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 58);
            this.button8.TabIndex = 3;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Location = new System.Drawing.Point(145, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 58);
            this.button7.TabIndex = 2;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.Location = new System.Drawing.Point(208, 179);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 58);
            this.button11.TabIndex = 6;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(268, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 58);
            this.button6.TabIndex = 0;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Location = new System.Drawing.Point(268, 179);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 58);
            this.button9.TabIndex = 4;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.Location = new System.Drawing.Point(268, 115);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(57, 58);
            this.button10.TabIndex = 5;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.Location = new System.Drawing.Point(205, 115);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 58);
            this.button12.TabIndex = 7;
            this.button12.Text = "5";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.Location = new System.Drawing.Point(205, 51);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 58);
            this.button13.TabIndex = 8;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(147, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 58);
            this.button5.TabIndex = 1;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 381);
            this.panel1.TabIndex = 9;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(3, 11);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(152, 41);
            this.button19.TabIndex = 9;
            this.button19.Text = "Начать новую игру";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(3, 105);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(152, 41);
            this.button14.TabIndex = 2;
            this.button14.Text = "в главное меню";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(3, 58);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(152, 41);
            this.button16.TabIndex = 0;
            this.button16.Text = "сначала";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "круг.png");
            this.imageList2.Images.SetKeyName(1, "Кр.png");
            this.imageList2.Images.SetKeyName(2, "Nothing.png");
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelSetting.Controls.Add(this.radioButton2);
            this.panelSetting.Controls.Add(this.textBox3);
            this.panelSetting.Controls.Add(this.label5);
            this.panelSetting.Controls.Add(this.textBox2);
            this.panelSetting.Controls.Add(this.label4);
            this.panelSetting.Controls.Add(this.label3);
            this.panelSetting.Controls.Add(this.textBox1);
            this.panelSetting.Controls.Add(this.radioButton1);
            this.panelSetting.Controls.Add(this.button18);
            this.panelSetting.Controls.Add(this.button17);
            this.panelSetting.Controls.Add(this.button15);
            this.panelSetting.Location = new System.Drawing.Point(320, 268);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(882, 187);
            this.panelSetting.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.radioButton2.Checked = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(3, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Крестики ходят первые";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Длина необходимая для победны";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "3";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Высота игрового поля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ширина игрового поля";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "3";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(168, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Нолики ходят первые";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Location = new System.Drawing.Point(324, 108);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(243, 76);
            this.button18.TabIndex = 2;
            this.button18.Text = "в главное меню";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Location = new System.Drawing.Point(730, 108);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(149, 76);
            this.button17.TabIndex = 1;
            this.button17.Text = "по умолчанию";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button15.Location = new System.Drawing.Point(3, 108);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(115, 76);
            this.button15.TabIndex = 0;
            this.button15.Text = "сохранить";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 527);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(1024, 516);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMain.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.panelCages.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        System.Windows.Forms.Panel panelMain;
        System.Windows.Forms.Button button2;
        System.Windows.Forms.Button button4;
        System.Windows.Forms.Button button3;
        System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panelGame;
        public System.Windows.Forms.Panel panelCages;
        System.Windows.Forms.Button button8;
        System.Windows.Forms.Button button7;
        System.Windows.Forms.Button button11;
        System.Windows.Forms.Button button6;
        System.Windows.Forms.Button button9;
        System.Windows.Forms.Button button10;
        System.Windows.Forms.Button button12;
        System.Windows.Forms.Button button13;
        System.Windows.Forms.Button button5;
        System.Windows.Forms.Panel panel1;
        System.Windows.Forms.Button button14;
        System.Windows.Forms.Button button16;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button19;
    }
}

