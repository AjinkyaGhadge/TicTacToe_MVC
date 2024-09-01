using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicTacToe_2
{
    partial class GameView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameGrid = new TableLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ActionButtonGrid = new TableLayoutPanel();
            StatusLabel = new Label();
            PlayButton = new Button();
            LowerLayout = new TableLayoutPanel();
            Player2NameBox = new TextBox();
            Player2NameLabel = new Label();
            Player1Label = new Label();
            Player1NameBox = new TextBox();
            AIPlayerGroupBox = new GroupBox();
            Player2CheckBox = new CheckBox();
            Player1CheckBox = new CheckBox();
            menuStrip1 = new MenuStrip();
            Options = new ToolStripMenuItem();
            ChangeThemeMenu = new ToolStripMenuItem();
            AIDifficultyComboBox = new ToolStripComboBox();
            GameGrid.SuspendLayout();
            ActionButtonGrid.SuspendLayout();
            LowerLayout.SuspendLayout();
            AIPlayerGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GameGrid
            // 
            GameGrid.ColumnCount = 3;
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.Controls.Add(button9, 2, 2);
            GameGrid.Controls.Add(button8, 1, 2);
            GameGrid.Controls.Add(button7, 0, 2);
            GameGrid.Controls.Add(button6, 2, 1);
            GameGrid.Controls.Add(button5, 1, 1);
            GameGrid.Controls.Add(button4, 0, 1);
            GameGrid.Controls.Add(button3, 2, 0);
            GameGrid.Controls.Add(button2, 1, 0);
            GameGrid.Controls.Add(button1, 0, 0);
            GameGrid.Location = new Point(17, 38);
            GameGrid.Margin = new Padding(4, 5, 4, 5);
            GameGrid.Name = "GameGrid";
            GameGrid.RowCount = 3;
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.Size = new Size(571, 667);
            GameGrid.TabIndex = 0;
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new Point(384, 449);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "9";
            button9.Size = new Size(181, 212);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += GridButton_Click;
            button9.MouseEnter += GridButton_MouseEnter;
            button9.MouseLeave += GridButton_MouseLeave;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(194, 449);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "8";
            button8.Size = new Size(181, 212);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += GridButton_Click;
            button8.MouseEnter += GridButton_MouseEnter;
            button8.MouseLeave += GridButton_MouseLeave;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(4, 449);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "7";
            button7.Size = new Size(181, 212);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += GridButton_Click;
            button7.MouseEnter += GridButton_MouseEnter;
            button7.MouseLeave += GridButton_MouseLeave;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(384, 227);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "6";
            button6.Size = new Size(181, 212);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += GridButton_Click;
            button6.MouseEnter += GridButton_MouseEnter;
            button6.MouseLeave += GridButton_MouseLeave;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(194, 227);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "5";
            button5.Size = new Size(181, 212);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += GridButton_Click;
            button5.MouseEnter += GridButton_MouseEnter;
            button5.MouseLeave += GridButton_MouseLeave;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(4, 227);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "4";
            button4.Size = new Size(181, 212);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += GridButton_Click;
            button4.MouseEnter += GridButton_MouseEnter;
            button4.MouseLeave += GridButton_MouseLeave;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(384, 5);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "3";
            button3.Size = new Size(181, 212);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += GridButton_Click;
            button3.MouseEnter += GridButton_MouseEnter;
            button3.MouseLeave += GridButton_MouseLeave;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(194, 5);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "2";
            button2.Size = new Size(181, 212);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += GridButton_Click;
            button2.MouseEnter += GridButton_MouseEnter;
            button2.MouseLeave += GridButton_MouseLeave;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(4, 5);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "1";
            button1.Size = new Size(181, 212);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += GridButton_Click;
            button1.MouseEnter += GridButton_MouseEnter;
            button1.MouseLeave += GridButton_MouseLeave;
            // 
            // ActionButtonGrid
            // 
            ActionButtonGrid.ColumnCount = 1;
            ActionButtonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ActionButtonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ActionButtonGrid.Controls.Add(StatusLabel, 0, 0);
            ActionButtonGrid.Controls.Add(PlayButton, 0, 1);
            ActionButtonGrid.Location = new Point(21, 715);
            ActionButtonGrid.Margin = new Padding(4, 5, 4, 5);
            ActionButtonGrid.Name = "ActionButtonGrid";
            ActionButtonGrid.RowCount = 2;
            ActionButtonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActionButtonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActionButtonGrid.Size = new Size(571, 122);
            ActionButtonGrid.TabIndex = 1;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new System.Drawing.Font("Sitka Banner Semibold", 20.2499981F, FontStyle.Bold);
            StatusLabel.Location = new Point(4, 0);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(563, 60);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Click Play to Start";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayButton
            // 
            PlayButton.Location = new Point(4, 66);
            PlayButton.Margin = new Padding(4, 5, 4, 5);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(563, 51);
            PlayButton.TabIndex = 1;
            PlayButton.Text = "PLAY";
            PlayButton.UseMnemonic = false;
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // LowerLayout
            // 
            LowerLayout.ColumnCount = 2;
            LowerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LowerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LowerLayout.Controls.Add(Player2NameBox, 1, 1);
            LowerLayout.Controls.Add(Player2NameLabel, 1, 0);
            LowerLayout.Controls.Add(Player1Label, 0, 0);
            LowerLayout.Controls.Add(Player1NameBox, 0, 1);
            LowerLayout.Location = new Point(21, 867);
            LowerLayout.Margin = new Padding(4, 5, 4, 5);
            LowerLayout.Name = "LowerLayout";
            LowerLayout.RowCount = 2;
            LowerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LowerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LowerLayout.Size = new Size(571, 122);
            LowerLayout.TabIndex = 2;
            // 
            // Player2NameBox
            // 
            Player2NameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            Player2NameBox.Location = new Point(289, 66);
            Player2NameBox.Margin = new Padding(4, 5, 4, 5);
            Player2NameBox.Name = "Player2NameBox";
            Player2NameBox.Size = new Size(275, 39);
            Player2NameBox.TabIndex = 3;
            // 
            // Player2NameLabel
            // 
            Player2NameLabel.Location = new Point(289, 0);
            Player2NameLabel.Margin = new Padding(4, 0, 4, 0);
            Player2NameLabel.Name = "Player2NameLabel";
            Player2NameLabel.Size = new Size(277, 60);
            Player2NameLabel.TabIndex = 1;
            Player2NameLabel.Text = "Enter Player 2 Name Below";
            Player2NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Player1Label
            // 
            Player1Label.Location = new Point(4, 0);
            Player1Label.Margin = new Padding(4, 0, 4, 0);
            Player1Label.Name = "Player1Label";
            Player1Label.Size = new Size(277, 60);
            Player1Label.TabIndex = 0;
            Player1Label.Text = "Enter Player 1 Name Below";
            Player1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Player1NameBox
            // 
            Player1NameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            Player1NameBox.Location = new Point(4, 66);
            Player1NameBox.Margin = new Padding(4, 5, 4, 5);
            Player1NameBox.Name = "Player1NameBox";
            Player1NameBox.Size = new Size(275, 39);
            Player1NameBox.TabIndex = 2;
            // 
            // AIPlayerGroupBox
            // 
            AIPlayerGroupBox.Controls.Add(Player2CheckBox);
            AIPlayerGroupBox.Controls.Add(Player1CheckBox);
            AIPlayerGroupBox.Location = new Point(25, 997);
            AIPlayerGroupBox.Name = "AIPlayerGroupBox";
            AIPlayerGroupBox.Size = new Size(562, 92);
            AIPlayerGroupBox.TabIndex = 4;
            AIPlayerGroupBox.TabStop = false;
            AIPlayerGroupBox.Text = "AI_Player";
            // 
            // Player2CheckBox
            // 
            Player2CheckBox.AutoSize = true;
            Player2CheckBox.Location = new Point(376, 43);
            Player2CheckBox.Name = "Player2CheckBox";
            Player2CheckBox.Size = new Size(100, 29);
            Player2CheckBox.TabIndex = 1;
            Player2CheckBox.Text = "Player 2";
            Player2CheckBox.UseVisualStyleBackColor = true;
            Player2CheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // Player1CheckBox
            // 
            Player1CheckBox.AutoSize = true;
            Player1CheckBox.Location = new Point(56, 43);
            Player1CheckBox.Name = "Player1CheckBox";
            Player1CheckBox.Size = new Size(100, 29);
            Player1CheckBox.TabIndex = 0;
            Player1CheckBox.Text = "Player 1";
            Player1CheckBox.UseVisualStyleBackColor = true;
            Player1CheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Options });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(615, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // Options
            // 
            Options.DropDownItems.AddRange(new ToolStripItem[] { ChangeThemeMenu, AIDifficultyComboBox });
            Options.Name = "Options";
            Options.Size = new Size(92, 29);
            Options.Text = "Options";
            // 
            // ChangeThemeMenu
            // 
            ChangeThemeMenu.Name = "ChangeThemeMenu";
            ChangeThemeMenu.Size = new Size(232, 34);
            ChangeThemeMenu.Text = "Change Theme";
            ChangeThemeMenu.Click += ChangeThemeMenu_Click;
            // 
            // AIDifficultyComboBox
            // 
            AIDifficultyComboBox.Name = "AIDifficultyComboBox";
            AIDifficultyComboBox.Size = new Size(121, 33);
            AIDifficultyComboBox.Text = "Select AI Difficulty";
            AIDifficultyComboBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            AIDifficultyComboBox.SelectedIndex = 0;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 1111);
            Controls.Add(AIPlayerGroupBox);
            Controls.Add(LowerLayout);
            Controls.Add(ActionButtonGrid);
            Controls.Add(GameGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GameView";
            Text = "TicTacToe";
            GameGrid.ResumeLayout(false);
            ActionButtonGrid.ResumeLayout(false);
            LowerLayout.ResumeLayout(false);
            LowerLayout.PerformLayout();
            AIPlayerGroupBox.ResumeLayout(false);
            AIPlayerGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel GameGrid;
        private TableLayoutPanel ActionButtonGrid;
        private Label StatusLabel;
        private Button PlayButton;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel LowerLayout;
        private TextBox Player2NameBox;
        private Label Player2NameLabel;
        private Label Player1Label;
        private TextBox Player1NameBox;
        private Controller.Controller gameController;
        private GroupBox AIPlayerGroupBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Options;
        private ToolStripMenuItem ChangeThemeMenu;
        private CheckBox Player1CheckBox;
        private CheckBox Player2CheckBox;
        private ToolStripComboBox AIDifficultyComboBox;
    }
}
